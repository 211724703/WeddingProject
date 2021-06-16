import { Component, OnInit } from '@angular/core';
import {FormBuilder, Validators} from '@angular/forms';
import {Observable} from 'rxjs';
import { Members } from 'src/app/Classes/members';
import { NewMemberServiceService } from './new-member-service.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-new-member',
  templateUrl: './new-member.component.html',
  styleUrls: ['./new-member.component.css']
})
export class NewMemberComponent implements OnInit {
  CreateMember(name:string, email:string, password:string){
    this.router.navigate(['./first-page']);
    this.newMemberService.addMember(name, password, email).subscribe
    ((data)=>{
      this.currentM=data as Members;
    })
  }
  currentM:Members;
  model=new Members();
  
  newMemberService: NewMemberServiceService;
  constructor(private router: Router) { }
  // NewMember(name: string, email:string, password:string){
  //   name= name.trim();
  //   email=email.trim();
  //   password=password.trim();
  //   this.newMemberService.addMember(name, password, email).subscribe
  //   (data=>{this.model=data as Members});
  // }
  getUserName(){
    return this.model.UserName;
  }
  ngOnInit() {
  }
  page1()
  {
      this.router.navigate(['./page1']);
  }
}
