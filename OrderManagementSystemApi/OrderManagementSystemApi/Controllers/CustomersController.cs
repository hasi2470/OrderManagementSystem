using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderManagementSystemApi.Dal;
using OrderManagementSystemApi.Interfaces;
using OrderManagementSystemApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OrderManagementSystemApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomersController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }


        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            List<Customer> customers  = _customerRepository.GetAllCustomers();
            return customers;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
           var cust= _customerRepository.GetCustomer(id);
            return cust;
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post(Customer customer)
        {
            _customerRepository.AddCustomer(customer);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, Customer customer)
        {
            var cust = _customerRepository.GetCustomer(id);
            cust.Name = customer.Name;  
            cust.Address = customer.Address;
            cust.ContactNum = customer.ContactNum;
            cust.UserName = customer.UserName;  
            cust.Password = cust.Password;
            _customerRepository.UpdateCustomer(cust);
          
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cust = _customerRepository.GetCustomer(id);
            _customerRepository.DeleteCustomer(cust);   
        }
    }
}
