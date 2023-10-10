
namespace CleanArchitecture.Domain.Models
{
    public class TaskEntity
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskStatus Status { get; set; }
        public int UserId { get; set; }
        public virtual UserEntity? User { get; set; }

        public TaskEntity(string name, string description, DateTime dueDate, TaskStatus status)
        {
            this.Name = name;
            this.Description = description;
            this.DueDate = dueDate;
            this.Status = status;
        }
    }
}
