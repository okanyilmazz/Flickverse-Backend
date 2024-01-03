using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CinemaHallBusinessRules : BaseBusinessRules
{
    ICinemaHallDal _cinemaHallDal;

    public CinemaHallBusinessRules(ICinemaHallDal cinemaHallDal)
    {
        _cinemaHallDal = cinemaHallDal;
    }

    public async Task IsExistsCinemaHall(Guid cinemaHallId)
    {
        var result = await _cinemaHallDal.GetAsync(
            predicate: a => a.Id == cinemaHallId);
        if (result == null)
        {
            throw new BusinessException(BusinessMessages.DataNotFound);
        }
    }
}