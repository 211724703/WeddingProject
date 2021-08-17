

import { PortalHost } from '@angular/cdk/portal';
import { PhotographerService } from '../../services/Sphotographer/photographer.service';
import { CustomerService } from '../../services/Scustomers/customer.service';
import { Router, ActivatedRoute, Params } from '@angular/router';
import { customer } from '../../Classes/customer';
import { FormsModule, Validators, FormControl } from '@angular/forms';
import {ErrorStateMatcher} from '@angular/material/core';
import { OnInit, Component } from '@angular/core';
//import {FormControl, FormGroupDirective, NgForm, Validators}

@Component({
  selector: 'app-new-user',
  templateUrl: './new-user.component.html',
  styleUrls: ['./new-user.component.css']
})
export class NewUserComponent implements OnInit {
  [x: string]: any;
  userId: string;
  paaswordc:string
  customerId: number;
  detailsForm: FormsModule;
  // todayDate: Date = new Date("");
  //customer: customer;
  constructor(private router:Router , private serv:CustomerService, private activatedRoute: ActivatedRoute, public customer: customer ) {
   //constructor(private serv:CustomerService ,router:Router) {
  // this.user={};
  // this.user={"userId":'',"username":"","namchatan":" ","nameCala":" ","dateWedding":" ","taktziv":" ","mailChatan":" ","mailCala":" ","misinvited":" "};
  
  }
  // serv:CustomerService 

  
  ngOnInit() {
    this.activatedRoute.params.subscribe((params: Params) => {
      if (params['userId'] == '0'){
        this.customer = new customer(); 
        this.customerId = 0;
        this.serv.setCustomer(this.customer);
      }
      else {
      this.customerId =parseInt(params['userId'] ,10);
      console.log('customer', this.serv.cust);
      this.serv.cust.dateWedding = new Date( this.serv.cust.dateWedding);
      this.customer = this.serv.cust;
      }
    });

  }
  
  addcustomer(){
    
    if(this.customer.username==this.paaswordc)
    {
     this.serv.submit(this.customerId, this.customer).subscribe();   
    }
     else
     alert("הסיסמה שגויה נסה שוב ");debugger;
    }
   

  precentt(){
    //this.user.isNew=true;
         this.serv.UserDetailes =this.user 
        this.router.navigate(['precent',this.customerId]);
   }

  
error:any={isError:false,errorMessage:''};

compareTwoDates(){
   if(new Date(this.form.controls['dateWedding'].value)<new Date(Date.now())){
      this.error={isError:true,errorMessage:'תאריך לא תקין'};
   }
}
  }









  
 






