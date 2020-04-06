import { Component, OnInit } from '@angular/core';

import { RegistrationService } from '../Services/DEV-API/registration.service';
import { CourseService } from '../Services/DEV-API/course.service';

import { Course } from '../Models/course';  
import { Registration } from '../Models/registration';  


@Component({
  selector: 'app-allcourses',
  templateUrl: './allcourses.component.html',
  styleUrls: ['./allcourses.component.css']
})
export class AllcoursesComponent implements OnInit {

  courses: Course[]
  courseIDs: string[] 
  registrations: Registration[]

  constructor(
    private registrationService: RegistrationService,
    private courseService: CourseService,
  ) { }

  ngOnInit(): void {
    this.getStudentRegistrations(); 
  }

  getStudentRegistrations():void{ 
    console.log('STUDENT ID'); 
    var sID = localStorage.getItem('Student Id');
    console.log(sID); 

    this.registrationService.getRegistrationByStudentId(sID)
    .then(Response => this.registrations);   
  
  }
  
}
