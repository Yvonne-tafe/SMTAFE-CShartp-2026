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
        private List<Drone> FinishedList = new List<Drone>();
        //6.3 Global Queue<T> to store regular service items
        private Queue<Drone> RegularService = new Queue<Drone>();
        //6.4 Global Queue<T> to store express service items
        private Queue<Drone> ExpressService = new Queue<Drone>();

        // for next service tag
        private int nextServiceTag = 100;

        public MainWindow()
        {
            InitializeComponent();
            CommonControls.ShowExitButton(false);
            TestData();
        }
        private void TestData()
        {
            Drone newDrone = new Drone();
            newDrone.SetClientName("Test1");
            newDrone.SetDroneModel("TestModel1");
            newDrone.SetServiceCost(100);
            newDrone.SetServiceProblem("Test Problem 1");
            newDrone.SetServiceTag(100);
            RegularService.Enqueue(newDrone);

            newDrone = new Drone();
            newDrone.SetClientName("Test2");
            newDrone.SetDroneModel("TestModel2");
            newDrone.SetServiceCost(150);
            newDrone.SetServiceProblem("Test Problem 2");
            newDrone.SetServiceTag(110);
            RegularService.Enqueue(newDrone);

            newDrone = new Drone();
            newDrone.SetClientName("Test3");
            newDrone.SetDroneModel("TestModel3");
            newDrone.SetServiceCost(170);
            newDrone.SetServiceProblem("Test Problem 3");
            newDrone.SetServiceTag(120);
            RegularService.Enqueue(newDrone);

            newDrone = new Drone();
            newDrone.SetClientName("Test4");
            newDrone.SetDroneModel("TestModel4");
            newDrone.SetServiceCost(115);
            newDrone.SetServiceProblem("Test Problem 4");
            newDrone.SetServiceTag(130);
            ExpressService.Enqueue(newDrone);

            newDrone = new Drone();
            newDrone.SetClientName("Test5");
            newDrone.SetDroneModel("TestModel5");
            newDrone.SetServiceCost(175);
            newDrone.SetServiceProblem("Test Problem 5");
            newDrone.SetServiceTag(140);
            ExpressService.Enqueue(newDrone);
            nextServiceTag = 150;
        }

        //Click to Add new drone item
        private void Button_Click_AddNewDrone(object sender, RoutedEventArgs e)
        {
            AddNewWindow addWindow = new AddNewWindow(RegularService, ExpressService, nextServiceTag);
            addWindow.ShowDialog();

            nextServiceTag = addWindow.NextServiceTag;
            CommonControls.SetStatus("Normal");
        }

        //6.12	Create a mouse click method for the regular service ListView that will display the Client Name and Service Problem in the related textboxes.
        //6.13	Create a mouse click method for the express service ListView that will display the Client Name and Service Problem in the related textboxes.
        private void Button_Click_ShowQueues(object sender, RoutedEventArgs e)
        {
            DisplayQueueWindow addWindow = new DisplayQueueWindow(RegularService, ExpressService, FinishedList);
            addWindow.ShowDialog();
        }

        //Click to call the page to show final list
        private void Button_Click_ShowFinalList(object sender, RoutedEventArgs e)
        {
            DisplayFinalListWindow addWindow = new DisplayFinalListWindow();
            addWindow.ShowDialog();
        }
                
        //Click to exit the app
        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}