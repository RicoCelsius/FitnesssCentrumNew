using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    internal class Owner : AccountBase
    {
        public Owner(string firstName, string lastName, string email, string adress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.adress = adress;
        }
    }
}
