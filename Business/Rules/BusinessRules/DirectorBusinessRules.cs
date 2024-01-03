using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class DirectorBusinessRules : BaseBusinessRules
{
    IDirectorDal _directorDal;

    public DirectorBusinessRules(IDirectorDal directorDal)
    {
        _directorDal = directorDal;
    }

    public async Task IsExistsDirector(Guid directorId)
    {
        var result = await _directorDal.GetAsync(
            predicate: a => a.Id == directorId);
        if (result == null)
        {
            throw new Exception(BusinessMessages.DataNotFound);
        }
    }
}
