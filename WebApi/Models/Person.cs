using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Person
    {
        public int Id { get; set; }

        [Required]
        public  string Name { get; set; }
        public string Age { get; set; }
    }
}
