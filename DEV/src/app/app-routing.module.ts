import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { SignUpComponent } from './sign-up/sign-up.component';
import { LogInComponent } from './log-in/log-in.component';
import { CourseDisplayComponent } from './course-display/course-display.component';
import { TaskDisplayComponent } from './task-display/task-display.component';
import { TaskCreateComponent } from './task-create/task-create.component';
import { CourseCreateComponent } from './course-create/course-create.component';
import { AllcoursesComponent } from './allcourses/allcourses.component'
import { HomeComponent } from './home/home.component';
import { MyAccountComponent } from './my-account/my-account.component';
const routes: Routes = [
  
    {path: '', component: HomeComponent},
    {path: 'courses/create', component: CourseCreateComponent}, 
    {path: 'course/:id/tasks', component: TaskDisplayComponent}, 
    {path: 'login', component: LogInComponent },
    {path: 'signup', component: SignUpComponent },
    {path: 'course/:id', component: CourseDisplayComponent}, 
    {path: 'course/:id/create-task', component: TaskCreateComponent},
    {path: 'courses', component: AllcoursesComponent},
    {path: 'myaccount', component: MyAccountComponent},
        //testing purpose 
    {path: 'create-task', component: TaskCreateComponent}

];

@NgModule({
    declarations: [],
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
  
  })
  export class AppRoutingModule { }