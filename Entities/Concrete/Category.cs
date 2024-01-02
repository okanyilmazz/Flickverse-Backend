using Core.Entities;

namespace Entities.Concrete;

public class Category : Entity<Guid>
{
    public string Name { get; set; }

    public virtual ICollection<MovieCategory> MovieCategories { get; set; }
}
