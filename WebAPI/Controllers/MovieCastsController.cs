using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieCastsController : ControllerBase
{
    IMovieCastService _movieCastService;

    public MovieCastsController(IMovieCastService movieCastService)
    {
        _movieCastService = movieCastService;
    }

    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _movieCastService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _movieCastService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateMovieCastRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateMovieCastRequest createMovieCastRequest)
    {
        var result = await _movieCastService.AddAsync(createMovieCastRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateMovieCastRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateMovieCastRequest updateMovieCastRequest)
    {
        var result = await _movieCastService.UpdateAsync(updateMovieCastRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteMovieCastRequest deleteMovieCastRequest)
    {
        var result = await _movieCastService.DeleteAsync(deleteMovieCastRequest);
        return Ok(result);
    }
}