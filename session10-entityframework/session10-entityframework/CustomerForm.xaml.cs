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

namespace session10_entityframework
{
    /// <summary>
    /// Interaction logic for CustomerForm.xaml
    /// </summary>
    public partial class CustomerForm : Window
    {
        ZzaEntities zzaEntities = new ZzaEntities();
        CustomerFormViewModel viewModel = new CustomerFormViewModel();

        public CustomerForm()
        {
            InitializeComponent();
            //Loaded += Window_Loaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var firstCustomer = zzaEntities.Customers.FirstOrDefault();
            viewModel.Customer = firstCustomer;

            var orderDates = zzaEntities.Orders
                .Where(o => o.CustomerId == firstCustomer.Id)
                .Select(order => order.OrderDate).ToList();
            viewModel.OrderDates = orderDates;

            DataContext = viewModel;
        }

        private void OrdersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime orderDate = (DateTime)OrdersList.SelectedItem;
            var selectedOrder = zzaEntities.Orders.Include("OrderItems").
                Where(o => o.OrderDate == orderDate
                && o.CustomerId == (Guid)CustomerIdLabel.Content).FirstOrDefault();

            viewModel.OrderItems = selectedOrder.OrderItems.ToList();
            DataContext = viewModel;
            OrderItemsDataGrid.GetBindingExpression(DataGrid.ItemsSourceProperty).UpdateTarget();
        }
    }
}
