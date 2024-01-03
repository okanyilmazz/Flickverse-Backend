using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.CrossCuttingConcerns.Validation;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MovieDirectorsController : ControllerBase
{
    IMovieDirectorService _movieDirectorService;

    public MovieDirectorsController(IMovieDirectorService movieDirectorService)
    {
        _movieDirectorService = movieDirectorService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _movieDirectorService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _movieDirectorService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateMovieDirectorRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateMovieDirectorRequest createMovieDirectorRequest)
    {
        var result = await _movieDirectorService.AddAsync(createMovieDirectorRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateMovieDirectorRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateMovieDirectorRequest updateMovieDirectorRequest)
    {
        var result = await _movieDirectorService.UpdateAsync(updateMovieDirectorRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteMovieDirectorRequest deleteMovieDirectorRequest)
    {
        var result = await _movieDirectorService.DeleteAsync(deleteMovieDirectorRequest);
        return Ok(result);
    }
}