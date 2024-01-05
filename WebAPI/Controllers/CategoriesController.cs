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
public class CategoriesController : ControllerBase
{
    ICategoryService _categoryService;

    public CategoriesController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _categoryService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _categoryService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateCategoryRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCategoryRequest createCategoryRequest)
    {
        var result = await _categoryService.AddAsync(createCategoryRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateCategoryRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCategoryRequest updateCategoryRequest)
    {
        var result = await _categoryService.UpdateAsync(updateCategoryRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCategoryRequest deleteCategoryRequest)
    {
        var result = await _categoryService.DeleteAsync(deleteCategoryRequest);
        return Ok(result);
    }
}