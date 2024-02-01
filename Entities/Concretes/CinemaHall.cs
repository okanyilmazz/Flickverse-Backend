using Core.Entities;

namespace Entities.Concretes;

public class CinemaHall : Entity<Guid>
{
    public Guid AddressId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Address Address { get; set; }
    public virtual ICollection<CinemaHallExclusiveLounge> CinemaHallExclusiveLounges { get; set; }
    public virtual ICollection<CinemaHallMovie> CinemaHallMovies { get; set; }

}
