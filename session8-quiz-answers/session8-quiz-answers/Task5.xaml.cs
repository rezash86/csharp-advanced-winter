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
    /// Interaction logic for Task5.xaml
    /// </summary>
    public partial class Task5 : Window
    {
        int clicks = 0;
        public Task5()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            clicks++;
            if(clicks % 2 == 0)
            {
                tvEven.Items.Add(new TreeViewItem() { Header = clicks });
                btnClick.Background = Brushes.Blue;
            }
            else
            {
                tvOdd.Items.Add(new TreeViewItem() { Header = clicks });
                btnClick.Background = Brushes.Red;
                btnClick.Foreground = Brushes.White;
            }
        }
    }
}
