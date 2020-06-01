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

namespace session7_projects
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Windows Form style
            tempListBox.Items.Add("A");
            tempListBox.Items.Add(new TextBox());

            //tempListBox.DataContext = //pass a value

            //Data binding !
            //Assign/allcoate/give values to an object(container)
            //you pass this value into your wpf form
        }

        private void txt1_TextChanged(object sender, TextChangedEventArgs e)
        {
            //txt2.Text = txt1.te
        }
    }
}
