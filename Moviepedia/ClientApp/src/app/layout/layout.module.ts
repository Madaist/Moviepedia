import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MoviesComponent } from '../movies/movies.component';
import { ActorsComponent } from '../actors/actors.component';
import { MyProfileComponent } from '../my-profile/my-profile.component';
import { RouterModule } from '@angular/router';
import { LayoutRoutes } from './layout.routing';

@NgModule({
  declarations: [
    MoviesComponent,
    ActorsComponent,
    MyProfileComponent
  ],
  imports: [
    CommonModule,
    RouterModule.forChild(LayoutRoutes),
  ]
})
export class LayoutModule { }
