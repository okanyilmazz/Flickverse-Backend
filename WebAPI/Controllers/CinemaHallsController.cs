using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.CrossCuttingConcerns.Cache;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CinemaHallsController : ControllerBase
{
    ICinemaHallService _cinemaHallService;

    public CinemaHallsController(ICinemaHallService cinemaHallService)
    {
        _cinemaHallService = cinemaHallService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _cinemaHallService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _cinemaHallService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("CinemaHalls.Get")]
    [CustomValidation(typeof(CreateCinemaHallRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCinemaHallRequest createCinemaHallRequest)
    {
        var result = await _cinemaHallService.AddAsync(createCinemaHallRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("CinemaHalls.Get")]
    [CustomValidation(typeof(UpdateCinemaHallRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCinemaHallRequest updateCinemaHallRequest)
    {
        var result = await _cinemaHallService.UpdateAsync(updateCinemaHallRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("CinemaHalls.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCinemaHallRequest deleteCinemaHallRequest)
    {
        var result = await _cinemaHallService.DeleteAsync(deleteCinemaHallRequest);
        return Ok(result);
    }
}