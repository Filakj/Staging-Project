import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
//DEV - API Models 
import { Instructor } from '../../Models/instructor';
import { PostInstructor } from '../../Models/post-instructor';

@Injectable({
  providedIn: 'root'
})
export class InstructorService {

  constructor(private httpClient: HttpClient) { }

  InstructorUrl = 'https://localhost:44364/api/Instructor';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getInstructorById(id: string): Promise<Instructor> {
    var completeUrl = `${this.InstructorUrl}/${id}`;
    console.log(completeUrl);
    return this.httpClient.get<Instructor>(completeUrl).toPromise();
  }

  deleteInstructor(id: string): Observable<Instructor> { 
    var completeUrl = `${this.InstructorUrl}/${id}`;
    console.log(completeUrl);
    return this.httpClient.delete<Instructor>(completeUrl, this.httpOptions);
  }


 updateInstructor(updatedInstructor : Instructor): Observable<any> {
  var completeUrl = `${this.InstructorUrl}/${updatedInstructor.id}`;
  console.log(completeUrl);
  return this.httpClient.put(completeUrl, updatedInstructor, this.httpOptions);
 }

 postInstructor(newInstructor: PostInstructor): Observable<Instructor> {
    return this.httpClient.post<Instructor>(this.InstructorUrl, newInstructor, this.httpOptions);
}
}

