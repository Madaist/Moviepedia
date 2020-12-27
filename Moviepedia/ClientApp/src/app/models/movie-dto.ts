import { Review } from "./review";
import { MovieInfoDTO } from "./movie-info-dto";
import { ActorDTO } from "./actor-dto";

export class MovieDTO {
  id: string;
  title: string;
  picture: string;
  storyLine: string;
  releaseYear: number;
  category: string;
  boxOffice: string;
  reviews: Review[];
  actors: ActorDTO[];
}
