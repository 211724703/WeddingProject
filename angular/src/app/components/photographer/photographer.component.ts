import { Component, OnInit } from '@angular/core';
import { PhotographerService } from '../../services/Sphotographer/photographer.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-photographer',
  templateUrl: './photographer.component.html',
  styleUrls: ['./photographer.component.scss']
})
export class PhotographerComponent implements OnInit {

 Workers:any[]=[];
 id:number;
 worker:any= {};
 [x: string]: any;
 Workers1:any[]=[];
 form;
 category:string;
 zaner:string;
 aria:string;
 constructor(private router:Router ,private serve:PhotographerService) { 

 }

 ngOnInit() {

 
 this.serve.getOne(3).subscribe(data =>{
  debugger;
  console.log('רשימה של צלמים',data)
  this.Workers=data;debugger; 
  console.log(this.Workers);
  this.Workers1=this.Workers;debugger;  
 });
}

changed(evt) {
debugger;
if(evt.checked)
{debugger;
this.category=evt.source.name; 
if(this.category=='כל האזורים')
   return this.Workers1=this.Workers;
else{
  this.Workers1=this.Workers.filter(item=>{debugger;return item.category==this.category}  );
}
else {
  this.Workers1=this.Workers;
}
}


moreinff(todo){
 this.serve.worker= todo; 
 this.router.navigate(["moreinf", todo.workerid]); debugger;
 }

}
