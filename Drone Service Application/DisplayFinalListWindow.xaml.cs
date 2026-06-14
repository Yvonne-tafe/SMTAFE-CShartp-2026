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
    /// DisplayFinalListWindow is responsible for displaying completed drone service items.
    /// It shows the FinishedList items in a ListBox using each Drone object's Display() method,
    /// and allows the user to remove a finished service item by double-clicking it after
    /// the client has paid and collected the drone.
    /// </summary>
    public partial class DisplayFinalListWindow : Window
    {
        public DisplayFinalListWindow()
        {
            InitializeComponent();
        }

        //6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //todo
            return;
        }
    }
}
