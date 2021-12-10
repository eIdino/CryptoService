using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using CryptoService.Pages;

namespace CryptoService
{
    // Custom validation class
    public class CheckPairNameValidationAttribute : ValidationAttribute
    {
        // Custom validation function
        protected override ValidationResult IsValid(object value,
        ValidationContext validationContext)
        {
            // Converts value into a string
            string valueString = Convert.ToString(value);
            {
                // Checks if the length of the value is in between 5 and 12 and contains letters only
                if (valueString.Length > 5 && valueString.Length < 12 && valueString.All(char.IsLetter))
                {
                        return ValidationResult.Success;
                }
            }
            // if the value does not pass above, sends error message
            return new ValidationResult("Enter Valid Pair Name from the Pair List",
                new[] { validationContext.MemberName });
        }
    }
}
