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
using System.Xml.Serialization;

namespace Drone_Service_Application
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //6.2 Global List<T> to store finished service items
        private readonly List<Drone> _finishedList = new List<Drone>();
        //6.3 Global Queue<T> to store regular service items
        private readonly Queue<Drone> _regularService = new Queue<Drone>();
        //6.4 Global Queue<T> to store express service items
        private readonly Queue<Drone> _expressService = new Queue<Drone>();

        // for next service tag
        private int nextServiceTag = 100;

        public MainWindow()
        {
            InitializeComponent();
            CommonControls.ShowExitButton(false);
        }
        
        //Click to Add new drone item
        private void Button_Click_AddNewDrone(object sender, RoutedEventArgs e)
        {
            AddNewWindow addWindow = new AddNewWindow(_regularService, _expressService, nextServiceTag);
            addWindow.ShowDialog();

            nextServiceTag = addWindow.NextServiceTag;
            CommonControls.SetStatus("Normal");
        }

        //6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        //6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void Button_Click_ShowQueues(object sender, RoutedEventArgs e)
        {
            DisplayQueueWindow queueWindow = new DisplayQueueWindow(_regularService, _expressService, _finishedList);
            queueWindow.ShowDialog();
        }

        //Click to call the page to show final list
        private void Button_Click_ShowFinalList(object sender, RoutedEventArgs e)
        {
            DisplayFinalListWindow finalListWindow = new DisplayFinalListWindow(_finishedList);
            finalListWindow.ShowDialog();
        }
                
        //Click to exit the app
        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}