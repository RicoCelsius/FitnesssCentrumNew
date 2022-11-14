
namespace Logic
{

    internal class Employee : AccountBase, IEmployee
    {

        //Create roept void van de logic aan, (create user). De logic laag naar de interface, de interface roept de DAL laag aan.

        public Employee(string firstName, string lastName, string email, string adress)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.adress = adress;
        }

        public List<Customer> getCustomers()
        {
            List<Customer> s = new List<Customer>();
            return s;
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