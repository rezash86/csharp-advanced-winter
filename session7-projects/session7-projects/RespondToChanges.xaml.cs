using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace session7_projects
{
    /// <summary>
    /// Interaction logic for RespondToChanges.xaml
    /// </summary>
    public partial class RespondToChanges : Window
    {
        //List<User> users = new List<User>();

        private ObservableCollection<User> users = new ObservableCollection<User>();

        public RespondToChanges()
        {
            InitializeComponent();

            users.Add(new User() { Name = "Brad Pitt" });
            users.Add(new User() { Name = "Angelina Jolie" });

            lbUser.ItemsSource = users;
        }

        private void btnAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User() { Name = "New User" });

            MessageBox.Show(users.Count.ToString());
        }

        private void btnchangeUser_Click(object sender, RoutedEventArgs e)
        {
            if(lbUser.SelectedItem != null)
            {
                (lbUser.SelectedItem as User).Name = "Any name";
            }
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (lbUser.SelectedItem != null)
            {
                users.Remove(lbUser.SelectedItem as User);
            }
        }
    }

    public class User: INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get { return this.name; }

            set
            {
                if(this.name != value)
                {
                    this.name = value;
                    //this.NotifyPropertyChanged("Name");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        //public void NotifyPropertyChanged(string propName)
        //{
        //    if(this.PropertyChanged != null)
        //    {
        //        this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
        //    }
        //}
    }
}
