﻿namespace Business.Dtos.Responses.MovieDirectorResponses;

public class DeletedMovieDirectorResponse
{
    public Guid Id { get; set; }
    public Guid MovieId { get; set; }
    public Guid DirectorId { get; set; }
}