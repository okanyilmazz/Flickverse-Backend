using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.CrossCuttingConcerns.Cache;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExclusiveLoungesController : ControllerBase
{
    IExclusiveLoungeService _exclusiveLoungeService;

    public ExclusiveLoungesController(IExclusiveLoungeService exclusiveLoungeService)
    {
        _exclusiveLoungeService = exclusiveLoungeService;
    }

    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _exclusiveLoungeService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _exclusiveLoungeService.GetByIdAsync(id);
        return Ok(result);
    }

    [CacheRemove("ExclusiveLounges.Get")]
    [CustomValidation(typeof(CreateExclusiveLoungeRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateExclusiveLoungeRequest createExclusiveLoungeRequest)
    {
        var result = await _exclusiveLoungeService.AddAsync(createExclusiveLoungeRequest);
        return Ok(result);
    }

    [CacheRemove("ExclusiveLounges.Get")]
    [CustomValidation(typeof(UpdateExclusiveLoungeRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateExclusiveLoungeRequest updateExclusiveLoungeRequest)
    {
        var result = await _exclusiveLoungeService.UpdateAsync(updateExclusiveLoungeRequest);
        return Ok(result);
    }

    [CacheRemove("ExclusiveLounges.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteExclusiveLoungeRequest deleteExclusiveLoungeRequest)
    {
        var result = await _exclusiveLoungeService.DeleteAsync(deleteExclusiveLoungeRequest);
        return Ok(result);
    }
}