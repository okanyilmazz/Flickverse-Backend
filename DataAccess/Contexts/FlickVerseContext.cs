using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace DataAccess.Contexts;

public class FlickVerseContext : DbContext
{
    protected IConfiguration Configuration { get; set; }


    public DbSet<Address> Addresses { get; set; }
    public DbSet<Cast> Casts { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<ExclusiveLounge> ExclusiveLounges { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<Movie> Movies { get; set; }


    public FlickVerseContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}