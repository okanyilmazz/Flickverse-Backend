﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICastService
    {
        List<Cast> GetAll();
        Cast GetById(int id);
        void Add(Cast cast);
        void Update(Cast cast);
        void Delete(Cast cast);
    }
}
