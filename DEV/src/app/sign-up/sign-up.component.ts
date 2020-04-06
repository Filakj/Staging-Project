import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormArray, FormControl } from '@angular/forms';

import { StudentService } from '../Services/DEV-API/student.service';

import { PostStudent } from '../Models/post-student'; 
import { Student } from '../Models/student';  

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  registerForm: FormGroup; 

  constructor(
    private studentService: StudentService,
    private fb: FormBuilder,
  ){
  }

  ngOnInit(): void {
    this.registerForm = this.fb.group({
      email: 'TestEmail@Gmail.com',
      //password: '',
      firstname: 'Test',
      lastname: 'Test',
      username: 'Test123'
  });
  }
  
onSubmit(form: FormGroup) {
  console.log('Valid?', form.valid); // true or false
  console.log('Username', form.value.username);
  //console.log('Password', form.value.password);
  console.log('First Name', form.value.firstname);
  console.log('Last Name', form.value.lastname);
  console.log('Email', form.value.email);

  //make account object 
  var newStudent: PostStudent = {
    email: form.value.email, 
    username: form.value.username, 
    firstName: form.value.firstname, 
    lastName: form.value.lastname,  
  }
  console.log(newStudent); 

  this.studentService.postStudent(newStudent).subscribe(
    (data: PostStudent) => {console.log(data);},
    (error: any) => {console.log(error)}
    );
    location.href = "http://localhost:4200/login"
}

}

