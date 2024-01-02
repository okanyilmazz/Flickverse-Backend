using Core.Entities;

namespace Entities.Concrete;

public class MovieCategory : Entity<Guid>
{
    public Guid? MovieId { get; set; }
    public Guid? CategoryId { get; set; }

    public Movie? Movie { get; set; }
    public Category? Category { get; set; }
}