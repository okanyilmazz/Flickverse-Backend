using Core.Entities;

namespace Entities.Concrete;

public class ExclusiveLounge : Entity<Guid>
{
    public string Name { get; set; }
    public string Description { get; set; }

    public virtual ICollection<CinemaHallExclusiveLounge> CinemaHallExclusiveLounges { get; set; }
    public virtual ICollection<MovieExclusiveLounge> MovieExclusiveLounges { get; set; }
}
