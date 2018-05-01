using DapperWebAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperWebAPIDemo.DAL
{
    interface ICustomerRepository
    {
        List<Customer> GetCustomers(int amount, string sort);

        Customer GetSingleCustomer(int customerId);

        bool InsertCustomer(Customer ourCustomer);

        bool DeleteCustomer(int customerId);

        bool UpdateCustomer(Customer ourCustomer);

    }
}
