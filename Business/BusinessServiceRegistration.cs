using Business.Abstract;
using Business.Concrete;
using Core.Business.Rules;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business;

public static class BusinessServiceRegistration
{
    public static IServiceCollection AddBusinessServices(this IServiceCollection services)
    {
        services.AddScoped<IAddressService, AddressManager>();
        services.AddScoped<ICastService, CastManager>();
        services.AddScoped<ICastImageService, CastImageManager>();
        services.AddScoped<ICategoryService, CategoryManager>();
        services.AddScoped<ICinemaHallService, CinemaHallManager>();
        services.AddScoped<ICinemaHallExclusiveLoungeService, CinemaHallExclusiveLoungeManager>();
        services.AddScoped<ICinemaHallMovieService, CinemaHallMovieManager>();
        services.AddScoped<ICityService, CityManager>();
        services.AddScoped<ICountryService, CountryManager>();
        services.AddScoped<IDirectorService, DirectorManager>();
        services.AddScoped<IDirectorImageService, DirectorImageManager>();
        services.AddScoped<IDistrictService, DistrictManager>();
        services.AddScoped<IExclusiveLoungeService, ExclusiveLoungeManager>();
        services.AddScoped<ILanguageService, LanguageManager>();
        services.AddScoped<IMovieService, MovieManager>();
        services.AddScoped<IMovieCastService, MovieCastManager>();
        services.AddScoped<IMovieCategoryService, MovieCategoryManager>();
        services.AddScoped<IMovieDirectorService, MovieDirectorManager>();
        services.AddScoped<IMovieExclusiveLoungeService, MovieExclusiveLoungeManager>();
        services.AddScoped<IMovieImageService, MovieImageManager>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
        return services;
    }

    public static IServiceCollection AddSubClassesOfType(this IServiceCollection services, Assembly assembly, Type type, Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (var item in types)
            if (addWithLifeCycle == null)
                services.AddScoped(item);
            else
                addWithLifeCycle(services, type);
        return services;
    }
}