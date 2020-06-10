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
    /// Interaction logic for CustomerSearchBox.xaml
    /// </summary>
    public partial class CustomerSearchBox : UserControl
    {
        public readonly CustomerService cs = new CustomerService();

        public CustomerSearchBox()
        {
            InitializeComponent();
        }


        private void btnResetCustomerSearchForm_Click(object sender, RoutedEventArgs e)
        {
            txtId.Text = "";
            txtFname.Text = "";
            txtLName.Text = "";
            cmbGender.SelectedIndex = -1; // none selected
            txtPhone.Text = "";
            txtEmail.Text = "";
        }

        private void btnSearchCustomer_Click(object sender, RoutedEventArgs e)
        {
            // ID Integer Validation
            bool validate = Int32.TryParse(txtId.Text, out int customerId);
            if (!validate)
            {
                txtId.Text = "";
            }

            Customer searchCustomer = new Customer()
            {
                Id = (txtId.Text == "") ? 0 : customerId,
                FirstName = (txtFname.Text == "") ? null : txtFname.Text,
                LastName = (txtLName.Text == "") ? null : txtLName.Text,
                Gender = (cmbGender.SelectedIndex == 0) ? "M" : ((cmbGender.SelectedIndex == 1) ? "F" : null),
                Phone = (txtPhone.Text == "") ? null : txtPhone.Text,
                Email = (txtEmail.Text == "") ? null : txtEmail.Text
            };
            ManageCustomers.mv.Customers = cs.FindCustomer(searchCustomer);
            ManageCustomers.mv.SelectedCustomer = new List<Customer>();
        }

    }
}
