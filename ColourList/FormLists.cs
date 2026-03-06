using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
// WARNING Limited error trapping!
// Simple list of strings.
namespace MyLists
{
    public partial class FormLists : Form
    {
        public FormLists()
        {
            InitializeComponent();
            DisplayList();
        }
        List<ColorData> ColorHexCodeList = new List<ColorData>{
                new ColorData("Blue", "#0000FF"),
                new ColorData("Red", "#FF0000"),
                new ColorData("Yellow", "#FFFF00"),
                new ColorData("Green", "#008000"),
                new ColorData("Orange", "#FFA500"),
                new ColorData("Purple", "#800080"),
                new ColorData("Cyan", "#00FFFF"),
                new ColorData("Pink", "#FFC0CB"),
                new ColorData("White", "#FFFFFF"),
                new ColorData("Black", "#000000"),
                new ColorData("Peach", "#FFDAB9"),
                new ColorData("Gold", "#FFD700"),
                new ColorData("Maroon", "#800000"),
                new ColorData("Violet", "#EE82EE")
        };

        #region AddEditDel
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text) 
                && (ValidName(textBoxInput.Text)) 
                && !string.IsNullOrWhiteSpace(ColorHexCode.Text)
                && (ValidName(ColorHexCode.Text)))
            {

                ColorHexCodeList.Add(new ColorData(textBoxInput.Text, ColorHexCode.Text));
                DisplayList();
                textBoxInput.Clear();
                textBoxInput.Focus();
            }
            else
            {
                labelErrorMsg.Text = "Error: no data added";
            }
        }
        private bool ValidName(string checkThisName)
        {
            if (ColorHexCodeList.Exists(duplicate => duplicate.Equals(checkThisName)))
                return false;
            else
                return true;
        }
        private string GetTextBoxInput(string TextBoxInput)
        {
            int colonIndex = TextBoxInput.IndexOf(';');
            if (colonIndex > 0)
            {
                return TextBoxInput.Substring(0, colonIndex).Trim();
            }
            return "";
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text)
                && (ValidName(textBoxInput.Text))
                && !string.IsNullOrWhiteSpace(ColorHexCode.Text)
                && (ValidName(ColorHexCode.Text)))
            {
                ColorHexCodeList[listBoxDisplay.SelectedIndex].Name = textBoxInput.Text;
                ColorHexCodeList[listBoxDisplay.SelectedIndex].HexCode = ColorHexCode.Text;
                textBoxInput.Clear();
                DisplayList();
            }
            else
            {
                labelErrorMsg.Text = "Error: no data Edit";
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxDisplay.SelectedIndex < 0)
            {
                labelErrorMsg.Text = "Error: no data Selected";
                return;
            }
            listBoxDisplay.SetSelected(listBoxDisplay.SelectedIndex, true);
            ColorHexCodeList.RemoveAt(listBoxDisplay.SelectedIndex);
            DisplayList();
        }
        #endregion AddEditDel

        #region Utility
        private void DisplayList()
        {
            listBoxDisplay.Items.Clear();
            ColorHexCodeList.Sort((x,y) => string.Compare(x.Name, y.Name));
            foreach (var color in ColorHexCodeList)
            {
                listBoxDisplay.Items.Add(color.Name + " ; " + color.HexCode);
            }
        }
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            ColorHexCodeList.Sort((x, y) => string.Compare(x.Name, y.Name));
            ColorData Keyword = new ColorData(GetTextBoxInput(textBoxInput.Text), "");

            if (ColorHexCodeList.BinarySearch(Keyword, Comparer<ColorData>.Create((x, y) => x.Name.CompareTo(y.Name))) >= 0)
                labelErrorMsg.Text = "The colour: "+ Keyword.Name + " has been found";
            else
                labelErrorMsg.Text = "Colour "+ Keyword.Name + " Not Found";
            textBoxInput.Clear();
        }
        private void TextBoxInput_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxInput.Clear();
        }
        private void ListBoxDisplay_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                listBoxDisplay.SetSelected(listBoxDisplay.SelectedIndex, true);
                textBoxInput.Text = ColorHexCodeList.ElementAt(listBoxDisplay.SelectedIndex).Name;
                ColorHexCode.Text = ColorHexCodeList.ElementAt(listBoxDisplay.SelectedIndex).HexCode;
            }
            catch
            {
                return;
            }
        }
        #endregion Utility

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}