using MVCExercise_Victoria.Models;

namespace MVCExercise_Victoria.Services
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        List<Product> GetProducts();
    }
}
