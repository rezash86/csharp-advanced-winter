using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.ModelView
{
    public class MyModelView : INotifyPropertyChanged
    {
        private List<Customer> customers;
        public List<Customer> Customers
        {
            get { return customers; }
            set
            {
                customers = value;
                OnPropertyChanged("Customers");
            }
        }


        private List<Customer> selectedCustomer; // Must be List to be used in data grid
        public List<Customer> SelectedCustomer
        {
            get { return selectedCustomer; }
            set
            {
                selectedCustomer = value;
                OnPropertyChanged("SelectedCustomer");
            }
        }

       


        public void UpdateCustomerInList(Customer cx)
        {
            Customer customerToBeUpdated = Customers.Where(c => c.Id == cx.Id).FirstOrDefault();
            customerToBeUpdated.FirstName = cx.FirstName;
            customerToBeUpdated.LastName = cx.LastName;
            customerToBeUpdated.Gender = cx.Gender;
            customerToBeUpdated.Phone = cx.Phone;
            customerToBeUpdated.Email = cx.Email;
            OnPropertyChanged("Customers");
        }


        public void OnPropertyChanged(string changedProprtyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(changedProprtyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
