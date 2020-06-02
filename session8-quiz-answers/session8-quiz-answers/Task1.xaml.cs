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

namespace session8_quiz_answers
{
    /// <summary>
    /// Interaction logic for Task1.xaml
    /// </summary>
    public partial class Task1 : Window
    {
        public Task1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, RoutedEventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Text = "";
            txtPhoneNumber.Clear();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            
            //you can take the others
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtPhoneNumber.Text != "")
            {
                string firstName = txtFirstName.Text;
                MessageBox.Show($"first name : {firstName} and last name:{txtLastName.Text} " +
                    $"and phone number : {txtPhoneNumber.Text}");
            }
            else
            {
                MessageBox.Show("Please enter correctly", "Incomplete entry", MessageBoxButton.OK,
                    MessageBoxImage.Warning);
            }
        }
    }
}
