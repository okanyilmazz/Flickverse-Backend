using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.LanguageRequests;
using Business.Dtos.Responses.LanguageResponses;
using Business.Rules.BusinessRules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class LanguageManager : ILanguageService
{
    ILanguageDal _languageDal;
    IMapper _mapper;
    LanguageBusinessRules _languageBusinessRules;

    public LanguageManager(ILanguageDal languageDal, IMapper mapper, LanguageBusinessRules languageBusinessRules)
    {
        _languageDal = languageDal;
        _mapper = mapper;
        _languageBusinessRules = languageBusinessRules;
    }

    public async Task<CreatedLanguageResponse> AddAsync(CreateLanguageRequest createLanguageRequest)
    {
        Language language = _mapper.Map<Language>(createLanguageRequest);
        Language addedLanguage = await _languageDal.AddAsync(language);
        CreatedLanguageResponse createdLanguageResponse = _mapper.Map<CreatedLanguageResponse>(addedLanguage);
        return createdLanguageResponse;
    }

    public async Task<DeletedLanguageResponse> DeleteAsync(DeleteLanguageRequest deleteLanguageRequest)
    {
        await _languageBusinessRules.IsExistsLanguage(deleteLanguageRequest.Id);
        Language language = await _languageDal.GetAsync(
           predicate: a => a.Id == deleteLanguageRequest.Id);
        Language deletedLanguage = await _languageDal.DeleteAsync(language);
        DeletedLanguageResponse deletedLanguageResponse = _mapper.Map<DeletedLanguageResponse>(deletedLanguage);
        return deletedLanguageResponse;
    }

    public async Task<GetLanguageListResponse> GetByIdAsync(Guid id)
    {
        Language language = await _languageDal.GetAsync(
            predicate: a => a.Id == id);
        GetLanguageListResponse getLanguageListResponse = _mapper.Map<GetLanguageListResponse>(language);
        return getLanguageListResponse;
    }

    public async Task<IPaginate<GetLanguageListResponse>> GetListAsync(PageRequest pageRequest)
    {
        var languageList = await _languageDal.GetListAsync(
            size: pageRequest.PageSize,
            index: pageRequest.PageIndex);
        var mappedLanguageList = _mapper.Map<Paginate<GetLanguageListResponse>>(languageList);
        return mappedLanguageList;
    }

    public async Task<UpdatedLanguageResponse> UpdateAsync(UpdateLanguageRequest updateLanguageRequest)
    {
        await _languageBusinessRules.IsExistsLanguage(updateLanguageRequest.Id);
        Language language = _mapper.Map<Language>(updateLanguageRequest);
        Language updatedLanguage = await _languageDal.UpdateAsync(language);
        UpdatedLanguageResponse updatedLanguageResponse = _mapper.Map<UpdatedLanguageResponse>(updatedLanguage);
        return updatedLanguageResponse;
    }
}
