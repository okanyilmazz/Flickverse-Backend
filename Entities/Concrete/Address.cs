using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public int CountyId { get; set; }
        //public int CityId { get; set; }
        //public int CountryId { get; set; }
        public string Description { get; set; }
    }
}
