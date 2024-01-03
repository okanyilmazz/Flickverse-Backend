using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class MovieCastBusinessRules : BaseBusinessRules
{
    IMovieCastDal _movieCastDal;

    public MovieCastBusinessRules(IMovieCastDal movieCastDal)
    {
        _movieCastDal = movieCastDal;
    }

    public async Task IsExistsMovieCast(Guid movieCastId)
    {
        var result = await _movieCastDal.GetAsync(
            predicate: a => a.Id == movieCastId,
            enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
