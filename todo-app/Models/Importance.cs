using System.ComponentModel.DataAnnotations;

namespace todo_app.Models
{
    public class Importance
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
