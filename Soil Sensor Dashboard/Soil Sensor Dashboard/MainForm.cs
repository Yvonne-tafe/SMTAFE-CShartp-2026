using System.Diagnostics;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Web;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Soil_Sensor_Dashboard
{
    public partial class MainForm : Form
    {
        private string SensorFileName = "SensorFiles.csv";
        private string StoreFolderName = "StoreData";

        private List<DataFile> loadedFiles;
        private int currentFileIndex = 0;
        private List<SensorData> originalData;
        private List<SensorData> currentDisplayData;
        private double lowerBound = 30;
        private double upperBound = 80;
        private DateTime startTime;
        private DateTime endTime;

        private FileManager fileManager = new FileManager();
        private DataProcessor dataProcessor = DataProcessor.GetInstance();
        private MessageService messageService = new MessageService();

        public MainForm()
        {
            InitializeComponent();
            // TODO:
            //sensorDataGridView.DataBindingComplete += sensorDataGridView_DataBindingComplete;
            initMainForm();
        }
        private void initMainForm()
        {
            loadedFiles = new List<DataFile>();
            // Error - proofing here
            if (!LoadFile(out string msg))
            {
                messageService.ShowError(msg);
                Environment.Exit(0);
                return;
            }

            // Error - proofing here
            var firstItem = loadedFiles.FirstOrDefault();
            if (firstItem == null)
            {
                messageService.ShowError("system initial failed");
                Environment.Exit(0);
                return;
            }
            originalData = firstItem.OriginalData;
            currentDisplayData = firstItem.CurrentDisplayData;

            UIinit();
        }
        private void UIinit()
        {
            //time UI init
            GetStartAndEndTime();
            DTPStartTime.MinDate = startTime;
            DTPStartTime.MaxDate = endTime;
            DTPStartTime.Value = startTime;
            DTPEndTime.MinDate = startTime;
            DTPEndTime.MaxDate = endTime;
            DTPEndTime.Value = endTime;

            //bound UI init
            TBLowerBound.Text = lowerBound.ToString();
            TBUpperBound.Text = upperBound.ToString();

            DisplayCurrentData();
        }
        private void GetStartAndEndTime()
        {
            dataProcessor.SortByTimestamp(currentDisplayData);
            //Error - proofing here
            var firstItem = currentDisplayData.FirstOrDefault();
            var lastItem = currentDisplayData.LastOrDefault();
            if (firstItem == null || lastItem == null)
            {
                messageService.ShowError("Time initila error");
            }

            endTime = firstItem?.CreateTime ?? DateTime.Today;
            startTime = lastItem?.CreateTime ?? DateTime.Today; ;
        }
        private bool LoadFile(out string msg)
        {
            loadedFiles = new List<DataFile>();
            string path = Path.Combine(Application.StartupPath, SensorFileName);
            //Error - proofing here
            if (!File.Exists(path))
            {
                msg = $"Default Data missing";
                return false; 
            }

            var lines = File.ReadAllLines(path);
            for (int i = 1; i < lines.Length; i++) // skip header
            {
                //Error - proofing here
                if (string.IsNullOrWhiteSpace(lines[i])) continue;

                var parts = lines[i].Split(',');

                //Error - proofing here
                if (parts.Length < 3) continue;

                if (parts[2] == "default")
                {
                    if (!fileManager.LoadFile(Path.Combine(Application.StartupPath, parts[0]), loadedFiles, out msg))
                    {
                        return false;
                    }
                }
            }
            msg = $"Succeeded";
            return true;
        }
        private void LoadBinFile_Click(object sender, EventArgs e)
        {
            if (!LoadBinFile(out string msg))
            {
                messageService.ShowError(msg);
            } else
            {
                messageService.ShowAction(msg);
            }
        }
        private bool LoadBinFile(out string msg)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                string defaultFolder = Path.Combine(Application.StartupPath, StoreFolderName);

                // create defaultFolder if not existiing
                if (!Directory.Exists(defaultFolder))
                {
                    Directory.CreateDirectory(defaultFolder);
                }
                openFileDialog.InitialDirectory = defaultFolder;

                //fileter setup, .bin only
                openFileDialog.Title = "Open Sensor Data File";
                openFileDialog.Filter = "Binary Files (*.bin)|*.bin|All Files (*.*)|*.*";
                openFileDialog.FilterIndex = 1; // first condition (*.bin)

                //show diolog
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    loadedFiles = new List<DataFile>();
                    if (!fileManager.LoadBinFile(openFileDialog.FileName, loadedFiles, out msg))
                    {
                        return false;
                    }
                    // Error - proofing here
                    var firstItem = loadedFiles.FirstOrDefault();
                    if (firstItem == null)
                    {
                        msg = $"bin file loading error!";
                        return false;
                    }
                    originalData = firstItem.OriginalData;
                    currentDisplayData = firstItem.CurrentDisplayData;
                    currentFileIndex = 0;

                    UIinit();
                    msg = $"File loaded!";
                } else
                {
                    msg = $"File loaded Cancel!";
                }
                
                return true;
            }
        }
        private void sensorDataGridView_DataBindingComplete(
    object sender,
    DataGridViewBindingCompleteEventArgs e)
        {
            ApplyCellColors();
            sensorDataGridView.ClearSelection();
        }
        private void DisplayCurrentData()
        {
            object[,] gridData = dataProcessor.ConvertTo2DArray(currentDisplayData);

            int rowCount = gridData.GetLength(0);
            int colCount = gridData.GetLength(1);

            sensorDataGridView.Rows.Clear();
            sensorDataGridView.Columns.Clear();
            sensorDataGridView.Columns.Add($"CreateTime", $"Create Time");
            sensorDataGridView.Columns.Add($"SensorID", $"Sensor ID");
            sensorDataGridView.Columns.Add($"Moisture", $"Moisture");

            for (int r = 0; r < rowCount; r++)
            {
                int rowIndex = sensorDataGridView.Rows.Add();

                for (int c = 0; c < colCount; c++)
                {
                    sensorDataGridView.Rows[rowIndex].Cells[c].Value = gridData[r, c].ToString();
                }
            }

            ApplyCellColors();
        }
        private void ApplyCellColors()
        {
            foreach (DataGridViewRow row in sensorDataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                SetCellColourByRange(row, "Moisture", lowerBound, upperBound);
            }
        }
        private void SetCellColourByRange(DataGridViewRow row, string columnName, double low, double high)
        {
            if (row.Cells[columnName].Value == null) return;
            float value = Convert.ToSingle(row.Cells[columnName].Value);
            if (value < low)
            {
                row.Cells[columnName].Style.BackColor = Color.LightBlue;   // low
            }
            else if (value > high)
            {
                row.Cells[columnName].Style.BackColor = Color.LightCoral;    // high
            }
            else
            {
                row.Cells[columnName].Style.BackColor = Color.LightGreen;   // acceptable
            }
        }
        private void LoadDefaultData_Click(object sender, EventArgs e)
        {
            initMainForm();
            messageService.ShowAction($"Re-loaded Default Data!");
        }
        private void Save_Click(object sender, EventArgs e)
        {
            SaveCurrentDisplayData();
        }
        private void SaveCurrentDisplayData()
        {
            SaveToBinFile(currentDisplayData);
        }
        private void SaveToBinFile(List<SensorData> data)
        {
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            if (!fileManager.SaveBinaryFile(Path.Combine(Application.StartupPath, $"{StoreFolderName}/{timestamp}_Stored.bin"), data, out string msg))
            {
                messageService.ShowError($"msg");
            } else
            {
                messageService.ShowAction($"File: Saved!");
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTAverage_Click(object sender, EventArgs e)
        {
            showAverage();
        }
        private void showAverage()
        {
            double averageMoisture = dataProcessor.CalculateAverageMoisture(currentDisplayData);
            messageService.ShowAction($"Calculate Average of Moisture: {averageMoisture.ToString("F2")}");
        }


        private void PreSensor_Click(object sender, EventArgs e)
        {
            if (currentFileIndex > 0)
            {
                MovePreviousFile();
                messageService.ShowAction("Display previous Sensor");
            }
            else
            {
                messageService.ShowAction("No Previous Sensor");
            }
        }
        private void MovePreviousFile()
        {
            currentFileIndex--;
            originalData = loadedFiles[currentFileIndex].OriginalData;
            currentDisplayData = loadedFiles[currentFileIndex].CurrentDisplayData;
            RBAllData.Checked = true;
            UIinit();
        }
        private void NextSensor_Click(object sender, EventArgs e)
        {
            if (currentFileIndex < (loadedFiles.Count - 1))
            {
                MoveNextFile();
                messageService.ShowAction("Display Next Sensor");
            }
            else
            {
                messageService.ShowAction("No Next Sensor");
            }
        }
        private void MoveNextFile()
        {
            currentFileIndex++;
            originalData = loadedFiles[currentFileIndex].OriginalData;
            currentDisplayData = loadedFiles[currentFileIndex].CurrentDisplayData;
            RBAllData.Checked = true;
            UIinit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void sensorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //time filter
        private void RBAllData_CheckedChanged(object sender, EventArgs e)
        {
            if (RBAllData.Checked)
            {
                RBSelectData.Checked = false;
                flowLayoutPanel2.Enabled = false;
            }
        }
        private void RBSelectData_CheckedChanged(object sender, EventArgs e)
        {
            if (RBSelectData.Checked)
            {
                RBAllData.Checked = false;
                flowLayoutPanel2.Enabled = true;
            }
        }
        private void DateSet_Click(object sender, EventArgs e)
        {
            if (RBAllData.Checked)
            {
                ResetFilter();
                messageService.ShowAction("Display all Date");
            }
            else
            {
                ApplyTimestampFilter();
                messageService.ShowAction("Display Selected Period");
            }
            DisplayCurrentData();
        }
        private void ApplyTimestampFilter()
        {
            DateTime pickedStartTime = DTPStartTime.Value;
            DateTime pickedEndTime = DTPEndTime.Value;
            currentDisplayData = dataProcessor.FileterByTimestampRange(originalData, pickedStartTime, pickedEndTime);

        }
        private void ResetFilter()
        {
            currentDisplayData = originalData.ToList();
        }
        private void ResetBounds_Click(object sender, EventArgs e)
        {
            if (!BoundSetupValidation())
                return;
            ApplyCellColors();
            messageService.ShowAction("Bound Value Reset");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool BoundSetupValidation()
        {
            if (string.IsNullOrWhiteSpace(TBLowerBound.Text) || string.IsNullOrWhiteSpace(TBUpperBound.Text))
            {
                messageService.ShowError("Please enter both lower bound and upper bound.");
                return false;
            }

            if (!double.TryParse(TBLowerBound.Text, out double tempLower))
            {
                messageService.ShowError("Lower bound must be a number.");
                return false;
            }

            if (!double.TryParse(TBUpperBound.Text, out double tempUpper))
            {
                messageService.ShowError("Upper bound must be a number.");
                return false;
            }

            if (lowerBound >= upperBound)
            {
                messageService.ShowError("Lower bound must be less than upper bound.");
                return false;
            }
            lowerBound = tempLower;
            upperBound = tempUpper;
            return true;
        }
    }
}
