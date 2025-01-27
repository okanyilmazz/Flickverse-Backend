﻿using Core.Entities;

namespace Entities.Concretes;

public class MovieDirector : Entity<Guid>
{
    public Guid? MovieId { get; set; }
    public Guid? DirectorId { get; set; }

    public Movie? Movie { get; set; }
    public Director? Director { get; set; }
}