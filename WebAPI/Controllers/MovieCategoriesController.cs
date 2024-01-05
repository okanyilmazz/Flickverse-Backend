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
public class MovieCategoriesController : ControllerBase
{

    IMovieCategoryService _movieCategoryService;

    public MovieCategoriesController(IMovieCategoryService movieCategoryService)
    {
        _movieCategoryService = movieCategoryService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _movieCategoryService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _movieCategoryService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieCategories.Get")]
    [CustomValidation(typeof(CreateMovieCategoryRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateMovieCategoryRequest createMovieCategoryRequest)
    {
        var result = await _movieCategoryService.AddAsync(createMovieCategoryRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieCategories.Get")]
    [CustomValidation(typeof(UpdateMovieCategoryRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateMovieCategoryRequest updateMovieCategoryRequest)
    {
        var result = await _movieCategoryService.UpdateAsync(updateMovieCategoryRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("MovieCategories.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteMovieCategoryRequest deleteMovieCategoryRequest)
    {
        var result = await _movieCategoryService.DeleteAsync(deleteMovieCategoryRequest);
        return Ok(result);
    }
}