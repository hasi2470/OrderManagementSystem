using OrderManagementSystemApi.Interfaces;
using OrderManagementSystemApi.Models;

namespace OrderManagementSystemApi.Dal.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly OrderManagementDbContext _context;

        public CustomerRepository(OrderManagementDbContext context)
        {
            _context = context;
        }

        public List<Customer> GetAllCustomers()
        {
           List<Customer>  listCustomers = _context.Customers.ToList();
           return listCustomers;
        }
        public Customer GetCustomer(int id)
        {
            var cus = _context.Customers.Find(id);
            return cus;
        }
        public void AddCustomer(Customer customer)
        {
             _context.Customers.Add(customer);
            _context.SaveChanges();
         
        }
        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }
        public void DeleteCustomer(Customer customer)
        {
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }
    }
}
