﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class MovieImage : IEntity
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string ImagePath { get; set; }
    }
}
