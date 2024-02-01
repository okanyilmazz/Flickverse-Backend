using Core.Entities;

namespace Entities.Concretes;

public class Language : Entity<Guid>
{
    public string Name { get; set; }
}
