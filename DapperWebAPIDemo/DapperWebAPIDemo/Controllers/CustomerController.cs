using DapperWebAPIDemo.DAL;
using DapperWebAPIDemo.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace DapperWebAPIDemo.Controllers
{
    public class CustomerController : ApiController
    {
        private CustomerRepository _ourCustomerRepository = new CustomerRepository();

        // GET: api/Customer
        [Route("Customers")]
        [HttpGet]
        public List<Customer> Get()
        {
            return _ourCustomerRepository.GetCustomers(10, "ASC");
        }

        [Route("Customers/{amount}/{sort}")]
        [HttpGet]
        public List<Customer> Get(int amount, string sort)
        {
            return _ourCustomerRepository.GetCustomers(amount, sort);
        }

        // GET: api/Customer/5
        [Route("Customers/{id}")]
        [HttpGet]
        public Customer Get(int id)
        {
            return _ourCustomerRepository.GetSingleCustomer(id);
        }

        // POST: api/Customer
        [Route("Customers")]
        [HttpPost]
        public bool Post([FromBody]Customer ourCustomer)
        {
            return _ourCustomerRepository.InsertCustomer(ourCustomer);
        }

        // PUT: api/Customer/5
        [Route("Customers")]
        [HttpPut]
        public bool Put([FromBody]Customer ourCustomer)
        {
            return _ourCustomerRepository.UpdateCustomer(ourCustomer);
        }

        // DELETE: api/Customer/5
        [Route("Customers/{id}")]
        [HttpDelete]
        public bool Delete(int id)
        {
            return _ourCustomerRepository.DeleteCustomer(id);
        }
    }
}
