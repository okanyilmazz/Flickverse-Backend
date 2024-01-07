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
public class CinemaHallExclusiveLoungesController : ControllerBase
{
    ICinemaHallExclusiveLoungeService _cinemaHallExclusiveLoungeService;

    public CinemaHallExclusiveLoungesController(ICinemaHallExclusiveLoungeService cinemaHallExclusiveLoungeService)
    {
        _cinemaHallExclusiveLoungeService = cinemaHallExclusiveLoungeService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _cinemaHallExclusiveLoungeService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("CinemaHallExclusiveLounges.Get")]
    [CustomValidation(typeof(CreateCinemaHallExclusiveLoungeRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCinemaHallExclusiveLoungeRequest createCinemaHallExclusiveLoungeRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.AddAsync(createCinemaHallExclusiveLoungeRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))] 
    [CacheRemove("CinemaHallExclusiveLounges.Get")]
    [CustomValidation(typeof(UpdateCinemaHallExclusiveLoungeRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCinemaHallExclusiveLoungeRequest updateCinemaHallExclusiveLoungeRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.UpdateAsync(updateCinemaHallExclusiveLoungeRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("CinemaHallExclusiveLounges.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCinemaHallExclusiveLoungeRequest deleteCinemaHallExclusiveLoungeRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.DeleteAsync(deleteCinemaHallExclusiveLoungeRequest);
        return Ok(result);
    }
}