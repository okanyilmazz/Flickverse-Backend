using Business.Abstracts;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.DirectorValidators;
using Business.Dtos.Requests.DirectorRequests;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DirectorsController : ControllerBase
{
    IDirectorService _directorService;

    public DirectorsController(IDirectorService directorService)
    {
        _directorService = directorService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _directorService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _directorService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Directors.Get")]
    [CustomValidation(typeof(CreateDirectorRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateDirectorRequest createDirectorRequest)
    {
        var result = await _directorService.AddAsync(createDirectorRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Directors.Get")]
    [CustomValidation(typeof(UpdateDirectorRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateDirectorRequest updateDirectorRequest)
    {
        var result = await _directorService.UpdateAsync(updateDirectorRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Directors.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteDirectorRequest deleteDirectorRequest)
    {
        var result = await _directorService.DeleteAsync(deleteDirectorRequest);
        return Ok(result);
    }
}