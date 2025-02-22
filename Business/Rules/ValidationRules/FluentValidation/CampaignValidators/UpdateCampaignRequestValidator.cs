using Business.Dtos.Requests.CampaignRequests;
using FluentValidation;

namespace Business.Rules.ValidationRules.FluentValidation.CampaignValidators;

public class UpdateCampaignRequestValidator : AbstractValidator<UpdateCampaignRequest>
{
    public UpdateCampaignRequestValidator()
    {
        RuleFor(c => c.Id).NotEmpty();
        RuleFor(c => c.Title).NotEmpty();
        RuleFor(c => c.Description).NotEmpty();
        RuleFor(c => c.StartDate).NotEmpty();
        RuleFor(c => c.EndDate).NotEmpty();
    }
}
