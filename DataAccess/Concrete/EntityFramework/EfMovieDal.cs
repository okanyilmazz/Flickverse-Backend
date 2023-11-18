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
                var result = from m in context.Movies
                             join c in context.Countries
                             on m.CountryId equals c.Id
                             select new MovieDetailDto
                             {
                                 Id = m.Id,
                                 CountryName = c.CountryName,
                                 Description = m.Description,
                                 Duration = m.Duration,
                                 IMDbRating = m.IMDbRating,
                                 Name = m.Name,
                                 ProductionYear = m.ProductionYear,
                                 ReleaseDate = m.ReleaseDate
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
