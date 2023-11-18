using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Movie:IEntity
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double IMDbRating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }
        public DateTime ProductionYear { get; set; }
    }
}
