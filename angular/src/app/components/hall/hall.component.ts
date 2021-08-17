import { Component, OnInit } from '@angular/core';
import { HallService } from '../../services/Shall/hall.service';
// import {MatRadioModule} from '@angular/material/radio';
import { Router } from '@angular/router';

@Component({
  selector: 'app-hall',
  templateUrl: './hall.component.html',
  styleUrls: ['./hall.component.scss']
})
export class HallComponent implements OnInit {
  [x: string]: any;
  Workers:any[]=[];
  Workers1:any[]=[];
  id:number;
  worker:any= {};
  form;
  category:string;
  zaner:string;
  aria:string;
  constructor(private router:Router ,private serve:HallService) { 
  }

  ngOnInit() {

 
 this.serve.getOne(1).subscribe(data =>{
  debugger;
  console.log('רשימה של אולמות', data) 
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
}
else {
  this.Workers1=this.Workers;
}
}


moreinff(todo){
  debugger;
 //this.router.navigate(["moreinf"],todo); debugger;
 this.serve.worker= todo; 
 this.router.navigateByUrl("moreinf"); debugger;
 }


}




