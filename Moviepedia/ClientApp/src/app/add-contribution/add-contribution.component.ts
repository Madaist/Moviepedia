import { Component, OnInit, ViewChild } from '@angular/core';
import { AddMovieModalComponent } from './add-movie-modal/add-movie-modal.component';
import { AddActorModalComponent } from './add-actor-modal/add-actor-modal.component';

@Component({
  selector: 'app-add-contribution',
  templateUrl: './add-contribution.component.html',
  styleUrls: ['./add-contribution.component.css']
})
export class AddContributionComponent implements OnInit {
  @ViewChild('addMovieModal', { static: false }) addMovieModal: AddMovieModalComponent;
  @ViewChild('addActorModal', { static: false }) addActorModal: AddActorModalComponent;

  constructor() { }

  ngOnInit() {
  }

  showCreateMovieModal(): void {
    this.addMovieModal.initialize();
  }

  showCreateActorModal(): void {
    this.addActorModal.initialize();
  }

}
