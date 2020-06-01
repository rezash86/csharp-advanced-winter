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
    /// Interaction logic for DatePickerExample.xaml
    /// </summary>
    public partial class DatePickerExample : Window
    {
        public DatePickerExample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            DateTime birthDate = dtPickerSample.SelectedDate.Value;
            var gender = (cmbGender.SelectedItem as ComboBoxItem).Content;

            //Pass these values into a method
            MessageBox.Show($"{name} was born in {birthDate} and => {gender}");
        }
    }
}
