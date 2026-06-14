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
using Xceed.Wpf.Toolkit.Primitives;

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
        private List<Drone> FinishedList;
        public DisplayFinalListWindow(List<Drone> finishedList)
        {
            InitializeComponent();

            FinishedList = finishedList;
            DisplayFinalService();
        }

        //to display finished service list inside ListBox
        private void DisplayFinalService()
        {
            string resultMsg;
            if (IsListEmpty(FinishedList, out resultMsg))
            {
                CommonControls.SetStatus($"{resultMsg}");
                return;
            }

            foreach (Drone drone in FinishedList)
            {
                ListBoxItem item = new ListBoxItem();
                item.Content = drone.Display();
                item.MouseDoubleClick += ListBoxItem_MouseDoubleClick;
                item.Tag = drone;

                lstFinishedServices.Items.Add(item);
            }
        }

        //6.16	Create a double mouse click method that will delete a service item from the finished listbox and remove the same item from the List<T>.
        private void ListBoxItem_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is not ListBoxItem selectedItem)
            {
                CommonControls.SetStatus("Fail to select service from Finished Service List.");
                return;
            }
            if (selectedItem.Tag is not Drone droneData)
            {
                CommonControls.SetStatus("Invalid service item selected.");
                return;
            }
            string resultMsg;

            //Remove from List
            if (IsListEmpty(FinishedList, out resultMsg))
            {
                //empty FinishedList
                CommonControls.SetStatus($"{resultMsg}");
                return;
            }
            if (!FinishedList.Remove(droneData))
            {
                //remove Fail
                CommonControls.SetStatus($"Fail to remove service from Finished Service List.");
                return;
            }

            //Remove from ListBox
            lstFinishedServices.Items.Remove(selectedItem);
            CommonControls.SetStatus($"Service '{droneData.Display()}' removed from Finished Service List.");
            return;
        }
        private bool IsListEmpty(List<Drone> list, out string resultMsg)
        {
            if (list.Count > 0)
            {
                resultMsg = "Finished service list is not empty.";
                return false;
            }
            else
            {
                resultMsg = "Finished service list is empty.";
                return true;
            }
        }
    }
}
