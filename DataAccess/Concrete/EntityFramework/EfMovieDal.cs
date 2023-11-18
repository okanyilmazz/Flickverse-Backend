using Core.DataAccess.EntityFramework;
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
    public class EfMovieDal : EfEntityRepositoryBase<Movie, FlickVerseContext>, IMovieDal
    {
        public List<MovieDetailDto> GetMovieDetails(Expression<Func<MovieDetailDto, bool>> filter = null)
        {
            using (FlickVerseContext context = new FlickVerseContext())
            {
                var result = from movie in context.Movies
                             join c in context.Countries
                             on movie.CountryId equals c.Id
                             select new MovieDetailDto
                             {
                                 Id = movie.Id,
                                 CountryName = c.CountryName,
                                 Description = movie.Description,
                                 Duration = movie.Duration,
                                 IMDbRating = movie.IMDbRating,
                                 Name = movie.Name,
                                 ProductionYear = movie.ProductionYear,
                                 ReleaseDate = movie.ReleaseDate,
                                 Casts = ((from movieCast in context.MovieCasts
                                           join cast in context.Casts
                                           on movieCast.CastId equals cast.Id
                                           where (movieCast.MovieId == movie.Id)
                                           select new Cast
                                           {
                                               FirstName = cast.FirstName,
                                               LastName = cast.LastName,
                                               Id = cast.Id,
                                               Biography = cast.Biography,
                                               CountryId = cast.CountryId,
                                               DateOfBirth = cast.DateOfBirth
                                           }).ToList()),
                                 Directors = ((from movieDirector in context.MovieDirectors
                                           join director in context.Directors
                                           on movieDirector.DirectorId equals director.Id
                                           where (movieDirector.MovieId == movie.Id)
                                           select new Director
                                           {
                                               Id = director.Id,
                                               FirstName = director.FirstName,
                                               LastName = director.LastName,
                                               Biography = director.Biography,
                                               CountryId = director.CountryId,
                                               DateOfBirth = director.DateOfBirth
                                           }).ToList())

                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
