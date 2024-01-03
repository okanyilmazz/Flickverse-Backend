using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class MovieImageBusinessRules : BaseBusinessRules
{
    IMovieImageDal _movieImageDal;

    public MovieImageBusinessRules(IMovieImageDal movieImageDal)
    {
        _movieImageDal = movieImageDal;
    }

    public async Task IsExistsMovieImage(Guid movieImageId)
    {
        var result = await _movieImageDal.GetAsync(
            predicate: a => a.Id == movieImageId);
        if (result == null)
        {
            throw new Exception(BusinessMessages.DataNotFound);
        }
    }
}