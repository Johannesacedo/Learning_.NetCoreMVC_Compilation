using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ValidationsDemo.Models;

namespace ValidationsDemo.Validations
{
    public class CityPostalCodeAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            UserDetails ud = value as UserDetails;
            if(ud.City.ToLower() == "hyderabad" && ud.PostalCode > 500)
            {
                return new ValidationResult("Invalid PostalCode for Hyderabad City.");
            }

            return ValidationResult.Success;
        }
    }
}
