import { Component, OnInit } from '@angular/core';
//import {Component} from '@angular/core';
import {MatButtonModule} from '@angular/material/button';
// import {MatTabsModule} from '@angular/material/tabs';
import { Router} from '@angular/router'; 

@Component({
  selector: 'app-rashi',
  templateUrl: './rashi.component.html',
  styleUrls: ['./rashi.component.scss']
})
export class RashiComponent implements OnInit {

  constructor(private router:Router) { }

  ngOnInit() {
  }
  newuser(){
    //this.router.navigateByUrl("log-in")
   // this.log-in.newuser();
  }
}

// function openCity(evt, cityName) {
//   // Declare all variables
//   var i, tabcontent, tablinks;

//   // Get all elements with class="tabcontent" and hide them
//   tabcontent = document.getElementsByClassName("tabcontent");
//   for (i = 0; i < tabcontent.length; i++) {
//     tabcontent[i].style.display = "none";
//   }

//   // Get all elements with class="tablinks" and remove the class "active"
//   tablinks = document.getElementsByClassName("tablinks");
//   for (i = 0; i < tablinks.length; i++) {
//     tablinks[i].className = tablinks[i].className.replace(" active", "");
//   }

//   // Show the current tab, and add an "active" class to the button that opened the tab
//   document.getElementById(cityName).style.display = "block";
//   evt.currentTarget.className += " active";
// }


