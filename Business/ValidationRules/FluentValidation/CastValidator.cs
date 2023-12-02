using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CastValidator : AbstractValidator<Cast>
    {
        public CastValidator()
        {
            RuleFor(c => c.FirstName).NotEmpty();
            RuleFor(c => c.LastName).NotEmpty();
            RuleFor(c => c.DateOfBirth).NotEmpty();
            RuleFor(c => c.Biography).NotEmpty();
            RuleFor(c => c.CountryId).NotEmpty();

            RuleFor(d => d.FirstName).MaximumLength(50);
            RuleFor(d => d.LastName).MaximumLength(50);

        }
    }
}
