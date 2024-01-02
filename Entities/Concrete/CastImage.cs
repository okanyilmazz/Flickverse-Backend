using Core.Entities;

namespace Entities.Concrete;

public class CastImage : Entity<Guid>
{
    public Guid CastId { get; set; }
    public string ImagePath { get; set; }

    public Cast Cast { get; set; }
}