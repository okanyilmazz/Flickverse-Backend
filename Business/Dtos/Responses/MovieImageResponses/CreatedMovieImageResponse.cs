﻿namespace Business.Dtos.Responses.MovieImageResponses;

public class CreatedMovieImageResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public string ImagePath { get; set; }
}