using OrderManagementSystemApi.Models;

namespace OrderManagementSystemApi.Interfaces
{
    public interface ICustomerRepository
    {
        public List<Customer> GetAllCustomers();
        public Customer GetCustomer(int id);
        public void AddCustomer(Customer customer);
        public void UpdateCustomer(Customer customer);
        public void DeleteCustomer(Customer customer);



    }
}
