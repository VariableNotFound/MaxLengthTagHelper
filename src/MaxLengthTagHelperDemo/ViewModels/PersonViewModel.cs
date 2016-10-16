using System.ComponentModel.DataAnnotations;

namespace MaxLengthTagHelperDemo.ViewModels
{
    public class PersonViewModel
    {
        [Required, StringLength(25), Display(Name = "First name")]
        public string FirstName { get; set; }

        [Required, MaxLength(50), Display(Name = "Last name")]
        public string LastName { get; set; }

        [EmailAddress, MaxLength(200), Display(Name = "Email address")]
        public string Email { get; set; }
    }
}
