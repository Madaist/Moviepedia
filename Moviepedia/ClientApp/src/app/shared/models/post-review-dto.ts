export class PostReviewDTO {
  movieId: string;
  content: string;

  constructor(movieId?: string, content?: string) {
    this.movieId = movieId;
    this.content = content;
  }
}
