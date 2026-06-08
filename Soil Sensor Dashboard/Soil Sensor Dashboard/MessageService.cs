using System;
using System.Collections.Generic;
using System.Text;

namespace Soil_Sensor_Dashboard
{
    /// <summary>
    /// Provides common message dialog functions for the application.
    /// This class keeps user notifications separate from the main form logic.
    /// </summary>
    internal class MessageService
    {
        /// <summary>
        /// Initialises a new instance of the MessageService class.
        /// </summary>
        public MessageService()
        {
            //init if need
        }
        /// <summary>
        /// Displays a general action or success message to the user.
        /// </summary>
        /// <param name="message">The message content to display.</param>
        public void ShowAction(string message)
        {
            MessageBox.Show(message, "Action", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Displays an error message to the user.
        /// </summary>
        /// <param name="message">The error message content to display.</param>
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK);
        }
    }
}
