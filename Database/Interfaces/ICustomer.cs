using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Interfaces       
{
    //interface
    public interface ICustomer
    {
        List<Customer> GetCustomers();

        Customer GetCustomerById(int id);

        Customer AddCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        Customer DeleteCustomer(int id);
        object DeleteCustomer(Customer customer);
    }
}
