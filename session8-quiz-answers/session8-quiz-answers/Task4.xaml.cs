using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Task4.xaml
    /// </summary>
    public partial class Task4 : Window
    {
        public ObservableCollection<Student> studentsList = new ObservableCollection<Student>();
        public Task4()
        {
            InitializeComponent();

            studentsList.Add(new Student { Id = 1, Name = "A" });
            studentsList.Add(new Student { Id = 2, Name = "B" });
            studentsList.Add(new Student { Id = 3, Name = "C" });
            studentsList.Add(new Student { Id = 4, Name = "D" });
            studentsList.Add(new Student { Id = 5, Name = "E" });

            lstStudents.ItemsSource = studentsList;
        }

        private void btnAddStudent_Click(object sender, RoutedEventArgs e)
        {
            int studentId = Convert.ToInt32(txtId.Text);

            if (checkValid(studentId))
            {
                string name = getName(studentId);
                if (!lstStudents.Items.Contains(name))
                {
                    lstStudents.Items.Add(name);
                }
                else
                {
                    MessageBox.Show("student is already in the listbox");
                }
                lstStudents.Items.Add(name);
            }
            else
            {
                MessageBox.Show("student is not in the list");
            }
        }

        public bool checkValid(int studentId)
        {
            foreach (var item in studentsList)
            {
                int stdId = item.Id;
                if (studentId == stdId)
                {
                    return true;
                }
            }
            return false;
        }

        public string getName(int studentId)
        {
            foreach (var item in studentsList)
            {
                int stdId = item.Id;
                if (studentId == stdId)
                {
                    return item.Name;
                }
            }
            return "";
        }
    }
}
