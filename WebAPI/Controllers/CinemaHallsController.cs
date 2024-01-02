using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CinemaHallsController : ControllerBase
{
    ICinemaHallService _cinemaHallService;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _cinemaHallService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _cinemaHallService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateCinemaHallRequest createCinemaHallRequest)
    {
        var result = await _cinemaHallService.AddAsync(createCinemaHallRequest);
        return Ok(result);
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateCinemaHallRequest updateCinemaHallRequest)
    {
        var result = await _cinemaHallService.UpdateAsync(updateCinemaHallRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteCinemaHallRequest deleteCinemaHallRequest)
    {
        var result = await _cinemaHallService.DeleteAsync(deleteCinemaHallRequest);
        return Ok(result);
    }
}