import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { PostReviewDTO } from '../models/post-review-dto';

@Injectable({
  providedIn: 'root'
})
export class ReviewService {

  constructor(private http: HttpClient) { }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44355/api';

  postReview(review: PostReviewDTO) {
    return this.http.post(this.baseUrl + '/Review', review, { headers: this.header });
  }


}
