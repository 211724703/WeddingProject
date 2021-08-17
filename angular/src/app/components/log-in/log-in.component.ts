import { Component, OnInit } from '@angular/core';
import { Router} from '@angular/router'; 
import { CustomerService } from '../../services/Scustomers/customer.service';
import { customer } from '../../Classes/customer';


@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {
  [x: string]: any;
  //customer:any[]=[];
  user:any={};
  //customer1:customer;
  islogin:boolean= false;

  constructor(private router:Router, private serv:CustomerService, public customer1: customer) { 
    this.user={"userId":'',"username":''};
  }

  
  ngOnInit() {

  }
  
  
  newuser(){
   debugger;
  this.router.navigate(["new-user", 0]); 
  }

  
  personall(){
   debugger;
   this.router.navigate(["new-user", this.user.userId]); 
   // this.router.navigateByUrl("personal"); debugger;
    }

 
  connect()   { 
        this.serv.findCustomer(this.user.userId,this.user.username).subscribe(data=>{
        this.serv.setCustomer(data);
        this.customer1=data
        if(this.customer1===undefined)
        alert("try again");
        else
        this.islogin=true;
        console.log('customer', this.customer1);
       // this.router.navigate(["new-user", this.customer1.userId]); 
      });
   

     

  
