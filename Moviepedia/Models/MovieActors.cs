namespace Moviepedia.Models
{
    public class MovieActors
    {
        public string Id { get; set; }
        public string ActorId { get; set; }
        public string MovieId { get; set; }
        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
