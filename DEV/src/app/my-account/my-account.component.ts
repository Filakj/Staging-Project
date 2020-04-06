import { Component, OnInit } from '@angular/core';

import { StudentService } from '../Services/DEV-API/student.service';
import { Student } from '../Models/student';  

@Component({
  selector: 'app-my-account',
  templateUrl: './my-account.component.html',
  styleUrls: ['./my-account.component.css']
})
export class MyAccountComponent implements OnInit {

  currentStudent: Student 

  constructor(
    private studentService: StudentService,
  ) { }

  ngOnInit(): void {
    this.getAccountInfo(); 
    
  }
  getAccountInfo(){ 
    var sID = localStorage.getItem('Student Id');
    this.studentService.getStudentById(sID) 
    .then(response => this.currentStudent = response); 
  }

}
