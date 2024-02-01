using Business.Abstracts;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.ExclusiveLoungeValidators;
using Business.Dtos.Requests.ExclusiveLoungeRequests;

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

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _exclusiveLoungeService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _exclusiveLoungeService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("ExclusiveLounges.Get")]
    [CustomValidation(typeof(CreateExclusiveLoungeRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateExclusiveLoungeRequest createExclusiveLoungeRequest)
    {
        var result = await _exclusiveLoungeService.AddAsync(createExclusiveLoungeRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("ExclusiveLounges.Get")]
    [CustomValidation(typeof(UpdateExclusiveLoungeRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateExclusiveLoungeRequest updateExclusiveLoungeRequest)
    {
        var result = await _exclusiveLoungeService.UpdateAsync(updateExclusiveLoungeRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("ExclusiveLounges.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteExclusiveLoungeRequest deleteExclusiveLoungeRequest)
    {
        var result = await _exclusiveLoungeService.DeleteAsync(deleteExclusiveLoungeRequest);
        return Ok(result);
    }
}