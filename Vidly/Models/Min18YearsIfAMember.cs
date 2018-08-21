﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return  ValidationResult.Success;
            if (customer.Birthdate == null)
                return  new ValidationResult("Birthdate is required");
            var age = DateTime.Today.Year - customer.Birthdate.Value.Year;
            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should at least be 18 year old to be a Member.");

        }

    }
}