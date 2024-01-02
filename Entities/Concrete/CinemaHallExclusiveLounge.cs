using Core.Entities;

namespace Entities.Concrete;

public class CinemaHallExclusiveLounge : Entity<Guid>
{
    public Guid CinemaHallId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }

    public CinemaHall CinemaHall { get; set; }
    public ExclusiveLounge ExclusiveLounge { get; set; }
}
