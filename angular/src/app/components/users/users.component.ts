import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CustomerService } from '../../services/Scustomers/customer.service';
import { workers } from '../../Classes/worker';

@Component({
  selector: 'app-users',
  templateUrl: './users.component.html',
  styleUrls: ['./users.component.scss']
})
export class UsersComponent implements OnInit {
  
  // user:any={};
  // paaswordc:string
  constructor( ) {
   //constructor(private serv:CustomerService ,router:Router) {
  //  this.user={};
  //  this.user={"userId":'',"username":"","namchatan":" ","nameCala":" ","dateWedding":" ","taktziv":" ","mailChatan":" ","mailCala":" ","misinvited":" "};
  
  }

  ngOnInit() {
  }


  // precentt(){
  //   this.router.navigateByUrl("precent")
// }
}


// <precent [all]="user.userid"></precent>
// this.Serv.שם המשתנה 