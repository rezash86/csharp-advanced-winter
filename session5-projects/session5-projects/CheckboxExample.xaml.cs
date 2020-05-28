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
    /// Interaction logic for CheckboxExample.xaml
    /// </summary>
    public partial class CheckboxExample : Window
    {
        public CheckboxExample()
        {
            InitializeComponent();
        }

        private void chChoc_Checked(object sender, RoutedEventArgs e)
        {
            HandleChocolate(sender as CheckBox);
        }

        private void chChoc_Unchecked(object sender, RoutedEventArgs e)
        {
            HandleChocolate(sender as CheckBox);
        }

        private void chSugar_Checked(object sender, RoutedEventArgs e)
        {
            HandleSugar(sender as CheckBox);
        }

        private void chSugar_Unchecked(object sender, RoutedEventArgs e)
        {
            HandleSugar(sender as CheckBox);
            HandleElement(sender as System.Windows.Controls.Primitives.ButtonBase);
        }

        void HandleChocolate(CheckBox checkBox)
        {
            bool flag = checkBox.IsChecked.Value;
            if (flag)
            {
                label1.Content = "Extra chocolate is selected";
            }
            else
            {
                label1.Content = "";
            }
            
        }


        void HandleElement(System.Windows.Controls.Primitives.ButtonBase baseButton)
        {
            
            MessageBox.Show(baseButton.Content + " is clicked");
        }

        void HandleSugar(CheckBox checkBox)
        {
            bool flag = checkBox.IsChecked.Value;
            if (flag)
            {
                label2.Content = "no Sugar is selected";
            }
            else
            {
                label2.Content = "";
            }
            
        }

        private void chChoc_Click(object sender, RoutedEventArgs e)
        {
            HandleChocolate(sender as CheckBox);
        }
    }
}
