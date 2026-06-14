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
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;

namespace Drone_Service_Application
{
    /// <summary>
    /// AddNewWindow is responsible for creating new drone service requests.
    /// The window collects drone service information entered by front desk staff,
    /// validates user input, determines the selected service priority,
    /// automatically generates and increments service tags,
    /// and adds new Drone objects to either the RegularService or ExpressService queue.
    /// </summary>
    public partial class AddNewWindow : Window
    {
        public AddNewWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddNewItem();
        }
        //6.5 Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority.
        private void AddNewItem()
        {
            //to do
            //6.5 The new service item will be added to the appropriate Queue based on the Priority radio button.
            //6.6 Before a new service item is added to the Express Queue the service cost must be increased by 15%.

            //6.7 GetServicePriority() must be called inside the “AddNewItem” method before the new service item is added to a queue.
            GetServicePriority();

            //6.11	IncrementServiceTag() must be called inside the “AddNewItem” method before the new service item is added to a queue.
            //todo error control
            int tag = numServiceTag.Value ?? 100; 
            IncrementServiceTag(tag);
            return;
        }
        //6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        private string GetServicePriority()
        {
            if (rdoRegular.IsChecked == true)
            {
                return "Regular";
            }
            else
            {
                return "Express";
            }
        }
        //6.10	Create a custom method to ensure the Service Cost textbox can only accept a double value with two decimal point.
        private bool ValidateServiceCost()
        {
            double serviceCost;

            if (!double.TryParse(txtServiceCost.Text, out serviceCost))
            {
                txtStatus.Text = "Service Cost must be a number.";
                return false;
            }

            string[] parts = txtServiceCost.Text.Split('.');

            if (parts.Length == 2 && parts[1].Length > 2)
            {
                txtStatus.Text = "Service Cost can only have two decimal places.";
                return false;
            }

            return true;
        }

        //6.11	Create a custom method to increment the service tag control,
        //this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private void IncrementServiceTag(int NewTag)
        {
            //to do
            //get new Tag
            //set next tag
            return;
        }

        //6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        private void CleanAddForm()
        {

        }
    }
}
