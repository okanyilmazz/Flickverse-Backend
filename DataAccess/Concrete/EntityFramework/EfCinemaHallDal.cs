using Core.DataAccess.EntityFramework;
using Core.Utilities.Results;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCinemaHallDal : EfEntityRepositoryBase<CinemaHall, FlickVerseContext>, ICinemaHallDal
    {
        public List<CinemaHallDetailsDto> GetCinemaDetails(Expression<Func<CinemaHallDetailsDto, bool>> filter = null)
        {
            using (FlickVerseContext context = new FlickVerseContext())
            {
                var result = from cinema in context.CinemaHalls
                             join address in context.Addresses
                             on cinema.AddressId equals address.Id
                             join county in context.Counties
                             on address.CountyId equals county.Id
                             join city in context.Cities
                             on county.CityId equals city.Id
                             select new CinemaHallDetailsDto
                             {
                                 Id = cinema.Id,
                                 Address = address.Description,
                                 CinemaName = cinema.Name,
                                 CityName = city.Name,
                                 CountyName = county.Name,

                                 Lounges = ((from cinemaLounge in context.CinemaLounges
                                             join exclusiveLounge in context.ExclusiveLounges
                                             on cinemaLounge.ExclusiveLoungeId equals exclusiveLounge.Id
                                             where (cinemaLounge.CinemaHallId == cinema.Id)
                                             select new ExclusiveLounge
                                             {
                                                 Id = exclusiveLounge.Id,
                                                 Name = exclusiveLounge.Name,
                                                 Description = exclusiveLounge.Description
                                             }).ToList()),

                                 Movies = ((from cinemaMovie in context.CinemaMovies
                                            join movie in context.Movies
                                            on cinemaMovie.MovieId equals movie.Id
                                            where (cinema.Id == cinemaMovie.CinemaHallId)
                                            select new Movie
                                            {
                                                Id = movie.Id,
                                                CountryId = movie.CountryId,
                                                Description = movie.Description,
                                                Duration = movie.Duration,
                                                IMDbRating = movie.IMDbRating,
                                                LanguageId = movie.LanguageId,
                                                Name = movie.Name,
                                                ProductionYear = movie.ProductionYear,
                                                ReleaseDate = movie.ReleaseDate
                                            }
                                          )).ToList()
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();





            }
        }
    }
}
