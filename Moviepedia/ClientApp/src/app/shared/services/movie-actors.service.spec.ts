import { TestBed } from '@angular/core/testing';

import { MovieActorsService } from './movie-actors.service';

describe('MovieActorsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: MovieActorsService = TestBed.get(MovieActorsService);
    expect(service).toBeTruthy();
  });
});
