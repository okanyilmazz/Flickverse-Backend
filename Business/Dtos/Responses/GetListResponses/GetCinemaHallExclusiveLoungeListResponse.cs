﻿namespace Business.Dtos.Responses.GetListResponses
{
    public class GetCinemaHallExclusiveLoungeListResponse
    {
        public Guid Id { get; set; }
        public Guid CinemaHallId { get; set; }
        public Guid ExclusiveLoungeId { get; set; }
    }
}