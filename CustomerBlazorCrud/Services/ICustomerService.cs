using CustomerBlazorCrud.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomerBlazorCrud.Services
{
    public interface ICustomerService
    {
        Task<List<Customer>> GetCustomers();

        Task SaveCustomers(List<Customer> customers);
    }
}
