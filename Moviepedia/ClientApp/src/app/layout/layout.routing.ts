import { Routes } from '@angular/router';
import { LayoutComponent } from './layout.component';
import { AuthorizeGuard } from '../../api-authorization/authorize.guard';
import { MoviesComponent } from '../movies/movies.component';
import { MyProfileComponent } from '../my-profile/my-profile.component';
import { ActorsComponent } from '../actors/actors.component';
import { SpecificMovieComponent } from '../specific-movie/specific-movie.component';
import { AddContributionComponent } from '../add-contribution/add-contribution.component';

export const LayoutRoutes: Routes = [
  {
    path: 'home', component: LayoutComponent, canActivate: [AuthorizeGuard], children: [
      { path: '', redirectTo: 'movies', pathMatch: 'full' },
      { path: 'movies', component: MoviesComponent },
      { path: 'contribution', component: AddContributionComponent },
      { path: 'actors', component: ActorsComponent },
      { path: 'title/:movieId', component: SpecificMovieComponent },
    ]
  }
];
