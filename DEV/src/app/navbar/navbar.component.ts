import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  
  student: boolean
  instructor: boolean = false

  constructor() { }

  ngOnInit(): void {
    this.student = this.readLocalStorageValue('Role');
    
  }

 readLocalStorageValue(key: string): boolean {
   
    var r = localStorage.getItem(key);
    if(r=="student"){
      return true;
    }
    else{ 
      return false;
    }
}
  
signout(){ 
  localStorage.clear();
  location.href = "http://localhost:4200/"
  //location.reload();
 
}
}
