﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
   public interface IMovieCastService
    {
        List<MovieCast> GetAll();
        MovieCast GetById(int id);
        void Add(MovieCast movieCast);
        void Update(MovieCast movieCast);
        void Delete(MovieCast movieCast);
    }
}