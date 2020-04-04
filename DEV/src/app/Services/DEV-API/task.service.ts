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

  TaslUrl = 'https://localhost:44364/api/Task';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

}

