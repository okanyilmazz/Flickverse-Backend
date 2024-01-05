using Business.Abstract;
using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Rules.ValidationRules.FluentValidation.CreateRequestValidators;
using Business.Rules.ValidationRules.FluentValidation.UpdateRequestValidators;
using Core.CrossCuttingConcerns.Cache;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
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

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
    {
        var result = await _directorImageService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _directorImageService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("DirectorImages.Get")]
    [CustomValidation(typeof(CreateDirectorImageRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> Add(CreateDirectorImageRequest createDirectorImageRequest)
    {
        var result = await _directorImageService.AddAsync(createDirectorImageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("DirectorImages.Get")]
    [CustomValidation(typeof(UpdateDirectorImageRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> Update(UpdateDirectorImageRequest updateDirectorImageRequest)
    {
        var result = await _directorImageService.UpdateAsync(updateDirectorImageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("DirectorImages.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> Delete(DeleteDirectorImageRequest deleteDirectorImageRequest)
    {
        var result = await _directorImageService.DeleteAsync(deleteDirectorImageRequest);
        return Ok(result);
    }
}