using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CinemaHallExclusiveLoungeBusinessRules : BaseBusinessRules
{
    ICinemaHallExclusiveLoungeDal _cinemaHallExclusiveLoungeDal;

    public CinemaHallExclusiveLoungeBusinessRules(ICinemaHallExclusiveLoungeDal cinemaHallExclusiveLoungeDal)
    {
        _cinemaHallExclusiveLoungeDal = cinemaHallExclusiveLoungeDal;
    }

    public async Task IsExistsCinemaHallExclusiveLounge(Guid cinemaHallExclusiveLoungeId)
    {
        var result = await _cinemaHallExclusiveLoungeDal.GetAsync(
            predicate: a => a.Id == cinemaHallExclusiveLoungeId);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}