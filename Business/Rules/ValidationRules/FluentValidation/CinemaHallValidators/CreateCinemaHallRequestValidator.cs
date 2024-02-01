﻿using Business.Dtos.Requests.CinemaHallRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CinemaHallValidators;

public class CreateCinemaHallRequestValidator : AbstractValidator<CreateCinemaHallRequest>
{
    public CreateCinemaHallRequestValidator()
    {
        RuleFor(ch => ch.Description).MinimumLength(10);
        RuleFor(ch => ch.Name).MinimumLength(2);
        RuleFor(ch => ch.Description).NotEmpty();
        RuleFor(ch => ch.Name).NotEmpty();
        RuleFor(ch => ch.AddressId).NotEmpty();
    }
}