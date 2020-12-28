import { ActorDTO } from "./actor-dto";
import { Review } from "./review";

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
