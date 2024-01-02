using Core.Entities;

namespace Entities.Concrete;

public class Language : Entity<Guid>
{
    public string Name { get; set; }
}
