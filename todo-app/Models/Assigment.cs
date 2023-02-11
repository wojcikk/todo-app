using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace todo_app.Models
{
    public class Assigment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public string Importance { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
