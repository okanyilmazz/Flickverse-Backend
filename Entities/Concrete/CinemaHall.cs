using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CinemaHall : IEntity
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
