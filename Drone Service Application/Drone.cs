using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Drone_Service_Application
{
    /// <summary>
    /// 6.1 Create a separate class file to hold the data items of the Drone.
    /// Use separate getter and setter methods, ensure the attributes are private and the accessor methods are public. 
    /// Save the class as “Drone.cs”
    /// </summary>
    class Drone
    {
        private string clientName;
        private string droneModel;
        private string serviceProblem;
        private double serviceCost;
        private int serviceTag;

        public string GetClientName() { return clientName; }
        //6.1 Add suitable code to the Client Name accessor methods so the data is formatted as Title case
        public void SetClientName(string value)
        {
            clientName = CultureInfo.CurrentCulture.TextInfo
                .ToTitleCase(value.Trim().ToLower());
        }

        public string GetDroneModel() { return droneModel; }
        public void SetDroneModel(string value) { droneModel = value; }

        public string GetServiceProblem() { return serviceProblem; }
        //6.1 Add suitable code to Service Problem accessor methods so the data is formatted as Sentence case
        public void SetServiceProblem(string value)
        {
            if (!string.IsNullOrWhiteSpace(value))
            {
                value = value.Trim();

                serviceProblem =
                    char.ToUpper(value[0]) +
                    value.Substring(1).ToLower();
            }
        }

        public double GetServiceCost() { return serviceCost; }
        public void SetServiceCost(double value) { serviceCost = value; }

        public int GetServiceTag() { return serviceTag; }
        public void SetServiceTag(int value) { serviceTag = value; }
        //6.1 Add a display method that returns a string for Client Name and Service Cost. 
        public string Display()
        {
            return clientName + " - $" + serviceCost.ToString("F2");
        }
    }
        
}
