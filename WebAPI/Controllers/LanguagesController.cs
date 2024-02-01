using Business.Abstracts;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Logging.SeriLog.Logger;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Validation;
using Core.DataAccess.Paging;
using Microsoft.AspNetCore.Mvc;
using Business.Rules.ValidationRules.FluentValidation.LanguageValidators;
using Business.Dtos.Requests.LanguageRequests;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguagesController : ControllerBase
{
    ILanguageService _languageService;

    public LanguagesController(ILanguageService languageService)
    {
        _languageService = languageService;
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetList")]
    public async Task<IActionResult> GetListAsync([FromQuery] PageRequest pageRequest)
    {
        var result = await _languageService.GetListAsync(pageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [Cache]
    [HttpGet("GetById")]
    public async Task<IActionResult> GetByIdAsync(Guid id)
    {
        var result = await _languageService.GetByIdAsync(id);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Languages.Get")]
    [CustomValidation(typeof(CreateLanguageRequestValidator))]
    [HttpPost("Add")]
    public async Task<IActionResult> AddAsync(CreateLanguageRequest createLanguageRequest)
    {
        var result = await _languageService.AddAsync(createLanguageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Languages.Get")]
    [CustomValidation(typeof(UpdateLanguageRequestValidator))]
    [HttpPost("Update")]
    public async Task<IActionResult> UpdateAsync(UpdateLanguageRequest updateLanguageRequest)
    {
        var result = await _languageService.UpdateAsync(updateLanguageRequest);
        return Ok(result);
    }

    [Logging(typeof(FileLogger))]
    [Logging(typeof(MsSqlLogger))]
    [CacheRemove("Languages.Get")]
    [HttpPost("Delete")]
    public async Task<IActionResult> DeleteAsync(DeleteLanguageRequest deleteLanguageRequest)
    {
        var result = await _languageService.DeleteAsync(deleteLanguageRequest);
        return Ok(result);
    }
}