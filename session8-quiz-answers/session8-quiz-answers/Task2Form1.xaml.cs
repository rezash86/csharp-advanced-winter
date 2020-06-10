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
    /// Interaction logic for Task1Form1.xaml
    /// </summary>
    public partial class Task1Form1 : Window
    {
        public Task1Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            DateTime selectedDay = (DateTime)myCalendar.SelectedDate;
            Task2SecondForm window = new Task2SecondForm(selectedDay);
            window.Show();
        }
    }
}
