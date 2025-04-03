using System.ComponentModel.DataAnnotations;

namespace MVCExercise_Victoria.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
