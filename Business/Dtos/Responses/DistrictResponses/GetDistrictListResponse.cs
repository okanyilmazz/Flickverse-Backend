﻿namespace Business.Dtos.Responses.DistrictResponses
{
    public class GetDistrictListResponse
    {
        public Guid Id { get; set; }
        public Guid CityId { get; set; }
        public string Name { get; set; }
    }
}