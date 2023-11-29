
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract.EntityFramework;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddSingleton<IMovieService, MovieManager>();
            builder.Services.AddSingleton<IMovieDal, EfMovieDal>();

            builder.Services.AddSingleton<IDirectorService, DirectorManager>();
            builder.Services.AddSingleton<IDirectorDal, EfDirectorDal>();

            builder.Services.AddSingleton<ICastService, CastManager>();
            builder.Services.AddSingleton<ICastDal, EfCastDal>();

            builder.Services.AddSingleton<ICastImageService, CastImageManager>();
            builder.Services.AddSingleton<ICastImageDal, EfCastImageDal>();

            builder.Services.AddSingleton<ICategoryService, CategoryManager>();
            builder.Services.AddSingleton<ICategoryDal, EfCategoryDal>();

            builder.Services.AddSingleton<ICountryService, CountryManager>();
            builder.Services.AddSingleton<ICountryDal, EfCountryDal>();

            builder.Services.AddSingleton<IDirectorImageService, DirectorImageManager>();
            builder.Services.AddSingleton<IDirectorImageDal, EfDirectorImageDal>();

            builder.Services.AddSingleton<IMovieCastService, MovieCastManager>();
            builder.Services.AddSingleton<IMovieCastDal, EfMovieCastDal>();

            builder.Services.AddSingleton<IMovieCategoryService, MovieCategoryManager>();
            builder.Services.AddSingleton<IMovieCategoryDal, EfMovieCategoryDal>();

            builder.Services.AddSingleton<IMovieDirectorService, MovieDirectorManager>();
            builder.Services.AddSingleton<IMovieDirectorDal, EfMovieDirectorDal>();

            builder.Services.AddSingleton<IMovieImageService, MovieImageManager>();
            builder.Services.AddSingleton<IMovieImageDal, EfMovieImageDal>();



            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}