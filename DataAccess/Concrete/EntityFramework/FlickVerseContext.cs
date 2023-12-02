using Entities.Concrete;
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

        public DbSet<CastImage> CastImages { get; set; }
        public DbSet<Cast> Casts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DirectorImage> DirectorImages { get; set; }
        public DbSet<Director> Directors { get; set; }
        public DbSet<MovieCast> MovieCasts { get; set; }
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieDirector> MovieDirectors { get; set; }
        public DbSet<MovieImage> MovieImages { get; set; }
        public DbSet<Movie> Movies { get; set; }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<CinemaHall> CinemaHalls { get; set; }
        public DbSet<CinemaLounge> CinemaLounges { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<County> Counties { get; set; }
        public DbSet<ExclusiveLounge> ExclusiveLounges { get; set; }
        public DbSet<CinemaMovie> CinemaMovies { get; set; }
        public DbSet<MovieLounge> MovieLounges { get; set; }


    }
}
