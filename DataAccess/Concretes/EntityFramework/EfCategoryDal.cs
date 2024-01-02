﻿using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities.Concrete;

namespace DataAccess.Concretes.EntityFramework;

public class EfCategoryDal : EfRepositoryBase<Category, Guid, FlickVerseContext>, ICategoryDal
{
    public EfCategoryDal(FlickVerseContext context) : base(context)
    {
    }
}
