﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfMovieExclusiveLoungeDal : EfRepositoryBase<MovieExclusiveLounge, Guid, FlickVerseContext>, IMovieExclusiveLoungeDal
{
    public EfMovieExclusiveLoungeDal(FlickVerseContext context) : base(context)
    {
    }
}