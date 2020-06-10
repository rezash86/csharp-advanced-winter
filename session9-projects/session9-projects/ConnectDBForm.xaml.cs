using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace session9_projects
{
    /// <summary>
    /// Interaction logic for ConnectDBForm.xaml
    /// </summary>
    public partial class ConnectDBForm : Window
    {
        public ConnectDBForm()
        {
            InitializeComponent();
            BindDataGrid();
        }

        public void BindDataGrid()
        {
            string Constring = ConfigurationManager.ConnectionStrings["zzDatabase"].ConnectionString;

            SqlConnection connection = new SqlConnection(Constring);

            //Select Query to fetch Data
            SqlDataAdapter da = new SqlDataAdapter("Select * from Customer", Constring);

            //we need a data container
            DataSet ds1 = new DataSet();
            //Fill Data inside ds => its a virtual database
            da.Fill(ds1, "CustomerTable");

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = ds1.Tables[0];

            grdCustomers.ItemsSource = bindingSource;
        }
    }
}
