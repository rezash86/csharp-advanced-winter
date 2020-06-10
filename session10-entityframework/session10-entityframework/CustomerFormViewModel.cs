using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace session10_entityframework
{
    public class CustomerFormViewModel
    {
        public Customer Customer { get; set; }
        public List<OrderItem> OrderItems { get; set; }

        public List<DateTime> OrderDates { get; set; }
    }
}
