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
    /// Interaction logic for Task2SecondForm.xaml
    /// </summary>
    public partial class Task2SecondForm : Window
    {
        public string date_selected;
        public Task2SecondForm()
        {
            InitializeComponent();
        }

        //pass using constructor
        public Task2SecondForm(DateTime dateTime)
        {
            InitializeComponent();
            date_selected = dateTime.ToString();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtDate.Text = date_selected;
        }
    }
}
