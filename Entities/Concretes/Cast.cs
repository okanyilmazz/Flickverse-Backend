using Core.Entities;

namespace Entities.Concretes;

public class Cast : Entity<Guid>
{
    public Guid? CountryId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Biography { get; set; }
    public DateTime DateOfBirth { get; set; }

    public Country? Country { get; set; }
    public virtual ICollection<MovieCast>? MovieCasts { get; set; }
}
