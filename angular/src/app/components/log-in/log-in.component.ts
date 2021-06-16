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
  
  //פתיחת קומפוננטה של משתמשים חדשים
  newuser(){
   debugger;
  this.router.navigate(["new-user", 0]); 
  }

  //פתיחת קומפוננטה של אזור אישי
  personall(){
   debugger;
   this.router.navigate(["new-user", this.user.userId]); 
   // this.router.navigateByUrl("personal"); debugger;
    }

  //פונקצית שליפה שם משתמש וסיסמא
  //אני אמורה לקבל את שניהם או רק את הסיסמא
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
   

      // this.serv.findCustomer(this.user.userId,this.user.username);debugger;
      // this.serv.cust.subscribe(data=>{
      //   debugger;
      //  // this.serv.cust=data;
      //   this.customer1=data
      //   if(this.customer1===undefined)
      //   alert("try again");
      //   else
      //   alert(this.customer1.namchatan);
      
      // });//הלקוח הזה יכיל את הפרטים שקיבלנו
  
     
    }
  }


//       this.user.findCustomer(this.userId,this.username)
//       .subscribe( data => {debugger;
//                  if (data) {
//                   //לומר לו להכניס את הפרטים
//                      new alert("succses");
//                  }
//                  else {
//                     new alert("try agian");
//                  }
//              },
//              errors => {
//                  console.log("request failed");
//              }
// ); 
// ;
// addcustomer(){debugger;
//   //customer.push()
//   if(this.user.username==this.paaswordc)
//   {
//    this.serv.submit(this.user).subscribe();   
//   }
//    else
//    alert("הסיסמה שגויה נסה שוב ");debugger;
//   }



  