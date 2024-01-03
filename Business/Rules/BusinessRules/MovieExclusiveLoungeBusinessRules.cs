using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class MovieExclusiveLoungeBusinessRules : BaseBusinessRules
{
    IMovieExclusiveLoungeDal _movieExclusiveLoungeDal;

    public MovieExclusiveLoungeBusinessRules(IMovieExclusiveLoungeDal movieExclusiveLoungeDal)
    {
        _movieExclusiveLoungeDal = movieExclusiveLoungeDal;
    }

    public async Task IsExistsMovieExclusiveLounge(Guid movieExclusiveLoungeId)
    {
        var result = await _movieExclusiveLoungeDal.GetAsync(
            predicate: a => a.Id == movieExclusiveLoungeId);
        if (result == null)
        {
            throw new Exception(BusinessMessages.DataNotFound);
        }
    }
}
