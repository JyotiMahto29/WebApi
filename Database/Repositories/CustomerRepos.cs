using Database.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.DBcontext;
using Database.Models;

namespace Database.Repositories
{
    public class CustomerRepos : ICustomer
    {
       private readonly Sqlserver _sqlserver;
        private Customer customer;

        public CustomerRepos(Sqlserver sqlserver)
       {
            _sqlserver = sqlserver;
       }
       public List<Customer> GetCustomers()              //method for getting list of customers
       {
            var lstCustomers = _sqlserver.Customer.ToList();
            return lstCustomers;
       }
        public Customer GetCustomerById(int id)          //method for getting list of customers by id
        {
            var customer = _sqlserver.Customer.FirstOrDefault(x => x.CustID == id);
            return customer; 
        }
        public Customer AddCustomer(Customer customer)    //method for adding  customers
        {
            _sqlserver.Customer.Add(customer);
            _sqlserver.SaveChanges();
            return customer;
        }
        public Customer UpdateCustomer(Customer customer)    //method for updating customers
        {
            _sqlserver.Customer.Update(customer);
            _sqlserver.SaveChanges();
            return customer;
        }

        public Customer DeleteCustomer(int id)         //method for deleting customers
        {
            _sqlserver.Customer.Remove(customer);
            _sqlserver.SaveChanges();
            return customer;
        }

        public object DeleteCustomer(Customer customer)
        {
            _sqlserver.Customer.Remove(customer);
            _sqlserver.SaveChanges();
            return customer;
            throw new NotImplementedException();
        }
    }
}
    
