import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { MovieActorsDTO } from '../models/movie-actors-dto';

@Injectable({
  providedIn: 'root'
})
export class MovieActorsService {

  constructor(private http: HttpClient) { }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44355/api/MovieActors';

  addMovieActors(movieActors: MovieActorsDTO) {
    return this.http.post(this.baseUrl, movieActors, { headers: this.header });
  }
}
