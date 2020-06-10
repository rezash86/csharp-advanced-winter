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
    /// Interaction logic for DataGridCustomerList.xaml
    /// </summary>
    public partial class DataGridCustomerList : UserControl
    {

        public DataGridCustomerList()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            ManageCustomers.mv.PropertyChanged += UpdateUI;
        }

        public void UpdateUI(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SelectedCustomer":
                    if (ManageCustomers.mv.SelectedCustomer.Count == 0) // it was set programatically
                    {
                        dgdCustomerList.SelectedIndex = -1; // select none
                    }
                    break;

                case "Customers": // used in ManagedCustomers Page when updating a user
                    CollectionViewSource.GetDefaultView(dgdCustomerList.ItemsSource).Refresh();
                    break;
            }
        }

        private void dgdCustomerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dgdCustomerList.SelectedIndex != -1) // -1 means none selected programatically
            {
                int selectedId = ((Customer)dgdCustomerList.SelectedItem).Id;
                ManageCustomers.mv.SelectedCustomer = new List<Customer> { ManageCustomers.mv.Customers.Where(c => c.Id == selectedId).FirstOrDefault() };
            }
        }
    }
}
