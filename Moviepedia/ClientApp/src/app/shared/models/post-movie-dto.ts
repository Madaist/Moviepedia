export class PostMovieDTO {
  id: string;
  title: string;
  picture: string;
  storyLine: string;
  releaseYear: number;
  category: string;
  boxOffice: string;

  constructor(id?: string, title?: string, picture?: string, storyLine?: string, releaseYear?: number, category?: string, boxOffice?: string) {
    this.id = id;
    this.title = title;
    this.picture = picture;
    this.storyLine = storyLine;
    this.releaseYear = releaseYear;
    this.category = category;
    this.boxOffice = boxOffice;
  }
}
