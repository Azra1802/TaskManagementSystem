using System.ComponentModel.DataAnnotations;

namespace TaskManagmentSystem.Models
{
    public class TaskCreateVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        public TaskStatus Status { get; set; } = TaskStatus.ToDo;
        public TaskPriority Priority { get; set; } = TaskPriority.Low;
        public DateTime DueDate { get; set; }
    }
}
