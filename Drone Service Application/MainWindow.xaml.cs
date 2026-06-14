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

namespace Drone_Service_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //6.2 Global List<T> to store finished service items
        private List<Drone> FinishedList = new List<Drone>();
        //6.3 Global Queue<T> to store regular service items
        private Queue<Drone> RegularService = new Queue<Drone>();
        //6.4 Global Queue<T> to store express service items
        private Queue<Drone> ExpressService = new Queue<Drone>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewWindow addWindow = new AddNewWindow();
            addWindow.ShowDialog();
        }

        //6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        //6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            DisplayQueueWindow addWindow = new DisplayQueueWindow();
            addWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DisplayFinalListWindow addWindow = new DisplayFinalListWindow();
            addWindow.ShowDialog();
        }
    }
}