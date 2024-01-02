﻿using Core.Entities;

namespace Entities.Concrete;

public class District : Entity<Guid>
{
    public Guid CityId { get; set; }
    public string Name { get; set; }

    public City City { get; set; }
}