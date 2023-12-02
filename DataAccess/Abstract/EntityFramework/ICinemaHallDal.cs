using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract.EntityFramework
{
    public interface ICinemaHallDal : IEntityRepository<CinemaHall>
    {
        List<CinemaHallDetailsDto> GetCinemaDetails(Expression<Func<CinemaHallDetailsDto, bool>> filter = null);
    }
}
