using System.ComponentModel.DataAnnotations;

namespace asp_practice.Models
{
    public class Category
    {
        [Key] //DataNotations
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
    }
}
