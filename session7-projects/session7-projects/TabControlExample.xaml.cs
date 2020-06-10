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

namespace session7_projects
{
    /// <summary>
    /// Interaction logic for TabControlExample.xaml
    /// </summary>
    public partial class TabControlExample : Window
    {
        public TabControlExample()
        {
            InitializeComponent();
        }

        private void btnPrevious_Click(object sender, RoutedEventArgs e)
        {
            int index = tcSample.SelectedIndex - 1;
            if(index < 0)
            {
                index = tcSample.Items.Count - 1;
            }
            tcSample.SelectedIndex = index;
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            int index = tcSample.SelectedIndex + 1;
            if(index >= tcSample.Items.Count)
            {
                index = 0;
            }
            tcSample.SelectedIndex = index;
        }

        private void btnSelected_Click(object sender, RoutedEventArgs e)
        {
            var headerChosen = (tcSample.SelectedItem as TabItem).Header;
            MessageBox.Show($"you chose {headerChosen}");
        }
    }
}
