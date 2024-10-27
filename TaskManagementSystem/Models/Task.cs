using System.ComponentModel.DataAnnotations;


namespace TaskManagementSystem.Models
{
    public class Task
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string Details { get; set; }

        
        
    }
}
