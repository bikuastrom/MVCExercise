using System.ComponentModel.DataAnnotations;

namespace MVCExercise_Victoria.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
