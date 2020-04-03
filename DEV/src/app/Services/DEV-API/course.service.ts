import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';


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


}

