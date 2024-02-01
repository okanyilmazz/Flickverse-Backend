using Entities.Concretes;

namespace Entities.DTOs;

public class CinemaHallDetailsDto
{
    public int Id { get; set; }
    public string CinemaName { get; set; }
    public string Address { get; set; }
    public string CityName { get; set; }
    public string CountyName { get; set; }
    public List<ExclusiveLounge> Lounges { get; set; }
    public List<Movie> Movies { get; set; }
}
