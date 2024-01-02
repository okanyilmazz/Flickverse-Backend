using Core.Entities;

namespace Entities.Concrete;

public class Country : Entity<Guid>
{
    public string Name { get; set; }
}
