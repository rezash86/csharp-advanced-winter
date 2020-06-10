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
    /// Interaction logic for ListviewWithGridView.xaml
    /// </summary>
    public partial class ListviewWithGridView : Window
    {
        public ListviewWithGridView()
        {
            InitializeComponent();

            List<User> items = new List<User>();

            items.Add(new User { Name = "TOTO", Age = 10, Mail = "toto@gmail.com" });
            items.Add(new User { Name = "POPO", Age = 20, Mail = "popo@gmail.com" });
            items.Add(new User { Name = "JOJO", Age = 30, Mail = "jojo@gmail.com" });

            lvUsers.ItemsSource = items;
        }
    }
}
