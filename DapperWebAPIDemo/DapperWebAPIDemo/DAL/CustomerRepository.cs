using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Dapper;
using DapperWebAPIDemo.Models;


namespace DapperWebAPIDemo.DAL
{    
    public class CustomerRepository : ICustomerRepository
    {
        private IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        public List<Customer> GetCustomers(int amount, string sort)
        {
            throw new NotImplementedException();
        }

        public Customer GetSingleCustomer(int customerId)
        {
            return connection.Query<Customer>("SELECT[CustomerID],[CustomerFirstName],[CustomerLastName],[IsActive]" +
                                            " FROM [Customer] WHERE CustomerID =@CustomerID", new { CustomerID = customerId }).SingleOrDefault();
        }

        public bool InsertCustomer(Customer ourCustomer)
        {
            int rowsAffected = this.connection.Execute(@"INSERT Customer([CustomerFirstName],[CustomerLastName],[IsActive]) values (@CustomerFirstName, @CustomerLastName,@IsActive)",
                                                        new { CustomerFirstName = ourCustomer.CustomerFirstName, CustomerLastName = ourCustomer.CustomerLastName, IsActive = true });

            if (rowsAffected > 0)
            {
                return true;
            }

            return false;
        }

        public bool DeleteCustomer(int customerId)
        {
            throw new NotImplementedException();
        }

        public bool UpdateCustomer(Customer ourCustomer)
        {
            throw new NotImplementedException();
        }
    }
}