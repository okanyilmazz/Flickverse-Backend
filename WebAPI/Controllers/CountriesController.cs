using Business.Abstracts;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.CountryValidators;
using Business.Dtos.Requests.CountryRequests;

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

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _countryService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache(50)]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _countryService.GetByIdAsync(id);
        return Ok(result);
    }


    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Countries.Get")]
    [CustomValidation(typeof(CreateCountryRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCountryRequest createCountryRequest)
    {
        var result = await _countryService.AddAsync(createCountryRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Countries.Get")]
    [CustomValidation(typeof(UpdateCountryRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCountryRequest updateCountryRequest)
    {
        var result = await _countryService.UpdateAsync(updateCountryRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Countries.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCountryRequest deleteCountryRequest)
    {
        var result = await _countryService.DeleteAsync(deleteCountryRequest);
        return Ok(result);
    }
}