export class MovieActorsDTO {
  movieId: string;
  actorId: string;

  constructor(movieId?: string, actorId?: string) {
    this.movieId = movieId;
    this.actorId = actorId;
  }
}
