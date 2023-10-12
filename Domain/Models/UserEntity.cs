using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Models
{
    public class UserEntity
    {

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string PNumber { get; set; }
        public virtual ICollection<TaskEntity>? Tasks { get; set; }

        public UserEntity(string userName, string name, string lName, string email, string pNumber)
        {
            UserName = userName;
            Name = name;
            LName = lName;
            Email = email;
            PNumber = pNumber;
        }

    }
}
