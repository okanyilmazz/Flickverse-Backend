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
public class MovieImagesController : ControllerBase
{
    IMovieImageService _movieImageService;

    public MovieImagesController(IMovieImageService movieImageService)
    {
        _movieImageService = movieImageService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _movieImageService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _movieImageService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateMovieImageRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateMovieImageRequest createMovieImageRequest)
    {
        var result = await _movieImageService.AddAsync(createMovieImageRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateMovieImageRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateMovieImageRequest updateMovieImageRequest)
    {
        var result = await _movieImageService.UpdateAsync(updateMovieImageRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteMovieImageRequest deleteMovieImageRequest)
    {
        var result = await _movieImageService.DeleteAsync(deleteMovieImageRequest);
        return Ok(result);
    }
}