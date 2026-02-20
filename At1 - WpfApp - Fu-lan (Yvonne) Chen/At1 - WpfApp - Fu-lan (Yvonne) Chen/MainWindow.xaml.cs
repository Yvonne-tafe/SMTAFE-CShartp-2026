using Microsoft.Win32;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace At1___WpfApp___Fu_lan__Yvonne__Chen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // See https://aka.ms/new-console-template for more information
            //using System.Runtime.CompilerServices;
            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.FileName = "Output_from_WPH.txt";
            //if (saveFileDialog.ShowDialog() == true)
            //{
            //    string f_path = saveFileDialog.FileName;
            //}
            //string input_numbers_string = Console.ReadLine();
            string input_numbers_string = Number_one.Text + "," + Number_two.Text;
            string[] input_numbers = input_numbers_string.Split(',');
            string output_numbers = "";
            MessageBox.Show("Here");
            foreach (string input_number in input_numbers)
            {
                double double_value = Convert.ToDouble(input_number);
                //Console.WriteLine("\n double value is: " + double_value);
                output_numbers += "double value is: " + double_value.ToString() + "\n";
            }
            MessageBox.Show(output_numbers);
            File.AppendAllText("output_double_value.txt", string.Join("\n", output_numbers));
            string f_path = System.IO.Path.GetFullPath("output_double_value.txt");
            MessageBox.Show("Saved to " + f_path);

        }
    }
}