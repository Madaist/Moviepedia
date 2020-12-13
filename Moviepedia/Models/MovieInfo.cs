namespace Moviepedia.Models
{
    public class MovieInfo
    {
        public string Id { get; set; }
        public string StoryLine { get; set; }
        public int ReleaseYear { get; set; }
        public string Category { get; set; }
        public string BoxOffice { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
