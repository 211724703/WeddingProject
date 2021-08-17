import { Component, OnInit } from '@angular/core';
import { FlowersService } from '../../services/Sflowers/flowers.service';
import { FormGroup,FormControl} from '@angular/forms'
import { PhotographerService } from '../../services/Sphotographer/photographer.service';
import { MusicService } from '../../services/Smusic/music.service';
import { workers } from '../../Classes/worker';
import { Router } from '@angular/router';


@Component({
  selector: 'app-flowers',
  templateUrl: './flowers.component.html',
  styleUrls: ['./flowers.component.scss']
})
export class FlowersComponent implements OnInit {
  Workers:any[]=[];
 //Workers1:any[]=[]; 
  id:number;
  [x: string]: any;
  Workers1:any= {};
  form;
  category:string;
  zaner:string;
  aria:string; 
  public work:workers;
  constructor(private router:Router ,private serve:FlowersService) {
  }

  ngOnInit() {
  
  this.serve.getOne(4).subscribe(data =>{
  debugger;
  console.log('רשימה של פרחים',data)
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
 //this.router.navigate(["moreinf"],todo); debugger;
  this.serve.worker= todo; 
  this.router.navigate(["moreinf",todo.workerid]); debugger;
 }

alef(){

 }
less(){

   }
high(){

}

} 


