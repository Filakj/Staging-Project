import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

import { Registration } from '../../Models/registration';
import { PostRegistration } from '../../Models/post-registration';


@Injectable({
  providedIn: 'root'
})
export class RegistrationService {

  constructor(private httpClient: HttpClient) { }

  RegistrationUrl = 'https://localhost:44364/api/Registration';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getRegistrationById(id: string): Observable<any>{ 
    var completeUrl = `${this.RegistrationUrl}/${id}`;
    console.log(completeUrl); 
    return this.httpClient.get(completeUrl, this.httpOptions);
  }

  deleteRegistration(id: string):Observable<any>{
    var completeUrl = `${this.RegistrationUrl}/${id}`;
    console.log(completeUrl); 
    return this.httpClient.delete(completeUrl, this.httpOptions);

  }

  postRegistration(newRegistration: PostRegistration):Observable<any>{
    console.log(this.RegistrationUrl);
    return this.httpClient.post(this.RegistrationUrl, this.httpOptions);
  }

  getRegistrationsByCourseId(courseId: string):Observable<any>{ 
    var completeUrl = `${this.RegistrationUrl}/Course/${courseId}`;
    console.log(completeUrl);
    return this.httpClient.post(completeUrl, this.httpOptions); 
  }

  getRegistrationByStudentId(studentId: string):Observable<any>{ 
    var completeUrl = `${this.RegistrationUrl}/Student/${studentId}`;
    console.log(completeUrl);
    return this.httpClient.post(completeUrl, this.httpOptions); 
  }
  
}
