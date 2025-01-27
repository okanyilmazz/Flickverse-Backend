﻿namespace Business.Dtos.Responses.DirectorResponses
{
    public class GetDirectorListResponse
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Biography { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}