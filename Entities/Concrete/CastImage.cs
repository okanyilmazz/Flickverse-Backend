using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CastImage : IEntity
    {
        public int Id { get; set; }
        public int CastId { get; set; }
        public string ImagePath { get; set; }
    }
}
