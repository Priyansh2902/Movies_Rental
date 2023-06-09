﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRentalV04.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if ( customer.MembershipTypeId == MembershipType.Unknown ||   customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;
            if (customer.MembershipTypeId == null)
                return new ValidationResult("Birthdate is Require.");
            var age = DateTime.Today.Year -  customer.Birthdate.Value.Year;
            return (age >= 18) ? ValidationResult.Success : new ValidationResult("Customer  should be at least 18 year old to go on a membership ");
        }
    }
}