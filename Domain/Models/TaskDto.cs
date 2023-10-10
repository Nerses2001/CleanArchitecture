using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Models
{
    public class TaskDto
    {
        public int Id { get; private set; }

        [Required(ErrorMessage = "Name is require")]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is require")]
        [MaxLength(1000)]
        public string Description { get; set; }
        [Required(ErrorMessage = "Task due date is required.")]
        [DataType(DataType.Date)]
        public DateTime DueDate  { get; set;}

        [Required(ErrorMessage = "Task status is required.")]
        public TaskStatus Status { get; set; }
        
        public TaskDto(string name, string description, DateTime dateTime, TaskStatus taskStatus = TaskStatus.NotStarted)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = dateTime;
            this.Status = taskStatus;
        }
    }
}
