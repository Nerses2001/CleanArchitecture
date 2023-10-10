using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Models
{
    public class UserDto
    {
        
        [Required(ErrorMessage = "UserName is require")]
        [MaxLength(30)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Name is require")]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required(ErrorMessage = "LName is require")]
        [MaxLength(30)]
        public string LName { get; set; }

        [Required(ErrorMessage = "Email is require")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "PNumber is required")]
        [RegularExpression(@"\+374\d{9}", ErrorMessage = "Invalid phone number format. The phone number must start with +374 and be 12 characters long.")]
        public string PNumber { get; set; }

        public UserDto(string userName,string name, string lName, string email, string pNumber )
        {
            this.UserName = userName;
            this.Name = name;
            this.LName = lName;
            this.Email = email;
            this.PNumber = pNumber;
    
        }


    }
}
