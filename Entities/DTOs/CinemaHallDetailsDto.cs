using Core.Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class CinemaHallDetailsDto : IDto
    {
        public int Id { get; set; }
        public string CinemaName { get; set; }
        public string Address { get; set; }
        public string CityName { get; set; }
        public string CountyName { get; set; }
        public List<ExclusiveLounge> Lounges { get; set; }
        public List<Movie> Movies { get; set; }

    }
}
