import { Component, OnInit } from '@angular/core';
import { MusicService } from '../../services/Smusic/music.service';
import { FormGroup,FormControl} from '@angular/forms'
import { PhotographerService } from '../../services/Sphotographer/photographer.service';
import { RabbiService } from '../../services/Srabbi/rabbi.service';
import { FlowersService } from '../../services/Sflowers/flowers.service';

import { Router } from '@angular/router';
import { workers } from '../../Classes/worker';

@Component({
  selector: 'app-music',
  templateUrl: './music.component.html',
  styleUrls: ['./music.component.scss']
})

export class MusicComponent implements OnInit {
  [x: string]: any;
  
  Workers:any[]=[];
  Workers1:any[]=[];
  id:number;
  worker:any= {};
  public work:workers;
  form;
  category:string;
  zaner:string;
  aria:string;
  // user:any
  constructor(private router:Router ,private serve:MusicService) { 
   
  }


  choose(name:string){

  }
  ngOnInit() {
  
    
     this.serve.getOne(2).subscribe(data =>{
       debugger;
       console.log('רשימה של מוזיקה',data)     
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
 this.serve.worker= todo; 
 this.router.navigate(["moreinf",todo.workerid]); debugger;
 }


}





 
      
   
      
     
