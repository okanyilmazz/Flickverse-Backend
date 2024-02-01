using Core.Entities;

namespace Entities.Concretes;

public class Movie : Entity<Guid>
{
    public Guid? CountryId { get; set; }
    public Guid? LanguageId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double IMDbRating { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Duration { get; set; }
    public DateTime ProductionYear { get; set; }

    public Country? Country { get; set; }
    public Language? Language { get; set; }

    public virtual ICollection<CinemaHallMovie>? CinemaHallMovies { get; set; }
    public virtual ICollection<MovieCast>? MovieCasts { get; set; }
    public virtual ICollection<MovieCategory>? MovieCategories { get; set; }
    public virtual ICollection<MovieDirector>? MovieDirectors { get; set; }
    public virtual ICollection<MovieExclusiveLounge>? MovieExclusiveLounges { get; set; }
    public virtual ICollection<MovieImage>? MovieImages { get; set; }
}
