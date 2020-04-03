import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

//DEV - API Models 
import { Student } from '../../Models/student';

@Injectable({
  providedIn: 'root'
})
export class StudentService {

  constructor(private httpClient: HttpClient) { }

  StudentUrl = 'https://localhost:44364/api/Student';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

}

