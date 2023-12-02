using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class DirectorValidator : AbstractValidator<Director>
    {
        public DirectorValidator()
        {
            RuleFor(d => d.FirstName).NotEmpty();
            RuleFor(d => d.LastName).NotEmpty();
            RuleFor(d => d.DateOfBirth).NotEmpty();
            RuleFor(d => d.Biography).NotEmpty();
            RuleFor(d => d.CountryId).NotEmpty();

            RuleFor(d => d.FirstName).MaximumLength(50);
            RuleFor(d => d.LastName).MaximumLength(50);
        }
    }
}
