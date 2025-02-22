using Business.Abstracts;
using Business.Dtos.Requests.CampaignRequests;
using Business.Rules.ValidationRules.FluentValidation.CampaignValidators;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CampaignsController : ControllerBase
{
    ICampaignService _campaignService;
    public CampaignsController(ICampaignService campaignService)
    {
        _campaignService = campaignService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache(60)]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _campaignService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _campaignService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Campaigns.Get")]
    [CustomValidation(typeof(CreateCampaignRequestValidator))]
    [HttpPost]
    public async Task<IActionResult> AddAsync(CreateCampaignRequest createCampaignRequest)
    {
        var result = await _campaignService.AddAsync(createCampaignRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Campaigns.Get")]
    [CustomValidation(typeof(UpdateCampaignRequestValidator))]
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(UpdateCampaignRequest updateCampaignRequest)
    {
        var result = await _campaignService.UpdateAsync(updateCampaignRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Campaigns.Get")]
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
    {
        var result = await _campaignService.DeleteAsync(id);
        return Ok(result);
    }
}