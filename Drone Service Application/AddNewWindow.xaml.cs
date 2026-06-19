using System;
using System.Collections;
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
        private Queue<Drone> RegularService;
        private Queue<Drone> ExpressService;
        public int NextServiceTag;
        public AddNewWindow(Queue<Drone> regularService, Queue<Drone> expressService, int nextServiceTag)
        {
            InitializeComponent();

            RegularService = regularService;
            ExpressService = expressService;
            NextServiceTag = nextServiceTag;

            // auto create ServiceTag
            numServiceTag.Value = nextServiceTag;
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            AddNewItem();
        }
        //6.5 Create a button method called “AddNewItem” that will add a new service item to a Queue<> based on the priority.
        private void AddNewItem()
        {
            Drone newDrone = new Drone();

            // check if empty
            if (string.IsNullOrWhiteSpace(txtClientName.Text) || 
                string.IsNullOrWhiteSpace(txtDroneModel.Text) || 
                string.IsNullOrWhiteSpace(txtServiceProblem.Text) ||
                string.IsNullOrWhiteSpace(txtServiceCost.Text))
            {
                CommonControls.SetStatus("Input Error. Client Name, Drone Model, Service Problem or Service Cost should be filled.");
                return;
            }
            newDrone.SetClientName(txtClientName.Text);
            newDrone.SetDroneModel(txtDroneModel.Text);
            newDrone.SetServiceProblem(txtServiceProblem.Text);

            //6.7 GetServicePriority() must be called inside the “AddNewItem” method before the new service item is added to a queue.
            string priority = GetServicePriority();
            double serviceCost;
            string resultMsg;
            if (!ValidateServiceCost(out serviceCost, out resultMsg))
            {
                CommonControls.SetStatus(resultMsg);
                return;
            }

            //check if Service Tag error
            if (!numServiceTag.Value.HasValue) 
            {
                CommonControls.SetStatus("Service Tag error. Please return to the Main Menu and try again.");
                return;
            }
            int currentServiceTag = numServiceTag.Value.Value;
            if (currentServiceTag <100 || currentServiceTag > 900)
            {
                CommonControls.SetStatus("Service Tag error. Please return to the Main Menu and try again.");
                return;
            }
            
            newDrone.SetServiceTag(currentServiceTag);
            //6.11	IncrementServiceTag() must be called inside the “AddNewItem” method before the new service item is added to a queue.
            IncrementServiceTag(currentServiceTag);

            //6.5 The new service item will be added to the appropriate Queue based on the Priority radio button.
            if (priority == "Regular")
            {
                newDrone.SetServiceCost(serviceCost);
                RegularService.Enqueue(newDrone);
            } 
            else
            {
                //6.6 Before a new service item is added to the Express Queue the service cost must be increased by 15 %.
                newDrone.SetServiceCost(serviceCost * 1.15);
                ExpressService.Enqueue(newDrone);
            }
            CommonControls.SetStatus($"New service added to {priority} queue.");
            //6.17	clear all the textboxes after each service item has been added.
            ClearAddForm();

        }
        //6.7	Create a custom method called “GetServicePriority” which returns the value of the priority radio group.
        private string GetServicePriority()
        {
            if (rdoRegular.IsChecked == true)
                return "Regular";

            return "Express";
        }
        //6.10	Create a custom method to ensure the Service Cost textbox can only accept a double value with two decimal point.
        private bool ValidateServiceCost(out double serviceCost, out string resultMsg)
        {
            serviceCost = 0;
            if (string.IsNullOrWhiteSpace(txtServiceCost.Text))
            {
                resultMsg = "Service Cost is required.";
                return false;
            }
            if (!double.TryParse(txtServiceCost.Text, out serviceCost))
            {
                resultMsg="Service Cost must be a number.";
                return false;
            }
            //check if negative
            if (serviceCost<0)
            {
                resultMsg = "Service Cost must not be negative.";
                return false;
            }

            string[] parts = txtServiceCost.Text.Split('.');

            if (parts.Length == 2 && parts[1].Length > 2)
            {
                resultMsg = "Service Cost can only have two decimal places.";
                return false;
            }

            resultMsg = "Service Cost validation successful.";
            return true;
        }

        //6.11	Create a custom method to increment the service tag control,
        //this method must be called inside the “AddNewItem” method before the new service item is added to a queue.
        private void IncrementServiceTag(int currentTag)
        {
            NextServiceTag = currentTag + 10;
        }

        //6.17	Create a custom method that will clear all the textboxes after each service item has been added.
        private void ClearAddForm()
        {
            txtClientName.Clear();
            txtDroneModel.Clear();
            txtServiceProblem.Clear();
            txtServiceCost.Clear();
            numServiceTag.Value = NextServiceTag;
        }

    }
}
