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
    /// Interaction logic for GridExample2.xaml
    /// </summary>
    public partial class GridExample2 : Window
    {
        public GridExample2()
        {
            InitializeComponent();
        }
      

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"fist name = {txtFirstName.Text} and lastname = {txtLastName.Text}");
        }
    }
}
