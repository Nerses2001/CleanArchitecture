using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Models
{
    public class TaskDto
    {
        public int Id { get; private set; }

        [Required(ErrorMessage = "The 'Name' field is required.")]
        [MaxLength(100, ErrorMessage = "The 'Name' field must be at most 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The 'Description' field is required.")]
        [MaxLength(1000, ErrorMessage = "The 'Description' field must be at most 1000 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The 'DueDate' field is required.")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date format for 'DueDate' field.")]
        public DateTime DueDate  { get; set;}

        [Required(ErrorMessage = "The 'Status' field is required.")]
        public TaskStatus Status { get; set; }
        
        
        public TaskDto(string name, string description, DateTime dueDate, TaskStatus status)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = dueDate;
            this.Status = status;
        }
        public static TaskDto FromTaskEntity(TaskEntity taskEntity)
        {
            return new TaskDto
            (
                taskEntity.Name,
                taskEntity.Description,
                taskEntity.DueDate,
                taskEntity.Status
            )
            {
                Id = taskEntity.Id,
            };
        }
    }
}
