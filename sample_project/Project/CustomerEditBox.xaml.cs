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
    /// Interaction logic for CustomerEditBox.xaml
    /// </summary>
    public partial class CustomerEditBox : UserControl
    {

        public readonly static CustomerService cs = new CustomerService();

        public CustomerEditBox()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (ManageCustomers.mv.SelectedCustomer.Count == 0) return; // no rows selected

            // Confirmation Message
            MessageBoxResult messageBoxResult = MessageBox.Show($"Deleting user ID: {txtId.Text}\nAre you sure?",
                                                                "Confirm Delete",
                                                                MessageBoxButton.YesNo,
                                                                MessageBoxImage.Warning);
            // Deletion
            if (messageBoxResult == MessageBoxResult.Yes)
            {
                bool result = cs.DeleteCustomer(ManageCustomers.mv.SelectedCustomer[0].Id);

                if (result) // Success
                {
                    // Refresh the Data Grid Data without a trip to the DB
                    ManageCustomers.mv.Customers = ManageCustomers.mv.Customers.Where(c => c.Id != ManageCustomers.mv.SelectedCustomer[0].Id).ToList();
                    ManageCustomers.mv.SelectedCustomer = new List<Customer>();

                    MessageBox.Show("Customer Successfully Deleted.",
                                    "Deleted",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Something went wrong.",
                                    "Error",
                                    MessageBoxButton.OK,
                                    MessageBoxImage.Error);
                }
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "") return; // no rows selected
            Customer cx = new Customer()
            {
                Id = Int32.Parse(txtId.Text),
                FirstName = txtFName.Text,
                LastName = txtLName.Text,
                Gender = (cmbGender.SelectedIndex == 0) ? "M" : ((cmbGender.SelectedIndex == 1) ? "F" : null),
                Phone = txtPhone.Text,
                Email = txtEmail.Text
            };
            bool result = cs.UpdateCustomer(cx);
            if (result) // Success Message
            {

                // Update ModelView to Reload the Data Grid without a trip to the DB:
                ManageCustomers.mv.UpdateCustomerInList(cx);

                MessageBox.Show("Customer Successfully Updated.",
                                "Success",
                                MessageBoxButton.OK,
                                MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong.",
                                "Error", MessageBoxButton.OK,
                                MessageBoxImage.Error);
            }
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFName.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
            txtLName.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
            cmbGender.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateTarget();
            txtPhone.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
            txtEmail.GetBindingExpression(TextBox.TextProperty).UpdateTarget();
        }


    }
}
