﻿using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class FlickVerseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=FlickVerse;Trusted_Connection=true");
        }

        public DbSet<Cast> Casts { get; set; }
        public DbSet<CastImage> CastImages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<DirectorImage> DirectorImages { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieImage> MovieImages { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
    }
}
