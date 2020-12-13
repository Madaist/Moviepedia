namespace Moviepedia.Models
{
    public class Review
    {
        public string Id { get; set; }
        public string MovieId { get; set; }
        public string UserId { get; set; }
        public string Content { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual ApplicationUser User { get; set; }

    }
}
