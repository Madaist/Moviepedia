import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { UpdateMovieDTO } from '../models/update-movie-dto';
import { PostMovieDTO } from '../models/post-movie-dto';

@Injectable({
  providedIn: 'root'
})
export class MovieService {
  constructor(private http: HttpClient) { }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44355/api';

  getMovies() {
    return this.http.get(this.baseUrl + '/Movie', { headers: this.header });
  }

  getMovie(movieId : string) {
    return this.http.get(this.baseUrl + '/Movie/' + movieId, {headers: this.header});
  }

  deleteMovie(movieId: string) {
    return this.http.delete(this.baseUrl + '/Movie/' + movieId, { headers: this.header });
  }

  updateMovie(movie: UpdateMovieDTO) {
    return this.http.put(this.baseUrl + '/Movie', movie, { headers: this.header });
  }

  createMovie(movie: PostMovieDTO) {
    return this.http.post(this.baseUrl + '/Movie', movie, { headers: this.header });
  }
}
