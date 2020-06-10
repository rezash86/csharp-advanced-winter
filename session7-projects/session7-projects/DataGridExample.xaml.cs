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

namespace session7_projects
{
    /// <summary>
    /// Interaction logic for DataGridExample.xaml
    /// </summary>
    public partial class DataGridExample : Window
    {
        public DataGridExample()
        {
            InitializeComponent();

            List<Author> authors = new List<Author>();
            authors.Add(new Author() { Id = 1, FName = "AA",LName = "LLLL", Birthday = new DateTime(1971, 7, 23) });
            authors.Add(new Author() { Id = 2, FName = "BB", LName = "HGHHH", Birthday = new DateTime(1977, 8, 23) });
            authors.Add(new Author() { Id = 3, FName = "CC", LName = "KKKKKK", Birthday = new DateTime(1991, 10, 23) });

            dGAuthors.ItemsSource = authors;
        }
    }

    public class Author
    {
        public int Id { get; set; }
        public string FName { get; set; }

        public string LName { get; set; }
        public DateTime Birthday { get; set; }
    }
}
