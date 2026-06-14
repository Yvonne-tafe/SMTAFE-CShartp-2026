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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Drone_Service_Application
{
    /// <summary>
    /// Interaction logic for CommonControls.xaml
    /// </summary>
    public partial class CommonControls : UserControl
    {
        public CommonControls()
        {
            InitializeComponent();
        }
        public void SetStatus(string message)
        {
            txtStatus.Text = "Status: " +message;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Window.GetWindow(this)?.Close();
        }
        public void ShowExitButton(bool isVisible)
        {
            btnExit.Visibility = isVisible
                ? Visibility.Visible
                : Visibility.Collapsed;
        }
    }
}
