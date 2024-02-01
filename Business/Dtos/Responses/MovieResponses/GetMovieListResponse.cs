namespace Business.Dtos.Responses.MovieResponses
{
    public class GetMovieListResponse
    {
        public Guid Id { get; set; }
        public Guid CountryId { get; set; }
        public Guid LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double IMDbRating { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Duration { get; set; }
        public DateTime ProductionYear { get; set; }
    }
}