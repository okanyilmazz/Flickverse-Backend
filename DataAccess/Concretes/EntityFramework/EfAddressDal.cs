﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concretes;

namespace DataAccess.Concretes.EntityFramework;

public class EfAddressDal : EfRepositoryBase<Address, Guid, FlickVerseContext>, IAddressDal
{
    public EfAddressDal(FlickVerseContext context) : base(context)
    {
    }
}
