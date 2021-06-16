import { Component, OnInit } from '@angular/core';
import { Members } from '../Classes/members';
import {SignInService} from './sign-in.service'
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-sign-in',
  templateUrl: './sign-in.component.html',
  styleUrls: ['./sign-in.component.css']
})

export class SignInComponent implements OnInit {
  currentM: Members;
  signInService: SignInService;

  constructor(private router: Router) { 
  }

  getMembers(name:string, password:string){
  this.signInService.getMember(name, password)
  .subscribe((data:Members)=> 
    this.currentM={...data});
  if(this.currentM!=null){
    this.router.navigate(['./first-page']);
  }
}
ngOnInit() {
}
}
