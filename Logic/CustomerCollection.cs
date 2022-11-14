using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class CustomerCollection
    {
        private List<ICustomer> customers = new List<ICustomer>();

        public List<ICustomer> GetCustomers()
        {
            List<ICustomer> customers = new List<ICustomer>();

            return customers;
        }
    }
}
