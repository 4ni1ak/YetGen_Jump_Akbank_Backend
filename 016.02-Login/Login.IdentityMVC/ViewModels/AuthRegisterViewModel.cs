using System.ComponentModel.DataAnnotations;
using Login.Domain.Enums;

namespace Login.IdentityMVC.ViewModels
{
    public class AuthRegisterViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(3)]
        public string UserName { get; set; }
         
        [Required]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SurName { get; set; }
        public DateTimeOffset? BirthDate { get; set; }
        [Required]
        public Gender Gender { get; set; }


    }
}
