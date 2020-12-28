import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MoviesComponent } from '../movies/movies.component';
import { ActorsComponent } from '../actors/actors.component';
import { MyProfileComponent } from '../my-profile/my-profile.component';
import { RouterModule } from '@angular/router';
import { LayoutRoutes } from './layout.routing';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatRippleModule } from '@angular/material/core';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatTooltipModule } from '@angular/material/tooltip';
import { MatSelectModule } from '@angular/material/select';
import { IvyCarouselModule } from 'angular-responsive-carousel';
import { SearchPipe } from '../shared/search.pipe';
import { SpecificMovieComponent } from '../specific-movie/specific-movie.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { AddReviewModalComponent } from '../specific-movie/add-review-modal/add-review-modal.component';
import { EditMovieModalComponent } from '../specific-movie/edit-movie-modal/edit-movie-modal.component';

@NgModule({
  declarations: [
    MoviesComponent,
    ActorsComponent,
    MyProfileComponent,
    SearchPipe,
    SpecificMovieComponent,
    AddReviewModalComponent,
    EditMovieModalComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(LayoutRoutes),
    FormsModule,
    ReactiveFormsModule,
    MatButtonModule,
    MatRippleModule,
    MatFormFieldModule,
    MatInputModule,
    MatSelectModule,
    MatTooltipModule,
    IvyCarouselModule,
    ModalModule.forRoot()
  ]
})
export class LayoutModule { }
