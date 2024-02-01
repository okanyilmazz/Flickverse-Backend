﻿using Business.Dtos.Requests.ExclusiveLoungeRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.ExclusiveLoungeValidators;

public class CreateExclusiveLoungeRequestValidator : AbstractValidator<CreateExclusiveLoungeRequest>
{
    public CreateExclusiveLoungeRequestValidator()
    {
        RuleFor(el => el.Name).NotEmpty();
        RuleFor(el => el.Description).NotEmpty();

        RuleFor(el => el.Name).MinimumLength(2);
        RuleFor(el => el.Description).MinimumLength(10);
    }
}