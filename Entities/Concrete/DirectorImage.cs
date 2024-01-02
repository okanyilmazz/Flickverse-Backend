using Core.Entities;

namespace Entities.Concrete;

public class DirectorImage : Entity<Guid>
{
    public Guid DirectorId { get; set; }
    public string ImagePath { get; set; }

    public Director Director { get; set; }
}