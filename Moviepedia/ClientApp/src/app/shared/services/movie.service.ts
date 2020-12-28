import { Injectable } from '@angular/core';
import { HttpHeaders, HttpClient } from '@angular/common/http';

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

 
}
