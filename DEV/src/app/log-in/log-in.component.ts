import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl } from '@angular/forms';

import { StudentService } from '../Services/DEV-API/student.service';

import { PostStudent } from '../Models/post-student'; 
import { Student } from '../Models/student';  

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {

  loginForm: FormGroup; 
  currentStudent: Student = null; 

  constructor(    
    private studentService: StudentService,
    private fb: FormBuilder,) 
    {}

  ngOnInit(): void {
    this.loginForm = this.fb.group({
      email: '', 
      password: '',
  });
  }
  
  onSubmit(form: FormGroup) {
    console.log('Valid?', form.valid); // true or false
    console.log('Email', form.value.email);
    var email = form.value.email
    this.login(email); 
  } 

  login(e: string): void{ 
    this.studentService.getStudentByEmail(e) 
      .then(response => this.currentStudent = response); 
      
      alert("Welcome " + this.currentStudent.firstName + " " + this.currentStudent.lastName);

      localStorage.setItem("Student Id",this.currentStudent.id.toString()); 
      localStorage.setItem("First Name", this.currentStudent.firstName);
      localStorage.setItem("Last Name", this.currentStudent.lastName);
      localStorage.setItem("Role", "student");
      alert(localStorage.getItem("Student Id"));
      location.href = "http://localhost:4200/"
  }


    



}
