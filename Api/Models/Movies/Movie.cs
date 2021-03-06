using Api.Models.Directors;

namespace Api.Models.Movies
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }
        public long DirectorId { get; set; }
        public Director Director { get; set; }
    }
}