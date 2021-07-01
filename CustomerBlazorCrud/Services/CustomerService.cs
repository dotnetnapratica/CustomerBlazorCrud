using Blazored.LocalStorage;
using CustomerBlazorCrud.Models;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace CustomerBlazorCrud.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ILocalStorageService localStorageService;
        public CustomerService(ILocalStorageService localStorageService)
        {
            this.localStorageService = localStorageService;
        }

        private string customersLocalStorageKey = "customersKey";

        public async Task<List<Customer>> GetCustomers()
        {
            var customersJson = await localStorageService.GetItemAsync<string>(customersLocalStorageKey);
            if (string.IsNullOrEmpty(customersJson))
                return new List<Customer>();

            return JsonSerializer.Deserialize<List<Customer>>(customersJson);
        }

        public async Task SaveCustomers(List<Customer> customers)
        {
            var customersJson = JsonSerializer.Serialize(customers);
            await localStorageService.SetItemAsync(customersLocalStorageKey, customersJson);
        }
    }
}
