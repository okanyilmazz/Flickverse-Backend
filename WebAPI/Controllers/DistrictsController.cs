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
public class DistrictsController : ControllerBase
{
    IDistrictService _districtService;

    public DistrictsController(IDistrictService districtService)
    {
        _districtService = districtService;
    }

    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _districtService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _districtService.GetByIdAsync(id);
        return Ok(result);
    }

    [CacheRemove("Districts.Get")]
    [CustomValidation(typeof(CreateDistrictRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateDistrictRequest createDistrictRequest)
    {
        var result = await _districtService.AddAsync(createDistrictRequest);
        return Ok(result);
    }

    [CacheRemove("Districts.Get")]
    [CustomValidation(typeof(UpdateDistrictRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateDistrictRequest updateDistrictRequest)
    {
        var result = await _districtService.UpdateAsync(updateDistrictRequest);
        return Ok(result);
    }

    [CacheRemove("Districts.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteDistrictRequest deleteDistrictRequest)
    {
        var result = await _districtService.DeleteAsync(deleteDistrictRequest);
        return Ok(result);
    }
}