using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.service
{
    public class CustomerService
    {
        AirlineEntities context = new AirlineEntities();

        public List<Customer> GetCustomers()
        {
            var query = from customer in context.Customers
                        select customer;
            return query.ToList<Customer>();
        }

        public Customer GetCustomerById(int cxId)
        {
            return context.Customers.Find(cxId);
        }

        public int AddCustomer(Customer cx)
        {
            try
            {
                context.Customers.Add(cx);
                context.SaveChanges();
                return cx.Id;
            }
            catch
            {
                return -1;
            }
        }

        public bool DeleteCustomer(int cxId)
        {
            // The DB uses Cascade to delete all children first
            try
            {
                Customer cx = GetCustomerById(cxId);
                context.Customers.Remove(cx);
                context.SaveChanges();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public bool UpdateCustomer(Customer cx)
        {
            try
            {
                Customer oldCustomer = GetCustomerById(cx.Id);
                oldCustomer.FirstName = cx.FirstName;
                oldCustomer.LastName = cx.LastName;
                oldCustomer.Gender = cx.Gender;
                oldCustomer.Phone = cx.Phone;
                oldCustomer.Email = cx.Email;
                context.SaveChanges();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public List<Customer> FindCustomer(Customer cx)
        {
            var customers = context.Customers.Where(c => true); // all customers

            if (cx.Id != 0)
            {
                customers = customers.Where(c => c.Id == cx.Id);
            }

            if (cx.FirstName != null)
            {
                customers = customers.Where(c => c.FirstName.Contains(cx.FirstName));
            }

            if (cx.LastName != null)
            {
                customers = customers.Where(c => c.LastName.Contains(cx.LastName));
            }

            if (cx.Gender != null)
            {
                customers = customers.Where(c => c.Gender == cx.Gender);
            }

            if (cx.Phone != null)
            {
                customers = customers.Where(c => c.Phone.Contains(cx.Phone));
            }

            if (cx.Email != null)
            {
                customers = customers.Where(c => c.Email.Contains(cx.Email));
            }

            return customers.ToList();
        }
    }
}
