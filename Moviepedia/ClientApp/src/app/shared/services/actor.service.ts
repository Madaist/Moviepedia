import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { ActorDTO } from '../models/actor-dto';

@Injectable({
  providedIn: 'root'
})
export class ActorService {

  constructor(private http: HttpClient) { }

  header = new HttpHeaders({
    'Content-Type': 'application/json',
    'Access-Control-Allow-Origin': '*'
  });
  baseUrl = 'https://localhost:44355/api/Actor';

  addActor(actor: ActorDTO) {
    return this.http.post(this.baseUrl, actor, { headers: this.header });
  }

  getActors() {
    return this.http.get(this.baseUrl, { headers: this.header });
  }

  getActor(actorId: string) {
    return this.http.get(this.baseUrl + '/' + actorId, { headers: this.header });
  }

  deleteActor(actorId: string) {
    return this.http.delete(this.baseUrl + '/' + actorId, { headers: this.header });
  }

  updateActor(actorDTO: ActorDTO) {
    return this.http.put(this.baseUrl, actorDTO, { headers: this.header });
  }

}
