using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DirectorImagesController : ControllerBase
{
    IDirectorImageService _directorImageService;

    public DirectorImagesController(IDirectorImageService directorImageService)
    {
        _directorImageService = directorImageService;
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var result = await _directorImageService.GetListAsync();
        return Ok(result);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _directorImageService.GetByIdAsync(id);
        return Ok(result);
    }

    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateDirectorImageRequest createDirectorImageRequest)
    {
        var result = await _directorImageService.AddAsync(createDirectorImageRequest);
        return Ok(result);
    }

    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateDirectorImageRequest updateDirectorImageRequest)
    {
        var result = await _directorImageService.UpdateAsync(updateDirectorImageRequest);
        return Ok(result);
    }

    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteDirectorImageRequest deleteDirectorImageRequest)
    {
        var result = await _directorImageService.DeleteAsync(deleteDirectorImageRequest);
        return Ok(result);
    }
}