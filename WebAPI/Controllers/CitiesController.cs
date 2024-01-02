using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CitiesController : ControllerBase
{
    ICityService _cityService;

    public CitiesController(ICityService cityService)
    {
        _cityService = cityService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _cityService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _cityService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCityRequest createCityRequest)
    {
        var result = await _cityService.AddAsync(createCityRequest);
        return Ok(result);
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCityRequest updateCityRequest)
    {
        var result = await _cityService.UpdateAsync(updateCityRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCityRequest deleteCityRequest)
    {
        var result = await _cityService.DeleteAsync(deleteCityRequest);
        return Ok(result);
    }
}