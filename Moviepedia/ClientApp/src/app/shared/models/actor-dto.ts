import { last } from "rxjs/operators";

export class ActorDTO {
  id: string;
  lastName: string;
  firstName: string;
  age: number;
  picture: string;

  constructor(lastName?: string, firstName?: string, age?: number, picture?: string) {
    this.lastName = lastName;
    this.firstName = firstName;
    this.age = age;
    this.picture = picture;
  }
}
