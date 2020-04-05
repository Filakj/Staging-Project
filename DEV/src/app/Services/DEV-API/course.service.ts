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

  getCourses(): Observable<any>{
     return this.httpClient.get<Course>(this.courseUrl, this.httpOptions); 
  }

  getCourseById(id: string): Promise<Course> {
    var completeUrl = `${this.courseUrl}/${id}`;
    console.log(completeUrl);
    return this.httpClient.get<Course>(completeUrl).toPromise();
  }

  deleteCourse(id: string): Observable<any>{ 
    var completeUrl = `${this.courseUrl}/${id}`;
    console.log(completeUrl); 
    return this.httpClient.delete<Course>(completeUrl, this.httpOptions);
  }
 updateCourse(updatedCourse: Course): Observable<any>{
   console.log(this.courseUrl);
   return this.httpClient.put<Course>(this.courseUrl, updatedCourse, this.httpOptions);
 }

 postCourse(newCourse: PostCourse): Observable<any> { 
  console.log(this.courseUrl); 
  return this.httpClient.post(this.courseUrl, newCourse,this.httpOptions);
 }


  


}

