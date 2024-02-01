using Core.Entities;

namespace Entities.Concretes;

public class CinemaHallMovie : Entity<Guid>
{
    public Guid MovieId { get; set; }
    public Guid CinemaHallId { get; set; }

    public Movie Movie { get; set; }
    public CinemaHall CinemaHall { get; set; }
}