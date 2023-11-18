using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
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
            MovieManager movieManager = new MovieManager(new EfMovieDal());
            //movieManager.Add(movie);

           var result= movieManager.GetAllCarDetail();

            foreach (var item in result)
            {
                Console.WriteLine("Film Adı : {0}",item.Name);
                Console.WriteLine("Film Açıklaması : {0}",item.Description);
                Console.WriteLine("Film Süresi : {0}",item.Duration);
                Console.WriteLine("IMDb Puanı : {0}",item.IMDbRating);
                Console.WriteLine("Yapım Yılı : {0}",item.ProductionYear);
                Console.WriteLine("Ülke Adı : {0}",item.CountryName);
                Console.WriteLine("Vizyon Tarihi : {0}",item.ReleaseDate);

                Console.WriteLine("\n\n");

            }

        }
    }
}