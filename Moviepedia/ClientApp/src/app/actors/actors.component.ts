import { Component, OnInit, ViewChild } from '@angular/core';
import { ActorDTO } from '../shared/models/actor-dto';
import { ActorService } from '../shared/services/actor.service';
import Swal from 'sweetalert2';
import { EditActorModalComponent } from './edit-actor-modal/edit-actor-modal.component';
import { LoaderService } from '../shared/services/loader.service';

@Component({
  selector: 'app-actors',
  templateUrl: './actors.component.html',
  styleUrls: ['./actors.component.css', './loader.component.css']
})
export class ActorsComponent implements OnInit {
  actors: Array<ActorDTO> = new Array<ActorDTO>();
  @ViewChild('editActorModal', { static: false }) editActorModal: EditActorModalComponent;

  constructor(private _actorService: ActorService, public loaderService: LoaderService) { }

  ngOnInit() {
    this.getActors();
  }

  getActors() {
    this._actorService.getActors().subscribe((data: ActorDTO[]) => {
      this.actors = data;
    })
  }

  showEditActorModal(actorId: string): void {
    this.editActorModal.initialize(actorId);
  }

  onEditFinished(event: string) {
    this.getActors();
  }

  deleteActor(actorId: string) {
    Swal.fire({
      title: 'Are you sure?',
      text: "You won't be able to revert this!",
      icon: 'warning',
      showCancelButton: true,
      confirmButtonColor: '#cc99ff',
      cancelButtonColor: '#a64dff',
      confirmButtonText: 'Yes, delete it!'
    }).then((result) => {
      if (result.isConfirmed) {
        this._actorService.deleteActor(actorId).subscribe(() => {
          Swal.fire({
            title: 'Deleted!',
            text: 'Actor has been deleted.',
            icon: 'success',
            confirmButtonColor: '#a64dff'
          }
          )
        });
      }
    })
  }

}
