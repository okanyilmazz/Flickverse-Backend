using Business.Dtos.Requests.CreateRequests;
using Business.Dtos.Requests.DeleteRequests;
using Business.Dtos.Requests.UpdateRequests;
using Business.Dtos.Responses.CreatedResponses;
using Business.Dtos.Responses.DeletedResponses;
using Business.Dtos.Responses.GetListResponses;
using Business.Dtos.Responses.UpdatedResponses;
using Core.DataAccess.Paging;

namespace Business.Abstract;

public interface IDirectorService
{
    Task<CreatedDirectorResponse> AddAsync(CreateDirectorRequest createDirectorRequest);
    Task<UpdatedDirectorResponse> UpdateAsync(UpdateDirectorRequest updateDirectorRequest);
    Task<DeletedDirectorResponse> DeleteAsync(DeleteDirectorRequest deleteDirectorRequest);
    Task<IPaginate<GetDirectorListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetDirectorListResponse> GetByIdAsync(Guid id);
}
