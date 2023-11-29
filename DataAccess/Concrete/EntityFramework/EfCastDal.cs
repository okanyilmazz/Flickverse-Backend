using Core.DataAccess.EntityFramework;
using DataAccess.Abstract.EntityFramework;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCastDal : EfEntityRepositoryBase<Cast, FlickVerseContext>, ICastDal
    {
        public List<CastDetailDto> GetCastDetails(Expression<Func<CastDetailDto, bool>> filter = null)
        {
            using (FlickVerseContext context = new FlickVerseContext())
            {
                var result = from cast in context.Casts
                             join country in context.Countries
                             on cast.CountryId equals country.Id
                             select new CastDetailDto
                             {
                                 Id = cast.Id,
                                 FirstName = cast.FirstName,
                                 LastName = cast.LastName,
                                 Biography = cast.Biography,
                                 CountryName = country.CountryName,
                                 DateOfBirth = cast.DateOfBirth,
                                 
                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();

            }
        }
    }
}
