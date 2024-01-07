using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CastsController : ControllerBase
{
    ICastService _castService;

    public CastsController(ICastService castService)
    {
        _castService = castService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _castService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _castService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Casts.Get")]
    [CustomValidation(typeof(CreateCastRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync(CreateCastRequest createCastRequest)
    {
        var result = await _castService.AddAsync(createCastRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Casts.Get")]
    [CustomValidation(typeof(UpdateCastRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> UpdateAsync(UpdateCastRequest updateCastRequest)
    {
        var result = await _castService.UpdateAsync(updateCastRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Casts.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteAsync(DeleteCastRequest deleteCastRequest)
    {
        var result = await _castService.DeleteAsync(deleteCastRequest);
        return Ok(result);
    }
}