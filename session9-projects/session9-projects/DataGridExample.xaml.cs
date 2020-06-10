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
    /// Interaction logic for DataGridExample.xaml
    /// </summary>
    public partial class DataGridExample : Window
    {
        public DataGridExample()
        {
            InitializeComponent();

            List<Author> authors = new List<Author>();
            authors.Add(new Author { Id = 1, Name = "reza sh1", BirthDay = new DateTime(1970, 01, 01), Age = 11, Mail=  "A@gmail.com", HasSpouse= true });
            authors.Add(new Author { Id = 2, Name = "reza sh2", BirthDay = new DateTime(1970, 02, 11), Age = 12, Mail = "B@gmail.com", HasSpouse = true });
            authors.Add(new Author { Id = 3, Name = "reza sh3", BirthDay = new DateTime(1970, 03, 21), Age = 13, Mail = "C@gmail.com", HasSpouse = false });
            authors.Add(new Author { Id = 4, Name = "reza sh4", BirthDay = new DateTime(1970, 04, 02), Age = 14, Mail = "d@gmail.com", HasSpouse = true });
            authors.Add(new Author { Id = 5, Name = "reza sh5", BirthDay = new DateTime(1970, 05, 21), Age = 15, Mail = "e@gmail.com", HasSpouse = true });
            authors.Add(new Author { Id = 6, Name = "reza sh6", BirthDay = new DateTime(1970, 06, 23), Age = 16, Mail = "f@gmail.com", HasSpouse = false });
            authors.Add(new Author { Id = 7, Name = "reza sh7", BirthDay = new DateTime(1970, 07, 12), Age = 17, Mail = "g@gmail.com", HasSpouse = true });

            MyDataGrid.ItemsSource = authors;
        }
    }

    public class Author
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int Age { get; set; }
        public DateTime BirthDay { get; set; }

        public string Mail { get; set; }

        public bool HasSpouse { get; set; }
    }
}
