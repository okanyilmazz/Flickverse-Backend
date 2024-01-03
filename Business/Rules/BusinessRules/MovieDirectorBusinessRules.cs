using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class MovieDirectorBusinessRules : BaseBusinessRules
{
    IMovieDirectorDal _movieDirectorDal;

    public MovieDirectorBusinessRules(IMovieDirectorDal movieDirectorDal)
    {
        _movieDirectorDal = movieDirectorDal;
    }

    public async Task IsExistsMovieDirector(Guid movieDirectorId)
    {
        var result = await _movieDirectorDal.GetAsync(
            predicate: a => a.Id == movieDirectorId,
            enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
