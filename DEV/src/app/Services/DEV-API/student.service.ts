import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

//DEV - API Models 
import { Student } from '../../Models/student';
import { PostStudent } from '../../Models/post-student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private httpClient: HttpClient) { }

  StudentUrl = 'https://localhost:44364/api/Student';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getStudentById(id: string): Promise<Student> {
    var completeUrl = `${this.StudentUrl}/${id}`;
    console.log(completeUrl);
    return this.httpClient.get<Student>(completeUrl).toPromise();
  }

  deleteStudent(id: string): Observable<Student> { 
    var completeUrl = `${this.StudentUrl}/${id}`;
    console.log(completeUrl);
    return this.httpClient.delete<Student>(completeUrl, this.httpOptions);
  }


 updateStudent(updatedStudent : Student): Observable<any> {
  var completeUrl = `${this.StudentUrl}/${updatedStudent.id}`;
  console.log(completeUrl);
  return this.httpClient.put(completeUrl, updatedStudent, this.httpOptions);
 }

 postStudent(newStudent: PostStudent): Observable<Student> {
    return this.httpClient.post<Student>(this.StudentUrl, newStudent, this.httpOptions);
}

}

