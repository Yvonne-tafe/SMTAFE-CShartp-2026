using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DesktopList
{
    public partial class FormDesktopList : Form
    {
        static int MAX = 20;
        string[] DeskList = new string[MAX];
        int nextEmptyTask = 0;

        public FormDesktopList()
        {
            FillDesktopList();
            InitializeComponent();
            DisplayDesktopList();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(RefKeyword.Text))
            {
                //MessageBox.Show("Search for: " + RefKeyword.Text);
                string SearchWord = RefKeyword.Text;
                bool IsFound = false;
                int foundIndex = -1;
                for (int i = 0; i < nextEmptyTask; i++)
                {
                    //if (string.Compare(target, ToDoList[i]) == 0)
                    if (DeskList[i].Contains(SearchWord))
                    {
                        ListBoxDisplayAllDesktopItems.SelectedIndex = i;
                        IsFound = true;
                        foundIndex = i;
                        break;
                    }
                }
                if (IsFound)
                    MessageBox.Show(SearchWord + " is found on array [" + foundIndex + "] ");
                else
                    MessageBox.Show(SearchWord + " cannot Be Found in the desktop list");
            }
            else
            {
                MessageBox.Show("RefKeyword: NOTHING for search");
            }
        }
        private void FillDesktopList()
        {
            DeskList[0] = "01. CPU";
            DeskList[1] = "02. RAM";
            DeskList[2] = "03. Screen";
            DeskList[3] = "04. Storage";
            DeskList[4] = "05. keyboard";
            DeskList[5] = "06. Mouse";
            DeskList[6] = "07. Graph Card";
            DeskList[7] = "08. Motherboard";
            DeskList[8] = "09. power core";
            DeskList[9] = "10. Fans";
            nextEmptyTask = 10;
        }
        private void DisplayDesktopList()
        {
            ListBoxDisplayAllDesktopItems.Items.Clear();
            for (int x = 0; x < nextEmptyTask; x++)
            {
                ListBoxDisplayAllDesktopItems.Items.Add(DeskList[x]);
            }
        }

        private void SearchByFun_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(RefKeyword.Text))
            {
                //MessageBox.Show("Search for: " + RefKeyword.Text);
                string SearchWord = RefKeyword.Text;
                int foundIndex = -1;
                bool SearchResult = IsFound(SearchWord, foundIndex);

                if (SearchResult)
                    MessageBox.Show(SearchWord + " is found on array [" + foundIndex + "] ");
                else
                    MessageBox.Show(SearchWord + " cannot Be Found in the desktop list");
            }
            else
            {
                MessageBox.Show("RefKeyword: NOTHING for search");
            }

        }

        private bool IsFound(string SearchWord, int index)
        {

            bool IsFound = false;
            for (int i = 0; i < nextEmptyTask; i++)
            {
                //if (string.Compare(target, ToDoList[i]) == 0)
                if (DeskList[i].Contains(SearchWord))
                {
                    ListBoxDisplayAllDesktopItems.SelectedIndex = i;
                    IsFound = true;
                    index = i;
                    break;
                }
            }
            return IsFound;
        }

        private void RefKeyword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
