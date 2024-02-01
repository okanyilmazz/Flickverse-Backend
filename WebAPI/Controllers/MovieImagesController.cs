using Business.Abstracts;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.MovieImageValidators;
using Business.Dtos.Requests.MovieImageRequests;

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

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _movieImageService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _movieImageService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieImages.Get")]
    [CustomValidation(typeof(CreateMovieImageRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateMovieImageRequest createMovieImageRequest)
    {
        var result = await _movieImageService.AddAsync(createMovieImageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieImages.Get")]
    [CustomValidation(typeof(UpdateMovieImageRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateMovieImageRequest updateMovieImageRequest)
    {
        var result = await _movieImageService.UpdateAsync(updateMovieImageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieImages.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteMovieImageRequest deleteMovieImageRequest)
    {
        var result = await _movieImageService.DeleteAsync(deleteMovieImageRequest);
        return Ok(result);
    }
}