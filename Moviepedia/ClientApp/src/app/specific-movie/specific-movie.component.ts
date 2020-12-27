import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { MovieDTO } from '../models/movie-dto';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-specific-movie',
  templateUrl: './specific-movie.component.html',
  styleUrls: ['./specific-movie.component.css']
})
export class SpecificMovieComponent implements OnInit {

  constructor(private route: ActivatedRoute, private api: ApiService) { }

  movie: MovieDTO = new MovieDTO();

  ngOnInit() {
    this.route.params.subscribe(params => {
      //console.log(params);
      //console.log(params['movieId']);
      this.api.getMovie(params['movieId']).subscribe((data: MovieDTO) => {
        this.movie = data;
        console.log(this.movie);
      })
    });
  }

}
