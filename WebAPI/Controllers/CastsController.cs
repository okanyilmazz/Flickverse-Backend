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
public class CastsController : ControllerBase
{
    ICastService _castService;

    public CastsController(ICastService castService)
    {
        _castService = castService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _castService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _castService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateCastRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCastRequest createCastRequest)
    {
        var result = await _castService.AddAsync(createCastRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateCastRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCastRequest updateCastRequest)
    {
        var result = await _castService.UpdateAsync(updateCastRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCastRequest deleteCastRequest)
    {
        var result = await _castService.DeleteAsync(deleteCastRequest);
        return Ok(result);
    }
}