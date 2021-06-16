import { Component, OnInit } from '@angular/core';
//import { userInfo } from 'os';
import { WorkersregistService } from '../../services/SWorkersregist/workersregist.service';

@Component({
  selector: 'app-worker',
  templateUrl: './worker.component.html',
  styleUrls: ['./worker.component.scss']
})

export class WorkerComponent implements OnInit {
  [x: string]: any;
  //customer:any[]=[];
  worker:any={};
  paaswordc:string
 
  constructor(private serv:WorkersregistService) {
    //private serv:CustomerService
    this.worker={};
    this.worker={"Nameworker":" ","Mailworker":" ","message":" "};
   
   }

  ngOnInit() {
  }

  Approval(){
    debugger;
    //customer.push()
    if(this.worker.Nameworker===" "||this.worker.Mailworker===" "||this.worker.message===" ")
    {
      alert(" השלם את כל השדות!")
    }
    else
    {
      this.serv.submit(this.worker).subscribe();   
  
      alert("!הפרטים נקלטו בהצלחה!"+" "+ "הפניה מחכה לאישור המערכת ");
    }
   
  }
  

  // Approval(){

  //  if(this.worker.Nameworker===null ||this.worker.Mailworker===undefined ||this.worker.message===undefined)
  //  alert(" !השלם את כל השדות")
  // else
  //   alert("!הפרטים נקלטו בהצלחה!"+" "+ "הפניה מחכה לאישור המערכת ");
  // }
} 



// תהילה פאק
// 0504146905
