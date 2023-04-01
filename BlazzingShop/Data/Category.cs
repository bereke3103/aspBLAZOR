using System.ComponentModel.DataAnnotations;

namespace BlazzingShop.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
