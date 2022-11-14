using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace DAL
{
    internal class DALCustomer : ICustomer
    {
        List<Customer> customers = new();
        public string getAmount()
        {


            DataTable value = dbconnection.Select("Select * from funds");
            
            return value.ToString();

        }

    }
}
