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
  
  }
}

