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
    public class Vehicle
    {
        public string Rego { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Boolean HasAirbag { get; set; }
        public void Drive_Vehicle()
        {
            MessageBox.Show("the vehicle is driving");
        }
        public void Stop_Vehicle()
        {
            MessageBox.Show("the vehicle is stopping");
        }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Vehicle new_vehicle = new Vehicle();
            new_vehicle.Rego = rego.Text;
            new_vehicle.Brand = brand.Text;
            new_vehicle.Model = model.Text;
            new_vehicle.Color = color.Text;
            ComboBoxItem v_sirbag = (ComboBoxItem) hasairbag.SelectedItem;
            if (v_sirbag.Tag.ToString() == "1")
            {
                new_vehicle.HasAirbag = true;
            } else
            {
                new_vehicle.HasAirbag = false;
            }
            vehicle_add_info(new_vehicle);
        }
        private void vehicle_add_info(Vehicle new_vehicle)
        {
            string vehicle_info = "Information of the Vehicle: \n";
            vehicle_info += "Rego: " + new_vehicle.Rego + "\n";
            vehicle_info += "Brand: " + new_vehicle.Brand + "\n";
            vehicle_info += "Model: " + new_vehicle.Model + "\n";
            vehicle_info += "Color: " + new_vehicle.Model + "\n";
            if (new_vehicle.HasAirbag)
            {
                vehicle_info += "HasAirBag: Yes;" + "\n";
            } else
            {
                vehicle_info += "HasAirBag: No;" + "\n";
            }
            File.AppendAllText("Vehicle_info.txt", string.Join("\n", vehicle_info));
            MessageBox.Show("Vehicle Added");
        }

    }
}