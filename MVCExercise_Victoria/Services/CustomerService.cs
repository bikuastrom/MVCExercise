using MVCExercise_Victoria.Data;
using MVCExercise_Victoria.Models;

namespace MVCExercise_Victoria.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly MVCExerciseDBContext _db;
        public CustomerService(MVCExerciseDBContext db)
        {
            _db = db;
        }

        public void CreateCustomer(Customer customer)
        {
            _db.Customers.Add(customer);
            _db.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = _db.Customers.OrderBy(c => c.FirstName).ToList();
            return customers;
        }
    }
}
