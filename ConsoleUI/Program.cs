using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MovieManager movieManager = new MovieManager(new EfMovieDal());
            CastManager castManager = new CastManager(new EfCastDal());
            DirectorManager directorManager = new DirectorManager(new EfDirectorDal());

            Movie movie = new Movie
            {
                CountryId = 1,
                Description = "Güzel bir movie",
                IMDbRating = 5,
                Name = "Moviess",
                LanguageId = 1,
                ProductionYear = DateTime.Now,
                ReleaseDate = DateTime.Now,
                Duration = "02:15:25"
            };

            //movieManager.Add(movie);


           var resultMovieDetails= movieManager.GetAllMovieDetails();
            foreach (var movieDetails in resultMovieDetails)
            {
                Console.WriteLine("Film Adı : {0}", movieDetails.Name);
                Console.WriteLine("Film Açıklaması : {0}", movieDetails.Description);
                Console.WriteLine("Film Süresi : {0}", movieDetails.Duration);
                Console.WriteLine("IMDb Puanı : {0}",movieDetails.IMDbRating);
                Console.WriteLine("Yapım Yılı : {0}",movieDetails.ProductionYear);
                Console.WriteLine("Ülke Adı : {0}",movieDetails.CountryName);
                Console.WriteLine("Vizyon Tarihi : {0}",movieDetails.ReleaseDate);

                foreach (var cast in movieDetails.Casts)
                {
                    Console.WriteLine("Cast :{0} {1} ",cast.FirstName, cast.LastName);
                }

                foreach (var director in movieDetails.Directors)
                {
                    Console.WriteLine("Director : {0} {1} ", director.FirstName, director.LastName);
                    Console.WriteLine("Director Biography :{0} ", director.Biography);

                }

                Console.WriteLine("\n\n");

            }

            var resultDirectorDetails = directorManager.GetDirectorDetails();

            foreach (var directorDetails in resultDirectorDetails)
            {
                Console.WriteLine("Yapımcı Adı : {0} {1}", directorDetails.FirstName,directorDetails.LastName);
                Console.WriteLine("Yapımcı Biografisi : {0}", directorDetails.Biography);
                Console.WriteLine("Yapımcının Ülkesi : {0}", directorDetails.CountryName);
                Console.WriteLine("Yapımcının Doğum Tarihi : {0}", directorDetails.DateOfBirth);
                Console.WriteLine("Yapımcının Filmleri : {0}", directorDetails);

                foreach (var movieDetails in directorDetails.Movies)
                {
                    Console.WriteLine("Yapımcının Filmleri : {0}  ", movieDetails.Name);
                }

            }




        }
    }
}