﻿using Business.Abstract;
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
public class CinemaHallExclusiveLoungesController : ControllerBase
{
    ICinemaHallExclusiveLoungeService _cinemaHallExclusiveLoungeService;

    public CinemaHallExclusiveLoungesController(ICinemaHallExclusiveLoungeService cinemaHallExclusiveLoungeService)
    {
        _cinemaHallExclusiveLoungeService = cinemaHallExclusiveLoungeService;
    }

    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _cinemaHallExclusiveLoungeService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateCinemaHallExclusiveLoungeRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCinemaHallExclusiveLoungeRequest createCinemaHallExclusiveLoungeRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.AddAsync(createCinemaHallExclusiveLoungeRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateCinemaHallExclusiveLoungeRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCinemaHallExclusiveLoungeRequest updateCinemaHallExclusiveLoungeRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.UpdateAsync(updateCinemaHallExclusiveLoungeRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCinemaHallExclusiveLoungeRequest deleteCinemaHallExclusiveLoungeRequest)
    {
        var result = await _cinemaHallExclusiveLoungeService.DeleteAsync(deleteCinemaHallExclusiveLoungeRequest);
        return Ok(result);
    }
}