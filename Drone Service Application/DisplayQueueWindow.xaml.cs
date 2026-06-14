using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace Drone_Service_Application
{
    /// <summary>
    /// DisplayQueueWindow is responsible for displaying the current RegularService
    /// and ExpressService queues in ListView controls.
    /// It allows staff to process completed service items by dequeuing the next
    /// regular or express drone service item, adding it to the FinishedList,
    /// and refreshing the queue displays.
    /// </summary>
    public partial class DisplayQueueWindow : Window
    {

        private List<Drone> FinishedList;
        private Queue<Drone> RegularService;
        private Queue<Drone> ExpressService;
        public DisplayQueueWindow(Queue<Drone> regularService, Queue<Drone> expressService, List<Drone> finishedList)
        {
            InitializeComponent();

            RegularService = regularService;
            ExpressService = expressService;
            FinishedList = finishedList;

            DisplayRegularService();
            DisplayExpressService();
        }

        //6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure.
        //The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void Button_Click_CompleteRegular(object sender, RoutedEventArgs e)
        {
            string resultMsg;
            if (IsQueueEmpty(RegularService, out resultMsg))
            {
                CommonControls.SetStatus($"Regular {resultMsg}");
                return;
            }
            Drone finishedDrone = RegularService.Dequeue();
            FinishedList.Add(finishedDrone);
            CommonControls.SetStatus($"Moved the completed regular service '{finishedDrone.Display()}' to Final List.");

            RefreshRegularService();
        }

        //6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure.
        //The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void Button_Click_CompleteExpress(object sender, RoutedEventArgs e)
        {
            string resultMsg;
            if (IsQueueEmpty(ExpressService, out resultMsg))
            {
                CommonControls.SetStatus($"Express {resultMsg}");
                return;
            }
            Drone finishedDrone = ExpressService.Dequeue();
            FinishedList.Add(finishedDrone);
            CommonControls.SetStatus($"Moved the completed express service '{finishedDrone.Display()}' to Final List.");

            RefreshExpressService();
        }

        //6.8 Create a custom method that will display all the elements in the RegularService queue.
        //The display must use a List View and with appropriate column headers.
        private void DisplayRegularService()
        {
            foreach (Drone drone in RegularService)
            {
                lvRegularService.Items.Add(new
                {
                    ClientName = drone.GetClientName(),
                    DroneModel = drone.GetDroneModel(),
                    ServiceProblem = drone.GetServiceProblem(),
                    ServiceCost = drone.GetServiceCost().ToString("F2"),
                    ServiceTag = drone.GetServiceTag()
                });
            }
        }
        
        //6.9	Create a custom method that will display all the elements in the ExpressService queue.
        //The display must use a List View and with appropriate column headers.
        private void DisplayExpressService()
        {
            foreach (Drone drone in ExpressService)
            {
                lvExpressService.Items.Add(new
                {
                    ClientName = drone.GetClientName(),
                    DroneModel = drone.GetDroneModel(),
                    ServiceProblem = drone.GetServiceProblem(),
                    ServiceCost = drone.GetServiceCost().ToString("F2"),
                    ServiceTag = drone.GetServiceTag()
                });
            }
        }

        private void RefreshRegularService()
        {
            lvRegularService.Items.Clear();
            DisplayRegularService();
        }
        private void RefreshExpressService()
        {
            lvExpressService.Items.Clear();
            DisplayExpressService();
        }
        private bool IsQueueEmpty(Queue<Drone> queue, out string resultMsg)
        {
            if (queue.Count > 0)
            {
                resultMsg = "Service Queue is not empty.";
                return false;
            }
            else
            {
                resultMsg = "Service Queue is empty.";
                return true;
            }
        }

    }
}
