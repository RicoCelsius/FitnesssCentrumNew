using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic.Enums;

namespace Logic
{
    public class Customer : AccountBase
    {

        double funds = 0;
        int id;

        AccountBase account { get; set; }
        Subscription Subscription { get; set; }



        public Customer(string firstName, string lastName, string email, string adress, string password)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.adress = adress;
            this.password = password;

        }

        

        private void pay(Invoice invoice)
        {
      
        }
    }


}
