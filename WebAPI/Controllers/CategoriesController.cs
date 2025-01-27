﻿using Business.Abstracts;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.CategoryValidators;
using Business.Dtos.Requests.CategoryRequests;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriesController : ControllerBase
{
    ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _categoryService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _categoryService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Categories.Get")]
    [CustomValidation(typeof(CreateCategoryRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCategoryRequest createCategoryRequest)
    {
        var result = await _categoryService.AddAsync(createCategoryRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Categories.Get")]
    [CustomValidation(typeof(UpdateCategoryRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCategoryRequest updateCategoryRequest)
    {
        var result = await _categoryService.UpdateAsync(updateCategoryRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Categories.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCategoryRequest deleteCategoryRequest)
    {
        var result = await _categoryService.DeleteAsync(deleteCategoryRequest);
        return Ok(result);
    }
}