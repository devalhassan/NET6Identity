using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace NET6Identity.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }

    public class RegisterListViewModel
    {
        public List<IdentityUser> Users { get; set; }
    }

    public class RegisterEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
