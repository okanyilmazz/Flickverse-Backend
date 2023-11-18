using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDirectorDal : EfEntityRepositoryBase<Director, FlickVerseContext>, IDirectorDal
    {
        public List<DirectorDetailDto> GetDirectorDetails(Expression<Func<DirectorDetailDto, bool>> filter = null)
        {

            using (FlickVerseContext context = new FlickVerseContext())
            {
                var result = from director in context.Directors
                             join country in context.Countries
                             on director.CountryId equals country.Id
                             select new DirectorDetailDto
                             {
                                 Id = director.Id,
                                 FirstName = director.FirstName,
                                 LastName = director.LastName,
                                 Biography = director.Biography,
                                 CountryName = country.CountryName,
                                 DateOfBirth = director.DateOfBirth,
                                 Movies = (
                                 (from movie in context.Movies
                                  join movieDirector in context.MovieDirectors
                                  on movie.Id equals movieDirector.MovieId
                                  where (movieDirector.DirectorId == director.Id)
                                  select new Movie
                                  {
                                      Id = movie.Id,
                                      Name = movie.Name,
                                      Duration = movie.Duration,
                                      ProductionYear = movie.ProductionYear,
                                      ReleaseDate = movie.ReleaseDate,
                                      LanguageId = movie.LanguageId,
                                      IMDbRating = movie.IMDbRating,
                                      Description = movie.Description,
                                      CountryId = movie.CountryId
                                  }).ToList()),
                                 DirectorImages = ((from image in context.DirectorImages
                                                    where (image.DirectorId == director.Id)
                                                    select new DirectorImage
                                                    {
                                                        DirectorId = image.DirectorId,
                                                        Id = image.Id,
                                                        ImagePath = image.ImagePath
                                                    }).ToList())
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();

            }
        }
    }
}
