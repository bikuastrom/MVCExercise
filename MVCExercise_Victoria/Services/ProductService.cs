using MVCExercise_Victoria.Data;
using MVCExercise_Victoria.Models;

namespace MVCExercise_Victoria.Services
{
    public class ProductService : IProductService
    {
        private readonly MVCExerciseDBContext _db;
        public ProductService(MVCExerciseDBContext db)
        {
            _db = db;
        }
        public void CreateProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            List<Product> products = _db.Products.OrderBy(p => p.Name).ToList();
            return products;
        }
    }
}
