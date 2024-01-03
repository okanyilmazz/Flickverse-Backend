using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class MovieCategoryBusinessRules : BaseBusinessRules
{
    IMovieCategoryDal _movieCategoryDal;

    public MovieCategoryBusinessRules(IMovieCategoryDal movieCategoryDal)
    {
        _movieCategoryDal = movieCategoryDal;
    }

    public async Task IsExistsMovieCategory(Guid movieCategoryId)
    {
        var result = await _movieCategoryDal.GetAsync(
            predicate: a => a.Id == movieCategoryId,
            enableTracking: false);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}
