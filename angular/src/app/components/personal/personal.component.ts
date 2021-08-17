import { Component, OnInit, Input } from '@angular/core';
import { PortalHost } from '@angular/cdk/portal';
import { PhotographerService } from '../../services/Sphotographer/photographer.service';
import { CustomerService } from '../../services/Scustomers/customer.service';
import { Router } from '@angular/router';
import { customer } from '../../Classes/customer';
import { BehaviorSubject } from 'rxjs';


@Component({
  selector: 'app-personal',
  templateUrl: './personal.component.html',
  styleUrls: ['./personal.component.scss']
})


export class PersonalComponent implements OnInit {
  [x: string]: any;
  // @Input()
  user: any;
  paaswordc: string;
  constructor(public router: Router, private serc: CustomerService) {
    // this.user={};
    // this.user={"userId":'',"username":"","namchatan":" ","nameCala":" ","dateWedding":" ","taktziv":" ","mailChatan":" ","mailCala":" ","misinvited":" "};
  }

  cust1: customer



  name: string;
  ngOnInit() {
    debugger;
    this.cust1 = this.serc.getCustomer(); debugger;
    // this.name = this.cust1.nameCala;
    //this.cust1=this.serc.cust

  }
  
  precentt() {
    this.serc.UserDetailes = this.user
    this.router.navigateByUrl("precent")
  }
  
  updatecustomer() {

    this.serc.PutUpdateCustomer(this.user).subscribe();
  }

  
  delete() {
    this.serc.DeleteCust(this.user.userId).subscribe();
  }
}

