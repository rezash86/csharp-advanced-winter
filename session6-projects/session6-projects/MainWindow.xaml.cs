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

namespace session6_projects
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

        private void test_button_Click(object sender, RoutedEventArgs e)
        {
            ProcessBusinessLogic bl = 
                new ProcessBusinessLogic();
            //Register or subscribe to an event
            bl.processCompleted += bl_ProcessCompleted;
            bl.StartProcess();
        }

        private void bl_ProcessCompleted()
        {
            MessageBox.Show("Process finished");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("asdfas");
        }
    }
}
