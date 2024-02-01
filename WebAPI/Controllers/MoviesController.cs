using Business.Abstracts;
using Business.Dtos.Requests.MovieRequests;
using Business.Rules.ValidationRules.FluentValidation.MovieValidators;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MoviesController : ControllerBase
{
    IMovieService _movieService;
    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _movieService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _movieService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Movies.Get")]
    [CustomValidation(typeof(CreateMovieRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateMovieRequest createMovieRequest)
    {
        var result = await _movieService.AddAsync(createMovieRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Movies.Get")]
    [CustomValidation(typeof(UpdateMovieRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateMovieRequest updateMovieRequest)
    {
        var result = await _movieService.UpdateAsync(updateMovieRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Movies.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteMovieRequest deleteMovieRequest)
    {
        var result = await _movieService.DeleteAsync(deleteMovieRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetUpComingMovies")]
    public async Task<IActionResult> GetUpComingMoviesAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _movieService.GetUpComingMoviesAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [HttpGet("GetMoviesInVision")]
    public async Task<IActionResult> GetMoviesInVisionAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _movieService.GetMoviesInVisionAsync(pageRequest);
        return Ok(result);
    }
}
