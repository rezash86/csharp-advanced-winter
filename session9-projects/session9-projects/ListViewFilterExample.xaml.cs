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
    /// Interaction logic for ListViewFilterExample.xaml
    /// </summary>
    public partial class ListViewFilterExample : Window
    {
        public ListViewFilterExample()
        {
            InitializeComponent();
            List<User> items = new List<User>();

            items.Add(new User { Name = "TOTO", Age = 10, Mail = "toto@gmail.com" });
            items.Add(new User { Name = "POPO", Age = 20, Mail = "popo@gmail.com" });
            items.Add(new User { Name = "JOJO", Age = 30, Mail = "jojo@gmail.com" });

            lvUsers.ItemsSource = items;

            CollectionView view = (CollectionView)CollectionViewSource.
                GetDefaultView(lvUsers.ItemsSource);
            view.Filter = UserFilter;
        }

        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(txtFilter.Text))
            {
                return true;
            }
            else
            {
                return (item as User).Name.IndexOf(txtFilter.Text, 
                    StringComparison.OrdinalIgnoreCase) >= 0;

            }
        }

        private void txtFilter_TextChanged(object sender, TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(lvUsers.ItemsSource).Refresh();
        }
    }
}
