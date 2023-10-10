using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Models
{
    public class UserEntity
    {

        public int Id { get;}
        public string UserName { get; set; }

        public string Name { get; set; }

        public string LName { get; set; }

        public string Email { get; set; }
        public string PNumber { get; set; }
        public virtual ICollection<TaskEntity>? Tasks { get; set; }

        public UserEntity(string userName, string name, string lName, string email, string pNumber)
        {
            this.UserName = userName;
            this.Name = name;
            this.LName = lName;
            this.Email = email;
            this.PNumber = pNumber;

           

        }

    }
}
