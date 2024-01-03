using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class MovieBusinessRules : BaseBusinessRules
{
    IMovieDal _movieDal;

    public MovieBusinessRules(IMovieDal movieDal)
    {
        _movieDal = movieDal;
    }

    public async Task IsExistsMovie(Guid movieId)
    {
        var result = await _movieDal.GetAsync(
            predicate: a => a.Id == movieId);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
