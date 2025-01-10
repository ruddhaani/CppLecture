using System.ComponentModel.DataAnnotations;
using CollegeApp.Controllers.Model.Validators;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CollegeApp.Controllers.Model
{
    public class StudentDTO
    {
        [ValidateNever]
        public int Id { get; set; }

        [Required (ErrorMessage="Student Name is Required")]
        [StringLength(50)]
        public string StudentName { get; set; }

        [Required,EmailAddress (ErrorMessage ="Please Enter valid Email Address")]
        public string Email { get; set; }

        [Required ]
        public string Address { get; set; }

        [Range(10,20)]
        public int Age { get; set; }

        public string Password { get; set; }
        [Compare (nameof(Password))]
        public string ConfirmPassword {  get; set; }

        [DateCheck]
        public DateTime AdmissionDate { get; set; } 

    }
}
