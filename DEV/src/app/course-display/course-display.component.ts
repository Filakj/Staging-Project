import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { CourseService } from '../Services/DEV-API/course.service';
import { TaskService } from '../Services/DEV-API/task.service';

import { Course } from '../Models/course';  
import { Task} from '../Models/task';  

@Component({
  selector: 'app-course-display',
  templateUrl: './course-display.component.html',
  styleUrls: ['./course-display.component.css']
})
export class CourseDisplayComponent implements OnInit {

  courseId: string; 
  currentCourse: Course; 
  courseTasks: Task[]; 

  constructor( 
    private route: ActivatedRoute, 
    private location: Location,
    private taskService: TaskService,
    private courseService: CourseService,
  ) { 

  }

  ngOnInit(): void {
    this.courseId = this.route.snapshot.params.get('id');
    console.log(this.courseId);
    this.getCourseInfo(this.courseId); 
    this.getTasks(); 
  }

  getCourseInfo(courseId: string){ 
    this.courseService.getCourseById(courseId)
    .then(Response => this.currentCourse = Response); 
  }

  getTasks(){ 
    this.taskService.getTaskByCourse(this.courseId).toPromise()
    .then(Response => this.courseTasks = Response); 
  }
}
