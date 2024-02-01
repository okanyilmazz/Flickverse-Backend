﻿using Business.Dtos.Requests.CityRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CityValidators;

public class CreateCityRequestValidator : AbstractValidator<CreateCityRequest>
{
    public CreateCityRequestValidator()
    {
        RuleFor(c => c.CountryId).NotEmpty();
        RuleFor(c => c.Name).NotEmpty();

        RuleFor(c => c.Name).MinimumLength(2);
    }
}