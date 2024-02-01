using Core.Entities;

namespace Entities.Concretes;

public class MovieCast : Entity<Guid>
{
    public Guid? MovieId { get; set; }
    public Guid? CastId { get; set; }

    public Movie? Movie { get; set; }
    public Cast? Cast { get; set; }
}
