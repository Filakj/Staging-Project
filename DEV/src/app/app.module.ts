import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';

import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { SignUpComponent } from './sign-up/sign-up.component';
import { LogInComponent } from './log-in/log-in.component';
import { CourseDisplayComponent } from './course-display/course-display.component';
import { TaskDisplayComponent } from './task-display/task-display.component';
import { TaskCreateComponent } from './task-create/task-create.component';
import { CourseCreateComponent } from './course-create/course-create.component';
import { NavbarComponent } from './navbar/navbar.component';
import { AllcoursesComponent } from './allcourses/allcourses.component';
import { HomeComponent } from './home/home.component';

@NgModule({
  declarations: [
    AppComponent,
    SignUpComponent,
    LogInComponent,
    CourseDisplayComponent,
    TaskDisplayComponent,
    TaskCreateComponent,
    CourseCreateComponent,
    NavbarComponent,
    AllcoursesComponent,
    HomeComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
