namespace Moviepedia.DTOs
{
    public class UpdateMovieDTO
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Picture { get; set; }
        public string StoryLine { get; set; }
        public int ReleaseYear { get; set; }
        public string Category { get; set; }
        public string BoxOffice { get; set; }
    }
}
