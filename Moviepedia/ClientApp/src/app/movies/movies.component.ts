import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';
import { MovieDTO } from '../models/movie-dto';

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {
  movies: Array<MovieDTO> = new Array<MovieDTO>();
  searchText: string;
  constructor(private api: ApiService) { }

  ngOnInit() {
    this.api.getMovies().subscribe((data: MovieDTO[]) => {
      this.movies = data;
      console.log(this.movies);
    })
  }

}
