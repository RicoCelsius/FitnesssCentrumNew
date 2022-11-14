namespace Logic
{
    public interface IEmployee
    {
        List<Customer> getCustomers();
        void createCustomer();
        void deleteCustomer();
        void modifyCustomer(Customer target);
    }
}