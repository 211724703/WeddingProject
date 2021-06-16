import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { WorkersregistService } from './services/SWorkersregist/workersregist.service';
import { workers } from './Classes/worker';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {

  title = 'EasyFormAngular2';
  work:any={};
  Workers:any[]=[];//הגדרת מערך
  Workers1:any={nameworker: ''};
  id:number;//הגדרת int רגיל
  worker1:any= {};//מופע בודד
  typeOfWorker: any[];
  //public work:workers;

  constructor(private router:Router ,private serve:WorkersregistService) { //מזמנים את הסרוויס)
    this.work={"nameworker":''};
  }
 
  ngOnInit() {
    this.serve.getTypeOfWorkers().subscribe(data => {
      console.log('type of workers', data)
      this.typeOfWorker = data});
  }


  Getworker(){
this.serve.findByName(this.work.nameworker).subscribe(data=>{
  debugger;

  this.serve.setworker(data);
  console.log(data);
  this.Workers=data;debugger;
  //console.log("my worker:"+JSON.stringify(this.Workers));

  //this.Workers=data[0];
  if(this.Workers===undefined)
  {
     alert("try again");
  }
     
  this.Workers1=this.Workers;
debugger;
});
  }}