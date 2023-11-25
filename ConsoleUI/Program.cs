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
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

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


            var resultMovieDetails = movieManager.GetAllMovieDetails();
            foreach (var movieDetails in resultMovieDetails.Data)
            {
                Console.WriteLine("Film Adı : {0}", movieDetails.Name);
                Console.WriteLine("Film Açıklaması : {0}", movieDetails.Description);
                Console.WriteLine("Film Süresi : {0}", movieDetails.Duration);
                Console.WriteLine("IMDb Puanı : {0}", movieDetails.IMDbRating);
                Console.WriteLine("Yapım Yılı : {0}", movieDetails.ProductionYear);
                Console.WriteLine("Ülke Adı : {0}", movieDetails.CountryName);
                Console.WriteLine("Vizyon Tarihi : {0}", movieDetails.ReleaseDate);

                foreach (var cast in movieDetails.Casts)
                {
                    Console.WriteLine("Cast :{0} {1} ", cast.FirstName, cast.LastName);
                }

                foreach (var director in movieDetails.Directors)
                {
                    Console.WriteLine("Director : {0} {1} ", director.FirstName, director.LastName);
                    Console.WriteLine("Director Biography :{0} ", director.Biography);

                }
                foreach(var image in movieDetails.MovieImages)
                {
                    Console.WriteLine("ImagePath : {0}",image.ImagePath);
                }

                Console.WriteLine("\n\n");

            }

            var resultDirectorDetails = directorManager.GetDirectorDetails();

            foreach (var directorDetails in resultDirectorDetails.Data)
            {
                Console.WriteLine("Yapımcı Adı : {0} {1}", directorDetails.FirstName, directorDetails.LastName);
                Console.WriteLine("Yapımcı Biografisi : {0}", directorDetails.Biography);
                Console.WriteLine("Yapımcının Ülkesi : {0}", directorDetails.CountryName);
                Console.WriteLine("Yapımcının Doğum Tarihi : {0}", directorDetails.DateOfBirth);

                foreach (var movieDetails in directorDetails.Movies)
                {
                    Console.WriteLine("Yapımcının Filmleri : {0}  ", movieDetails.Name);
                }
                foreach (var imageDetails in directorDetails.DirectorImages)
                {
                    Console.WriteLine("ImagePath : " + imageDetails.ImagePath);
                }

                Console.WriteLine("\n");
            }

            //Cast newCast = new Cast
            //{
            //    FirstName = "Zawe",
            //    LastName = "Ashton",
            //    Biography = "İngiliz oyuncu, oyun yazarı ve yönetmendir. Rol aldığı İngiliz televizyon kanalı Channel 4 yapımı komedi-drama türünde yapımlar Not Safe for Work ve Fresh Meat ile bilinir. Ashton'un yer aldığı diğer yapımlar arasında; Blitz, St Trinian's 2: The Legend of Fritton's Gold ile Velvet Buzzsaw vb. sayılabilir.",
            //    CountryId = 230,
            //    DateOfBirth = new DateTime(1984, 07, 21)
            //};


            //List<Cast> newCasts = new List<Cast>
            //{
            //    new Cast
            //    {
            //        FirstName="Samuel Leroy",
            //        LastName="Jackson",
            //        Biography=" Amerikan sinema oyuncusudur.\r\n\r\nUzun yıllar tiyatro sahnelerinde oyunlar oynayan Jackson ününe kırklı yaşlarından sonra kavuştu. Die Hard serisinin üçüncüsünde Bruce Willis'le ve The Long Kiss Godnight'ta Geena Davis'le beraber rol alarak tanındı. Ona sinemada ilk önemli şansı, yönetmen Spike Lee tanımıştır. Do the Right Thing ve Jungle Fever gibi birkaç filminde yardımcı rollerde çok iyi performanslar ortaya koyan Jackson, daha sonra Tarantino'nun kült filmi Pulp Fiction'ında İncil'den ezbere bölümler okuyan gangster Jules karakteriyle Hollywood'un unutulmazları arasına girmiştir. Amerikan film endüstrisindeki, siyahi oyunculara rol vermeme ya da ayak işleri vb. rolleri vermek gibi ön yargıları yıkan ilk siyahi oyunculardandır.",
            //        CountryId=231,
            //        DateOfBirth=new DateTime(1948,12,21)
            //    },
            //    new Cast
            //    {
            //        FirstName="Brie",
            //        LastName="Lerson",
            //        Biography="Brianne Sidonie Desaulniers (d. 1 Ekim 1989, Sacramento), Amerikalı aktris ve film yapımcısıdır. Gençliğinde komedilerde destekleyici çalışmasıyla dikkat çeken oyuncu, o zamandan beri bağımsız dramalar ve film franchise'larında başrollerde oynadı ve Akademi Ödülü ve Altın Küre gibi ödüller aldı. Time dergisinde, 2019'da dünyadaki en etkili 100 kişiden biri seçildi.\r\n\r\nKaliforniya, Sacramento'da doğan Larson evde eğitim gördü. Altı yaşındayken, Amerikan Konservatuvarı Tiyatrosu'nda bir eğitim programına kabul edilen en genç öğrenci oldu. Kısa süre sonra Los Angeles'a taşındı ve 1998 yılında Jay Leno ile The Tonight Show'da bir komedi eskiziyle oyunculuk kariyerine başladı. 2001 sitcom Raising Dad'de düzenli olarak yer aldı ve kısa bir süre sonra müzik kariyeriyle hayatına devam etti. Bu süreçte, Out of P.E. albümünü çıkardı. Larson daha sonra komedi filmleri Hoot (2006), Scott Pilgrim vs.Dünya (2010) ve 21 Jump Street'te (2012) yardımcı rollerde oynamıştır.\r\n\r\nLarson'ın ana akım sinemaya atılımı, beğenilen bağımsız drama Kısa Vadeli 12 (2013) ile gerçekleşti. Room'da (2015) kaçırılan bir kurbanı oynadığı için Larson, En İyi Kadın Oyuncu dalında Akademi Ödülü kazandı. 2017 macera filmi King Kong: Skull Island'da, ilk büyük bütçeli filmde başrol oyuncusu oldu, ardından 2019 Marvel Cinematic Universe süper kahraman filmleri Captain Marvel ve Avengers: Endgame'de Carol Danvers rolünü oynadı.\r\n\r\nLarson ayrıca Sundance Film Festivali'nde jüri özel ödülü alan The Arm (2012) dâhil olmak üzere iki kısa filmi senaristlerle birlikte yazdı ve yönetti. Uzun metrajlı yönetmenlik denemesini 2017 yılında bağımsız komedi-drama Unicorn Store ile yaptı. Cinsiyet eşitliği eylemcisi ve cinsel saldırıdan kurtulanların savunucusu Larson sosyal ve politik konularda aktif bir oyuncudur.",
            //        CountryId=231,
            //        DateOfBirth=new DateTime(1989,10,01)
            //    }
            //};

            //foreach (var cast in newCasts)
            //{
            //    castManager.Add(cast);
            //}

            //castManager.Add(newCast);

            //MovieCast movieCast = new MovieCast
            //{
            //    MovieId = 2,
            //    CastId = 8
            //};
            //MovieCastManager movieCastManager = new MovieCastManager(new EfMovieCastDal());
            //movieCastManager.Add(movieCast);

            //Cast updatedCast = new Cast
            //{
            //    Id = 1003,
            //    FirstName = "Zaweee",
            //    LastName = "Ashton",
            //    Biography = "İngiliz oyuncu, oyun yazarı ve yönetmendir. Rol aldığı İngiliz televizyon kanalı Channel 4 yapımı komedi-drama türünde yapımlar Not Safe for Work ve Fresh Meat ile bilinir. Ashton'un yer aldığı diğer yapımlar arasında; Blitz, St Trinian's 2: The Legend of Fritton's Gold ile Velvet Buzzsaw vb. sayılabilir.",
            //    CountryId = 230,
            //    DateOfBirth = new DateTime(1984, 07, 21)
            //};
            //castManager.Update(updatedCast);

            foreach (var item in castManager.GetCastDetails().Data)
            {
                Console.WriteLine("Cast Adı : {0} {1} " , item.FirstName,item.LastName);
                Console.WriteLine("Cast Ülkesi : {0}",item.CountryName);

                Console.WriteLine("Cast Biyografi : {0} ", item.Biography);

                Console.WriteLine("Cast Doğum Tarihi : {0} ", item.DateOfBirth);

                Console.WriteLine("{0}'nin oynadığı filmler :",item.FirstName);
                foreach (var movieDetails in item.Movies)
                {
                    Console.WriteLine(movieDetails.Name);
                }
                foreach (var imageDetails in item.CastImages)
                {
                    Console.WriteLine("ImagePath : " + imageDetails.ImagePath);
                }
                Console.WriteLine("\n");
            }


            Console.WriteLine("Film Türleri:");

            foreach (var item in categoryManager.GetAll().Data)
            {
                Console.WriteLine(item.Name);
            };
        }
    }
}