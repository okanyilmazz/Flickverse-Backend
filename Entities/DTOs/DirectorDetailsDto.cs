using Entities.Concretes;

namespace Entities.DTOs;

public class DirectorDetailsDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Biography { get; set; }
    public string CountryName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public List<Movie> Movies { get; set; }
    public List<DirectorImage> DirectorImages { get; set; }

}
