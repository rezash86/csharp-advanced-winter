using Project.service;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Project
{
    /// <summary>
    /// Interaction logic for CustomerAddBox.xaml
    /// </summary>
    public partial class CustomerAddBox : UserControl
    {

        public readonly CustomerService cs = new CustomerService();

        public CustomerAddBox()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            Customer cx = new Customer()
            {
                FirstName = txtFname.Text,
                LastName = txtLName.Text,
                Gender = (cmbGender.SelectedIndex == 0) ? "M" : ((cmbGender.SelectedIndex == 1) ? "F" : null),
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            };

            int result = cs.AddCustomer(cx);
            btnResetAddForm_Click(sender, null);

            if (result != -1) // Success
            {
                // Reload the Datagrid Data from DB
                ManageCustomers.mv.Customers = cs.GetCustomers();
                // Atempt to Reload the Datagrid without a trip to DB (did not work):
                // cx.Id = result;
                // BookFlights.mv.Customers.Add(cx);
                MessageBox.Show($"Customer created with ID: {result.ToString()}",
                    "Success",
                    MessageBoxButton.OK,
                    MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show($"Something went wrong.",
                    "Error",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void btnResetAddForm_Click(object sender, RoutedEventArgs e)
        {
            txtFname.Text = "";
            txtLName.Text = "";
            cmbGender.SelectedIndex = -1; // none selected
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

    }
}
