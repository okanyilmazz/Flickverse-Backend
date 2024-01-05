﻿using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.CrossCuttingConcerns.Cache;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CastImagesController : ControllerBase
{
    ICastImageService _castImageService;

    public CastImagesController(ICastImageService castImageService)
    {
        _castImageService = castImageService;
    }

    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _castImageService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _castImageService.GetByIdAsync(id);
        return Ok(result);
    }

    [CacheRemove("CastImages.Get")]
    [CustomValidation(typeof(CreateCastImageRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync(CreateCastImageRequest createCastImageRequest)
    {
        var result = await _castImageService.AddAsync(createCastImageRequest);
        return Ok(result);
    }

    [CacheRemove("CastImages.Get")]
    [CustomValidation(typeof(UpdateCastImageRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> UpdateAsync(UpdateCastImageRequest updateCastImageRequest)
    {
        var result = await _castImageService.UpdateAsync(updateCastImageRequest);
        return Ok(result);
    }

    [CacheRemove("CastImages.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteAsync(DeleteCastImageRequest deleteCastImageRequest)
    {
        var result = await _castImageService.DeleteAsync(deleteCastImageRequest);
        return Ok(result);
    }
}