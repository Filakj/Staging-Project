import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
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
import { MyAccountComponent } from './my-account/my-account.component';

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
    HomeComponent,
    MyAccountComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule, 
    FormsModule, 
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
