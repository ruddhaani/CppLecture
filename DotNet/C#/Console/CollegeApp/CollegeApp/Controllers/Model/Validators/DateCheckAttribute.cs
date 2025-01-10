﻿using System.ComponentModel.DataAnnotations;

namespace CollegeApp.Controllers.Model.Validators
  
{
    public class DateCheckAttribute : ValidationAttribute 
    {
        protected override ValidationResult ? IsValid(object? value, ValidationContext ValidationContext)
        {
            var date = (DateTime?)value;
            if (date < DateTime.Now)
            {
                return new ValidationResult("The date must be greater than or equal to todays date");
            }
            return ValidationResult.Success;
        }

    }
}
