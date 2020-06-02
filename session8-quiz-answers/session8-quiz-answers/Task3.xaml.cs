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
    /// Interaction logic for Task3.xaml
    /// </summary>
    public partial class Task3 : Window
    {
        public Task3()
        {
            InitializeComponent();
            tab2.Visibility = Visibility.Hidden;
        }

        private void chRevealTab_Checked(object sender, RoutedEventArgs e)
        {
            tab2.Visibility = Visibility.Visible;
        }

        private void chRevealTab_Unchecked(object sender, RoutedEventArgs e)
        {
            tab2.Visibility = Visibility.Hidden;
        }
    }
}
