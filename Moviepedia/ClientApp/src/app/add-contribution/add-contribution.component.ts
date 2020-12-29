import { Component, OnInit, ViewChild } from '@angular/core';
import { AddMovieModalComponent } from './add-movie-modal/add-movie-modal.component';

@Component({
  selector: 'app-add-contribution',
  templateUrl: './add-contribution.component.html',
  styleUrls: ['./add-contribution.component.css']
})
export class AddContributionComponent implements OnInit {
  @ViewChild('addMovieModal', { static: false }) addMovieModal: AddMovieModalComponent;

  constructor() { }

  ngOnInit() {
  }

  showCreateMovieModal(): void {
    this.addMovieModal.initialize();
  }

}
