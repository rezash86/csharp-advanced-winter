using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace session5_projects
{
    /// <summary>
    /// Interaction logic for ToggleButtonExample.xaml
    /// </summary>
    public partial class ToggleButtonExample : Window
    {
        public ToggleButtonExample()
        {
            InitializeComponent();
            Background = Brushes.LightGreen;
        }

        private void tglButton_Checked(object sender, RoutedEventArgs e)
        {
            lblTest.Content = "It is enabled";
            Background = Brushes.MistyRose;
            //MessageBox.Show(tglButton.IsChecked.ToString());
        }

        private void tglButton_Unchecked(object sender, RoutedEventArgs e)
        {
            lblTest.Content = "It is disabled";
            Background = Brushes.LightCoral;
            //MessageBox.Show(tglButton.IsChecked.ToString());
        }

        private void tglButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tglButton.IsChecked.ToString());
        }
    }
}
