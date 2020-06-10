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

namespace Quiz1
{
    /// <summary>
    /// Interaction logic for Question4.xaml
    /// </summary>
    public partial class Question4 : Window
    {
        List<Student> studentList = new List<Student>();
        ObservableCollection<Student> stuList = new ObservableCollection<Student>();
        public Question4()
        {
            InitializeComponent();

            studentList.Add(new Student("1", "Susan"));
            studentList.Add(new Student("2", "Eric"));
            studentList.Add(new Student("3", "Simon"));
            studentList.Add(new Student("4", "Tom"));
            studentList.Add(new Student("5", "Philip"));
        }

        private void Click_btAdd(object sender, RoutedEventArgs e)
        {
            string id = txtID.Text;
           
            foreach (var student in stuList)
            {
                if(student.id.Equals(id))
                {
                    MessageBox.Show("This student is already in the list.");
                    return;
                }
            }
            
            foreach (var student1 in studentList)
            {
                if (student1.id.Equals(id))
                {

                    lbNames.Items.Add(student1.name);
                    stuList.Add(student1);
                    return;
                }   
            }
            MessageBox.Show("This student is not in the list.");

        }
    }

    public class Student
    {
        public string id { get; set; }
        public string name { get; set; }

        public Student(string id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }
}
