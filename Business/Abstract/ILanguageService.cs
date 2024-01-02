using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface ILanguageService
{
    Task<CreatedLanguageResponse> AddAsync(CreateLanguageRequest createLanguageRequest);
    Task<UpdatedLanguageResponse> UpdateAsync(UpdateLanguageRequest updateLanguageRequest);
    Task<DeletedLanguageResponse> DeleteAsync(DeleteLanguageRequest deleteLanguageRequest);
    Task<IPaginate<GetLanguageListResponse>> GetListAsync();
    Task<GetLanguageListResponse> GetByIdAsync(Guid id);
}