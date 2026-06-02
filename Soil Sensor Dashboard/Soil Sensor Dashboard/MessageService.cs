using System;
using System.Collections.Generic;
using System.Text;

namespace Soil_Sensor_Dashboard
{
    internal class MessageService
    {
        public MessageService()
        {
            //init
        }
        public void ShowAction(string message)
        {
            MessageBox.Show(message, "Action", MessageBoxButtons.OK);
        }
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }
    }
}
