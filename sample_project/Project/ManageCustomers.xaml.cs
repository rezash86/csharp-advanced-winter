using Project.ModelView;
using Project.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ManageCustomers : Window
    {

        public readonly static CustomerService cs = new CustomerService();
        public static MyModelView mv = new MyModelView();

        public ManageCustomers()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ManageCustomers.mv.Customers = cs.GetCustomers();
            ManageCustomers.mv.SelectedCustomer = new List<Customer>();
            DataContext = ManageCustomers.mv;
        }

        #region Main Menu
        private void MenuItem_1_Click(object sender, RoutedEventArgs e)
        {
            // current page, do nothing
        }

        

       
        #endregion
    }
}
