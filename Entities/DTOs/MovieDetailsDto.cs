﻿using Entities.Concretes;

namespace Entities.DTOs;

public class MovieDetailsDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public double IMDbRating { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Duration { get; set; }
    public DateTime ProductionYear { get; set; }
    public string CountryName { get; set; }
    public List<Cast> Casts { get; set; }
    public List<Director> Directors { get; set; }
    public List<MovieImage> MovieImages { get; set; }
}
