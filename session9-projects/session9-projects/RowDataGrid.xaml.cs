using session9_projects.model;
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

namespace session9_projects
{
    /// <summary>
    /// Interaction logic for RowDataGrid.xaml
    /// </summary>
    public partial class RowDataGrid : Window
    {
        public RowDataGrid()
        {
            InitializeComponent();
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee()
            {
                Id = 1,
                Name = "Brad pitt",
                Birthday = new DateTime(1971, 7, 23),
                ImageUrl = "/images/simpson.jpeg"
            });

            employees.Add(new Employee()
            {
                Id = 2,
                Name = "Johny Depp",
                Birthday = new DateTime(1961, 10, 23),
                ImageUrl = "/images/depp.jpg"
            });

            employees.Add(new Employee()
            {
                Id = 3,
                Name = "ronaldo",
                Birthday = new DateTime(1981, 10, 23)            
            });

            dgUser.ItemsSource = employees;

        }
    }
}
