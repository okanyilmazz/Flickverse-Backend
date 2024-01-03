﻿using Business.Constants.Messages;
using Core.Business.Rules;
using DataAccess.Abstracts;

namespace Business.Rules.BusinessRules;

public class CinemaHallMovieBusinessRules : BaseBusinessRules
{
    ICinemaHallMovieDal _cinemaHallMovieDal;

    public CinemaHallMovieBusinessRules(ICinemaHallMovieDal cinemaHallMovieDal)
    {
        _cinemaHallMovieDal = cinemaHallMovieDal;
    }

    public async Task IsExistsCinemaHallMovie(Guid cinemaHallMovieId)
    {
        var result = await _cinemaHallMovieDal.GetAsync(
            predicate: a => a.Id == cinemaHallMovieId);
        if (result == null)
        {
            throw new Exception(BusinessMessages.DataNotFound);
        }
    }
}