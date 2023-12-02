using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CinemaLounge : IEntity
    {
        public int Id { get; set; }
        public int CinemaHallId { get; set; }
        public int ExclusiveLoungeId { get; set; }
    }
}
