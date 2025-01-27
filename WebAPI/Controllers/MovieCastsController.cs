﻿using Business.Abstracts;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.MovieCastValidators;
using Business.Dtos.Requests.MovieCastRequests;

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

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _movieCastService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _movieCastService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieCasts.Get")]
    [CustomValidation(typeof(CreateMovieCastRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateMovieCastRequest createMovieCastRequest)
    {
        var result = await _movieCastService.AddAsync(createMovieCastRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieCasts.Get")]
    [CustomValidation(typeof(UpdateMovieCastRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateMovieCastRequest updateMovieCastRequest)
    {
        var result = await _movieCastService.UpdateAsync(updateMovieCastRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieCasts.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteMovieCastRequest deleteMovieCastRequest)
    {
        var result = await _movieCastService.DeleteAsync(deleteMovieCastRequest);
        return Ok(result);
    }
}