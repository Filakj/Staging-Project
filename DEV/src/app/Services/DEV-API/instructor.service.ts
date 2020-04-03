import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

//DEV - API Models 
import { Instructor } from '../../Models/instructor';

@Injectable({
  providedIn: 'root'
})
export class InstructorService {

  constructor(private httpClient: HttpClient) { }

  InstructorUrl = 'https://localhost:44364/api/Instructor';
  httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  };

}

