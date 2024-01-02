using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DirectorsController : ControllerBase
{
    IDirectorService _directorService;

    public DirectorsController(IDirectorService directorService)
    {
        _directorService = directorService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _directorService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _directorService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateDirectorRequest createDirectorRequest)
    {
        var result = await _directorService.AddAsync(createDirectorRequest);
        return Ok(result);
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateDirectorRequest updateDirectorRequest)
    {
        var result = await _directorService.UpdateAsync(updateDirectorRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteDirectorRequest deleteDirectorRequest)
    {
        var result = await _directorService.DeleteAsync(deleteDirectorRequest);
        return Ok(result);
    }
}