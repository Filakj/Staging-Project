import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

//DEV - API Models 
import { Course } from '../../Models/course';
import { PostCourse } from '../../Models/post-course';


@Injectable({
  providedIn: 'root'
})
export class CourseService {

  constructor(private httpClient: HttpClient) { }
  
  courseUrl = 'https://localhost:44364/api/Course';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getStudentById(id: string): Promise<Course> {
    var completeUrl = `${this.courseUrl}/${id}`;
    console.log(completeUrl);
    return this.httpClient.get<Course>(completeUrl).toPromise();
  }

  deleteStudent(id: string){ 
    var completeUrl = `${this.courseUrl}/${id}`;

  }


 updateStudent(){ 

 }

 postStudent(){ 

 }


  


}

