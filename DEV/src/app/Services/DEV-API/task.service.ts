import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';

//DEV - API Models 
import { Task } from '../../Models/task';
import { PostTask } from '../../Models/post-task';

@Injectable({
  providedIn: 'root'
})
export class TaskService {

  constructor(private httpClient: HttpClient) { }

  TaskUrl = 'https://localhost:44364/api/Task';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

  getTaskById(id: string): Observable<any>{
    var completeUrl = `${this.TaskUrl}/${id}`;
    console.log(this.TaskUrl); 
    return this.httpClient.get(completeUrl,this.httpOptions); 
  }

  updateTask(updatedTask: Task): Observable<any>{
    var completeUrl = `${this.TaskUrl}/${updatedTask.id}`;
    console.log(completeUrl); 
    return this.httpClient.put(completeUrl, updatedTask,this.httpOptions); 
  }

  deleteTask(id: string){ 
    var completeUrl = `${this.TaskUrl}/${id}`;
    console.log(completeUrl); 
    return this.httpClient.delete(completeUrl, this.httpOptions);
  }

  postTask():Observable<any>{ 
    console.log(this.TaskUrl);
    return this.httpClient.post(this.TaskUrl, this.httpOptions); 
  }

  getTaskByCourse(courseId: string): Observable<any>{ 
    var completeUrl = `${this.TaskUrl}/Course/${courseId}`;
    console.log(completeUrl);
    return this.httpClient.get(completeUrl, this.httpOptions);
  }


}

