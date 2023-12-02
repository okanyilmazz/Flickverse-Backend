using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ExclusiveLoungeValidator : AbstractValidator<ExclusiveLounge>
    {
        public ExclusiveLoungeValidator()
        {
            RuleFor(e => e.Name).NotEmpty();
            RuleFor(e => e.Description).NotEmpty();
        }
    }
}
