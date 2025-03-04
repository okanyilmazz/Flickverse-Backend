﻿namespace Business.Dtos.Requests.CastRequests;

public class UpdateCastRequest
{
    public Guid Id { get; set; }
    public Guid CountryId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Biography { get; set; }
    public DateTime DateOfBirth { get; set; }
}