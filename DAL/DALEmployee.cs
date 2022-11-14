using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;


namespace DAL
{
    internal class DALEmployee : IEmployee
    {

        public List<Customer> getCustomers()
        {
            List<Customer> customers = new List<Customer>();


            DataTable customersDataTable = dbconnection.Select("select * from `customer`");
            foreach(DataRow row in customersDataTable.Rows)
            {
                customers.Add(new Customer(row["first_name"].ToString(), row["last_name"].ToString(), row["email"].ToString(), row["address"].ToString(), row["password"].ToString()));
            }

            
            return customers; 
        }

        public void createCustomer()
        {
            
   
            
        }

        public void modifyCustomer(Customer target)
        {

        }


        public void deleteCustomer()
        {

        }
    }
}
