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
public class CountriesController : ControllerBase
{
    ICountryService _countryService;

    public CountriesController(ICountryService countryService)
    {
        _countryService = countryService;
    }

    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _countryService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _countryService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateCountryRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCountryRequest createCountryRequest)
    {
        var result = await _countryService.AddAsync(createCountryRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateCountryRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCountryRequest updateCountryRequest)
    {
        var result = await _countryService.UpdateAsync(updateCountryRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCountryRequest deleteCountryRequest)
    {
        var result = await _countryService.DeleteAsync(deleteCountryRequest);
        return Ok(result);
    }
}