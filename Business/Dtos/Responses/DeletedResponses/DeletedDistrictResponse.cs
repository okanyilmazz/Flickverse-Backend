﻿
namespace Business.Dtos.Responses.DeletedResponses;

public class DeletedDistrictResponse
{
    public Guid Id { get; set; }
    public Guid CityId { get; set; }
    public string Name { get; set; }
}
