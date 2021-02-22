using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator:AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CustomerId).NotEmpty();
            RuleFor(c => c.UserId).NotNull();
            RuleFor(c => c.CompanyName).MaximumLength(50);
        }
    }
}
