﻿using Business.Dtos.Requests.MovieRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.MovieValidators;

public class UpdateMovieRequestValidator : AbstractValidator<UpdateMovieRequest>
{
    public UpdateMovieRequestValidator()
    {
        RuleFor(m => m.CountryId).NotEmpty();
        RuleFor(m => m.LanguageId).NotEmpty();
        RuleFor(m => m.Name).NotEmpty();
        RuleFor(m => m.Description).NotEmpty();
        RuleFor(m => m.ReleaseDate).NotEmpty();
        RuleFor(m => m.Duration).NotEmpty();
        RuleFor(m => m.ProductionYear).NotEmpty();

        RuleFor(m => m.IMDbRating).Empty();

        RuleFor(m => m.Name).MinimumLength(2);
        RuleFor(m => m.Description).MinimumLength(10);
    }
}