using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace DataAnnotations
{
    public class Program
    {
        [Required]
        public string Name { get; set; }
        public DateTime EntryDate { get; set; }
        public string Password { get; set; }
        [Compare("Customer.Password", ErrorMessage = "The fields Password and PasswordConfirmation should be equals")]
        public string PasswordConfirmation { get; set; }

        [MaxLength(2, ErrorMessage = "The property {0} doesn't have more than {1} elements")]
        public int[] ArrayInt { get; set; }

        // Validates the email address
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        // Validates the primary email address
        [EmailAddress(ErrorMessage = "Invalid primary email address")]
        public string PrimaryEmail { get; set; }

        // Validates the secondary email address only if provided
        [EmailAddress(ErrorMessage = "Invalid secondary email address")]
        public string SecondaryEmail { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [StringLength(30)]
        [Display(Name = "Employee Name")]
        public string Name1 { get; set; }

        [Range(18, 65, ErrorMessage = "Age must be between 18 and 65")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email1 { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Password and Confirmation Password must match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Password1 { get; set; }

        [MaxLength(30)]
        [Display(Name = "Student's Full Name")]
        public string Name2 { get; set; }

        [Required]
        [MaxLength(20, ErrorMessage = "Username cannot exceed 20 characters")]
        [Display(Name = "User Handle")]
        [DataType(DataType.Text)]
        public string Username { get; set; }

    }

}
    

