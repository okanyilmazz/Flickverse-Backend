using Core.Entities;

namespace Entities.Concrete;

public class MovieCast : Entity<Guid>
{
    public Guid? MovieId { get; set; }
    public Guid? CastId { get; set; }

    public Movie? Movie { get; set; }
    public Cast? Cast { get; set; }
}
