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
        public DisplayQueueWindow()
        {
            InitializeComponent();
        }

        //6.14	Create a button click method that will remove a service item from the regular ListView and dequeue the regular service Queue<T> data structure.
        //The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void Button_Click_CompleteRegular(object sender, RoutedEventArgs e)
        {

        }

        //6.15	Create a button click method that will remove a service item from the express ListView and dequeue the express service Queue<T> data structure.
        //The dequeued item must be added to the List<T> and displayed in the ListBox for finished service items.
        private void Button_Click_CompleteExpress(object sender, RoutedEventArgs e)
        {

        }

        //6.8 Create a custom method that will display all the elements in the RegularService queue.
        //The display must use a List View and with appropriate column headers.
        private void DisplayRegularService()
        {
            return;
        }

        //6.9	Create a custom method that will display all the elements in the ExpressService queue.
        //The display must use a List View and with appropriate column headers.
        private void DisplayExpressService()
        {
            return;
        }
    }
}
