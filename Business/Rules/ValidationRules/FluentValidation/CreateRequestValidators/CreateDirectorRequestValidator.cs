﻿using Business.Dtos.Requests.CreateRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;

public class CreateDirectorRequestValidator : AbstractValidator<CreateDirectorRequest>
{
    public CreateDirectorRequestValidator()
    {
        RuleFor(d => d.FirstName).MinimumLength(2);
        RuleFor(d => d.LastName).MinimumLength(2);
        RuleFor(d => d.Biography).MinimumLength(2);

        RuleFor(d => d.CountryId).NotEmpty();
        RuleFor(d => d.FirstName).NotEmpty();
        RuleFor(d => d.LastName).NotEmpty();
        RuleFor(d => d.Biography).NotEmpty();
        RuleFor(d => d.DateOfBirth).NotEmpty();
    }
}
