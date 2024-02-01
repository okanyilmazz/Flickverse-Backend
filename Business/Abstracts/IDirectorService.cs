using Business.Dtos.Requests.DirectorRequests;
using Business.Dtos.Responses.DirectorResponses;
using Core.DataAccess.Paging;

namespace Business.Abstracts;

public interface IDirectorService
{
    Task<CreatedDirectorResponse> AddAsync(CreateDirectorRequest createDirectorRequest);
    Task<UpdatedDirectorResponse> UpdateAsync(UpdateDirectorRequest updateDirectorRequest);
    Task<DeletedDirectorResponse> DeleteAsync(DeleteDirectorRequest deleteDirectorRequest);
    Task<IPaginate<GetDirectorListResponse>> GetListAsync(PageRequest pageRequest);
    Task<GetDirectorListResponse> GetByIdAsync(Guid id);
}
