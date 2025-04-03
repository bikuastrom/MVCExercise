using Microsoft.EntityFrameworkCore;
using MVCExercise_Victoria.Models;

namespace MVCExercise_Victoria.Data
{
    public class MVCExerciseDBContext : DbContext
    {
        public MVCExerciseDBContext()
        {

        }

        public MVCExerciseDBContext(DbContextOptions<MVCExerciseDBContext> options) :base(options)
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
    }
}
