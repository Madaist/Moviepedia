import { Component, OnInit } from '@angular/core';
import { MovieService } from '../shared/services/movie.service';
import { MovieDTO } from '../shared/models/movie-dto';
import { LoaderService } from '../shared/services/loader.service';


@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css', './loader.component.css']
})
export class MoviesComponent implements OnInit {
  movies: Array<MovieDTO> = new Array<MovieDTO>();
  searchText: string;
  constructor(private movieService: MovieService, public loaderService: LoaderService) { }

  ngOnInit() {
    this.movieService.getMovies().subscribe((data: MovieDTO[]) => {
      this.movies = data;
      console.log(this.movies);
    })
  }

}
