using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace DataAccess;

public static class DataAccessServiceRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<FlickVerseContext>(options => options.UseSqlServer(configuration.GetConnectionString("FlickVerseContext")));


        services.AddScoped<IAddressDal,EfAddressDal>();
        services.AddScoped<ICastDal, EfCastDal>();
        services.AddScoped<ICastImageDal, EfCastImageDal>();
        services.AddScoped<ICategoryDal, EfCategoryDal>();
        services.AddScoped<ICinemaHallDal, EfCinemaHallDal>();
        services.AddScoped<ICinemaHallExclusiveLoungeDal, EfCinemaHallExclusiveLoungeDal>();
        services.AddScoped<ICinemaHallMovieDal, EfCinemaHallMovieDal>();
        services.AddScoped<ICityDal, EfCityDal>();
        services.AddScoped<ICountryDal, EfCountryDal>();
        services.AddScoped<IDirectorDal, EfDirectorDal>();
        services.AddScoped<IDirectorImageDal, EfDirectorImageDal>();
        services.AddScoped<IDistrictDal, EfDistrictDal>();
        services.AddScoped<IExclusiveLoungeDal, EfExclusiveLoungeDal>();
        services.AddScoped<ILanguageDal, EfLanguageDal>();
        services.AddScoped<IMovieDal, EfMovieDal>();
        services.AddScoped<IMovieCastDal, EfMovieCastDal>();
        services.AddScoped<IMovieCategoryDal, EfMovieCategoryDal>();
        services.AddScoped<IMovieDirectorDal, EfMovieDirectorDal>();
        services.AddScoped<IMovieExclusiveLoungeDal, EfMovieExclusiveLoungeDal>();
        services.AddScoped<IMovieImageDal, EfMovieImageDal>();

        return services;
    }
}