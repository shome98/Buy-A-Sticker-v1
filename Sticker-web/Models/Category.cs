using System.ComponentModel.DataAnnotations;

namespace Sticker_web.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
    }
}
