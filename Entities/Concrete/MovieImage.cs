using Core.Entities;

namespace Entities.Concrete;

public class MovieImage : Entity<Guid>
{
    public Guid MovieId { get; set; }
    public string ImagePath { get; set; }

    public Movie Movie { get; set; }
}