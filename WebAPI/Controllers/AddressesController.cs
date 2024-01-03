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
public class AddressesController : ControllerBase
{
    IAddressService _addressService;

    public AddressesController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _addressService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _addressService.GetByIdAsync(id);
        return Ok(result);
    }

    [CustomValidation(typeof(CreateAddressRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateAddressRequest createAddressRequest)
    {
        var result = await _addressService.AddAsync(createAddressRequest);
        return Ok(result);
    }

    [CustomValidation(typeof(UpdateAddressRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateAddressRequest updateAddressRequest)
    {
        var result = await _addressService.UpdateAsync(updateAddressRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteAddressRequest deleteAddressRequest)
    {
        var result = await _addressService.DeleteAsync(deleteAddressRequest);
        return Ok(result);
    }
}
