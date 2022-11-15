using Database.DBcontext;
using Database.Interfaces;
using Database.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class Custcontroller : ControllerBase
    {
        private readonly ICustomer _CustomerRepos;

        public Custcontroller(ICustomer customerRepos)
        {
            _CustomerRepos = customerRepos;
        }
        /// <summary>
        /// get list of all the customers
        /// </summary>
        /// <returns></returns>
        [HttpGet]

        public async Task<IActionResult> GetCustomers()
        {
            try
            {
                var customers = _CustomerRepos.GetCustomers();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
        /// <summary>
        /// Get Customers by id
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [HttpGet]

        public async Task<IActionResult> GetCustomerById(int Id)
        {
            try
            {
                var customer = _CustomerRepos.GetCustomerById(Id);
                return Ok(customer);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }

        /// <summary>
        /// Add customers 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]

        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            try
            {
                var addedCustomer = _CustomerRepos.AddCustomer(customer);
                return Ok(addedCustomer);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
        /// <summary>
        /// Update customers by id
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPut]

        public async Task<IActionResult> UpdateCustomer(Customer customer)
        {
            try
            {
                var UpdatedCustomer = _CustomerRepos.UpdateCustomer(customer);
                return Ok(UpdatedCustomer);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
        /// <summary>
        /// Delete Customers by id
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpDelete]

        public async Task<IActionResult> DeleteCustomer(Customer customer)
        {
            try
            {
                var deletedCustomer = _CustomerRepos.DeleteCustomer(customer);
                return Ok(deletedCustomer);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status417ExpectationFailed, ex.Message);
            }
        }
    }
}
