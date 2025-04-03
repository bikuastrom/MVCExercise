using MVCExercise_Victoria.Models;

namespace MVCExercise_Victoria.Services
{
    public interface ICustomerService
    {
        void CreateCustomer (Customer customer);
        List<Customer> GetCustomers();
    }
}
