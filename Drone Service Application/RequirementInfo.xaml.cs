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
    /// RequirementInfo is responsible for displaying the Client Name and Service Problem in the related textboxes.
    /// It shows the Client Name and Service Problem of the selected queue item in a listView in DisplayQueueWindow.
    /// </summary>
    public partial class RequirementInfo : Window
    {
        public RequirementInfo(string clientName, string serviceProblem)
        {
            InitializeComponent();

            txtClientName.Text = clientName;
            txtServiceProblem.Text = serviceProblem;
        }
    }
}
