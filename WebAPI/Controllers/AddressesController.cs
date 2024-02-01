using Business.Abstracts;
using Business.Dtos.Requests.AddressRequests;
using Business.Rules.ValidationRules.FluentValidation.AddressValidators;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressesController : ControllerBase
{
    IAddressService _addressService;

    public AddressesController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _addressService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache(5)]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _addressService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Addresses.Get")]
    [CustomValidation(typeof(CreateAddressRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync(CreateAddressRequest createAddressRequest)
    {
        var result = await _addressService.AddAsync(createAddressRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Addresses.Get")]
    [CustomValidation(typeof(UpdateAddressRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> UpdateAsync(UpdateAddressRequest updateAddressRequest)
    {
        var result = await _addressService.UpdateAsync(updateAddressRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Addresses.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteAsync(DeleteAddressRequest deleteAddressRequest)
    {
        var result = await _addressService.DeleteAsync(deleteAddressRequest);
        return Ok(result);
    }
}
