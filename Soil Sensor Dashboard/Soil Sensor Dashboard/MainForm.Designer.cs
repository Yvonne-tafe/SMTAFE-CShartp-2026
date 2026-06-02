namespace Soil_Sensor_Dashboard
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Menu = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            RBAllData = new RadioButton();
            RBSelectData = new RadioButton();
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            DTPStartTime = new DateTimePicker();
            label2 = new Label();
            DTPEndTime = new DateTimePicker();
            BTSetTime = new Button();
            flowLayoutPanel3 = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            TBUpperBound = new TextBox();
            TBLowerBound = new TextBox();
            ResetBounds = new Button();
            flowLayoutPanel4 = new FlowLayoutPanel();
            flowLayoutPanel5 = new FlowLayoutPanel();
            flowLayoutPanel6 = new FlowLayoutPanel();
            PreSensor = new PictureBox();
            CurrentSensorID = new Label();
            NextSensor = new PictureBox();
            CalculateAverage = new Button();
            button4 = new Button();
            sensorDataGridView = new DataGridView();
            NoColume = new DataGridViewTextBoxColumn();
            Menu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            flowLayoutPanel4.SuspendLayout();
            flowLayoutPanel5.SuspendLayout();
            flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PreSensor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NextSensor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sensorDataGridView).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Size = new Size(944, 24);
            Menu.TabIndex = 0;
            Menu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToolStripMenuItem, loadToolStripMenuItem, exitToolStripMenuItem });
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(100, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += Save_Click;
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += LoadBinFile_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(100, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel4, 0, 2);
            tableLayoutPanel1.Location = new Point(12, 39);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.852459F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.803278F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 64.34426F));
            tableLayoutPanel1.Size = new Size(921, 489);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(224, 224, 224);
            flowLayoutPanel1.Controls.Add(RBAllData);
            flowLayoutPanel1.Controls.Add(RBSelectData);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(BTSetTime);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(4, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(913, 85);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // RBAllData
            // 
            RBAllData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RBAllData.AutoSize = true;
            RBAllData.Checked = true;
            RBAllData.Location = new Point(30, 25);
            RBAllData.Margin = new Padding(30, 3, 3, 3);
            RBAllData.Name = "RBAllData";
            RBAllData.Size = new Size(66, 19);
            RBAllData.TabIndex = 0;
            RBAllData.TabStop = true;
            RBAllData.Text = "All Data";
            RBAllData.UseVisualStyleBackColor = true;
            RBAllData.CheckedChanged += RBAllData_CheckedChanged;
            // 
            // RBSelectData
            // 
            RBSelectData.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            RBSelectData.AutoSize = true;
            RBSelectData.Location = new Point(102, 25);
            RBSelectData.Name = "RBSelectData";
            RBSelectData.Size = new Size(115, 19);
            RBSelectData.TabIndex = 1;
            RBSelectData.Text = "Select date range";
            RBSelectData.UseVisualStyleBackColor = true;
            RBSelectData.CheckedChanged += RBSelectData_CheckedChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(DTPStartTime);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(DTPEndTime);
            flowLayoutPanel2.Enabled = false;
            flowLayoutPanel2.Location = new Point(223, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(284, 63);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 8);
            label1.Margin = new Padding(3, 8, 3, 0);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Start Date : ";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DTPStartTime
            // 
            DTPStartTime.Location = new Point(76, 3);
            DTPStartTime.Name = "DTPStartTime";
            DTPStartTime.Size = new Size(200, 23);
            DTPStartTime.TabIndex = 1;
            DTPStartTime.Value = new DateTime(2026, 5, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 37);
            label2.Margin = new Padding(7, 8, 3, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 2;
            label2.Text = "End Date : ";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DTPEndTime
            // 
            DTPEndTime.Location = new Point(76, 32);
            DTPEndTime.Name = "DTPEndTime";
            DTPEndTime.Size = new Size(200, 23);
            DTPEndTime.TabIndex = 3;
            // 
            // BTSetTime
            // 
            BTSetTime.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BTSetTime.Location = new Point(520, 36);
            BTSetTime.Margin = new Padding(10, 3, 3, 10);
            BTSetTime.Name = "BTSetTime";
            BTSetTime.Size = new Size(75, 23);
            BTSetTime.TabIndex = 3;
            BTSetTime.Text = "Set";
            BTSetTime.UseVisualStyleBackColor = true;
            BTSetTime.Click += DateSet_Click;
            // 
            // flowLayoutPanel3
            // 
            flowLayoutPanel3.Controls.Add(tableLayoutPanel2);
            flowLayoutPanel3.Controls.Add(ResetBounds);
            flowLayoutPanel3.Location = new Point(4, 96);
            flowLayoutPanel3.Name = "flowLayoutPanel3";
            flowLayoutPanel3.Size = new Size(913, 53);
            flowLayoutPanel3.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Controls.Add(label6, 1, 0);
            tableLayoutPanel2.Controls.Add(label7, 2, 0);
            tableLayoutPanel2.Controls.Add(TBUpperBound, 1, 1);
            tableLayoutPanel2.Controls.Add(TBLowerBound, 2, 1);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(577, 45);
            tableLayoutPanel2.TabIndex = 4;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(123, 15);
            label3.Name = "label3";
            label3.Size = new Size(66, 30);
            label3.TabIndex = 0;
            label3.Text = "Moisture :  ";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(249, 0);
            label6.Name = "label6";
            label6.Size = new Size(77, 15);
            label6.TabIndex = 3;
            label6.Text = "Upper Bound";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            label7.AutoSize = true;
            label7.Location = new Point(442, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 15);
            label7.TabIndex = 4;
            label7.Text = "Lower Bound";
            // 
            // TBUpperBound
            // 
            TBUpperBound.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBUpperBound.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TBUpperBound.Location = new Point(238, 18);
            TBUpperBound.Name = "TBUpperBound";
            TBUpperBound.Size = new Size(100, 22);
            TBUpperBound.TabIndex = 5;
            TBUpperBound.TextAlign = HorizontalAlignment.Center;
            // 
            // TBLowerBound
            // 
            TBLowerBound.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            TBLowerBound.Location = new Point(430, 18);
            TBLowerBound.Name = "TBLowerBound";
            TBLowerBound.Size = new Size(100, 23);
            TBLowerBound.TabIndex = 8;
            TBLowerBound.TextAlign = HorizontalAlignment.Center;
            // 
            // ResetBounds
            // 
            ResetBounds.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ResetBounds.Location = new Point(593, 25);
            ResetBounds.Margin = new Padding(10, 3, 3, 3);
            ResetBounds.Name = "ResetBounds";
            ResetBounds.Size = new Size(101, 23);
            ResetBounds.TabIndex = 5;
            ResetBounds.Text = "Set Bounds";
            ResetBounds.UseVisualStyleBackColor = true;
            ResetBounds.Click += ResetBounds_Click;
            // 
            // flowLayoutPanel4
            // 
            flowLayoutPanel4.BackColor = Color.FromArgb(224, 224, 224);
            flowLayoutPanel4.Controls.Add(flowLayoutPanel5);
            flowLayoutPanel4.Controls.Add(sensorDataGridView);
            flowLayoutPanel4.Location = new Point(4, 178);
            flowLayoutPanel4.Name = "flowLayoutPanel4";
            flowLayoutPanel4.Size = new Size(913, 286);
            flowLayoutPanel4.TabIndex = 6;
            // 
            // flowLayoutPanel5
            // 
            flowLayoutPanel5.Controls.Add(flowLayoutPanel6);
            flowLayoutPanel5.Controls.Add(CalculateAverage);
            flowLayoutPanel5.Controls.Add(button4);
            flowLayoutPanel5.Location = new Point(3, 3);
            flowLayoutPanel5.Name = "flowLayoutPanel5";
            flowLayoutPanel5.Size = new Size(874, 65);
            flowLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel6
            // 
            flowLayoutPanel6.Controls.Add(PreSensor);
            flowLayoutPanel6.Controls.Add(CurrentSensorID);
            flowLayoutPanel6.Controls.Add(NextSensor);
            flowLayoutPanel6.Location = new Point(50, 3);
            flowLayoutPanel6.Margin = new Padding(50, 3, 3, 3);
            flowLayoutPanel6.Name = "flowLayoutPanel6";
            flowLayoutPanel6.Size = new Size(196, 57);
            flowLayoutPanel6.TabIndex = 0;
            flowLayoutPanel6.Paint += flowLayoutPanel6_Paint;
            // 
            // PreSensor
            // 
            PreSensor.Image = (Image)resources.GetObject("PreSensor.Image");
            PreSensor.Location = new Point(3, 3);
            PreSensor.Name = "PreSensor";
            PreSensor.Size = new Size(52, 50);
            PreSensor.SizeMode = PictureBoxSizeMode.Zoom;
            PreSensor.TabIndex = 0;
            PreSensor.TabStop = false;
            PreSensor.Click += PreSensor_Click;
            // 
            // CurrentSensorID
            // 
            CurrentSensorID.Anchor = AnchorStyles.Left;
            CurrentSensorID.AutoSize = true;
            CurrentSensorID.Location = new Point(61, 20);
            CurrentSensorID.Name = "CurrentSensorID";
            CurrentSensorID.Size = new Size(56, 15);
            CurrentSensorID.TabIndex = 1;
            CurrentSensorID.Text = "Sensor ID";
            // 
            // NextSensor
            // 
            NextSensor.Image = (Image)resources.GetObject("NextSensor.Image");
            NextSensor.Location = new Point(123, 3);
            NextSensor.Name = "NextSensor";
            NextSensor.Size = new Size(58, 50);
            NextSensor.SizeMode = PictureBoxSizeMode.Zoom;
            NextSensor.TabIndex = 2;
            NextSensor.TabStop = false;
            NextSensor.Click += NextSensor_Click;
            // 
            // CalculateAverage
            // 
            CalculateAverage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CalculateAverage.Location = new Point(399, 37);
            CalculateAverage.Margin = new Padding(150, 3, 3, 3);
            CalculateAverage.Name = "CalculateAverage";
            CalculateAverage.Size = new Size(113, 23);
            CalculateAverage.TabIndex = 1;
            CalculateAverage.Text = "Calculate Average";
            CalculateAverage.UseVisualStyleBackColor = true;
            CalculateAverage.Click += BTAverage_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button4.Location = new Point(525, 37);
            button4.Margin = new Padding(10, 3, 3, 3);
            button4.Name = "button4";
            button4.Size = new Size(129, 23);
            button4.TabIndex = 2;
            button4.Text = "Load Default Data";
            button4.UseVisualStyleBackColor = true;
            button4.Click += LoadDefaultData_Click;
            // 
            // sensorDataGridView
            // 
            sensorDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sensorDataGridView.Columns.AddRange(new DataGridViewColumn[] { NoColume });
            sensorDataGridView.Location = new Point(3, 74);
            sensorDataGridView.Name = "sensorDataGridView";
            sensorDataGridView.Size = new Size(874, 150);
            sensorDataGridView.TabIndex = 1;
            sensorDataGridView.CellContentClick += sensorDataGridView_CellContentClick;
            // 
            // NoColume
            // 
            NoColume.Frozen = true;
            NoColume.HeaderText = "No.";
            NoColume.Name = "NoColume";
            NoColume.ReadOnly = true;
            NoColume.Width = 35;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 547);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Menu);
            MainMenuStrip = Menu;
            Name = "MainForm";
            Text = "Soil Sensor Dashboard";
            Load += Form1_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            flowLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            flowLayoutPanel4.ResumeLayout(false);
            flowLayoutPanel5.ResumeLayout(false);
            flowLayoutPanel6.ResumeLayout(false);
            flowLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PreSensor).EndInit();
            ((System.ComponentModel.ISupportInitialize)NextSensor).EndInit();
            ((System.ComponentModel.ISupportInitialize)sensorDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip Menu;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private RadioButton RBSelectData;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label1;
        private DateTimePicker DTPStartTime;
        private Label label2;
        private DateTimePicker DTPEndTime;
        private Button BTSetTime;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private Label label6;
        private Button ResetBounds;
        private FlowLayoutPanel flowLayoutPanel3;
        private FlowLayoutPanel flowLayoutPanel4;
        private FlowLayoutPanel flowLayoutPanel5;
        private FlowLayoutPanel flowLayoutPanel6;
        private PictureBox PreSensor;
        private Label CurrentSensorID;
        private PictureBox NextSensor;
        private Button CalculateAverage;
        private Button button4;
        private TextBox TBUpperBound;
        private DataGridView sensorDataGridView;
        private DataGridViewTextBoxColumn NoColume;
        private RadioButton RBAllData;
        private Label label7;
        private TextBox TBLowerBound;
    }
}
