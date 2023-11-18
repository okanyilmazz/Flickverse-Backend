using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MovieCast : IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public int CastId { get; set; }
    }
}
