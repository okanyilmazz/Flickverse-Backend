using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class MovieValidator : AbstractValidator<Movie>
    {
        public MovieValidator()
        {
            RuleFor(m => m.Name).NotEmpty();
            RuleFor(m => m.ProductionYear).NotEmpty();
            RuleFor(m => m.CountryId).NotEmpty();
            RuleFor(m => m.LanguageId).NotEmpty();
            RuleFor(m => m.Duration).NotEmpty();
            RuleFor(m => m.Description).NotEmpty();

            RuleFor(m => m.Name).MinimumLength(2);
            RuleFor(m=>m.Description).MinimumLength(5);
        }
    }
}
