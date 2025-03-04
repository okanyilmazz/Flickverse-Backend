﻿using Core.Entities;

namespace Entities.Concretes;

public class MovieExclusiveLounge : Entity<Guid>
{
    public Guid MovieId { get; set; }
    public Guid ExclusiveLoungeId { get; set; }

    public Movie Movie { get; set; }
    public ExclusiveLounge ExclusiveLounge { get; set; }
}
