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
  
  Workers:any[]=[];//הגדרת מערך
  Workers1:any[]=[];
  id:number;//הגדרת ינט רגיל
  worker:any= {};//מופע בודד
  public work:workers;
  form;
  category:string;
  zaner:string;
  aria:string;
  // user:any
  constructor(private router:Router ,private serve:MusicService) { //מזמנים את הסרוויס)
   
  }


  choose(name:string){

  }
  ngOnInit() {
  
    // זימון הפונקציה המחזירה את רשימת בעלי המקצוע
     this.serve.getOne(2).subscribe(data =>{
       debugger;
       console.log('רשימה של מוזיקה',data)     
       this.Workers=data;debugger; //החזרה בצורת רשימה 
       console.log(this.Workers);
       this.Workers1=this.Workers;debugger;  //החזרה בצורת טבלה 
      });
    }

    //פונקציה בשביל הצ'ק בוקס
changed(evt) {
  debugger;
if(evt.checked)
{debugger;
  this.category=evt.source.name; //מה שנלחץ נכנס לשדה הקטגוריה
  if(this.category=='כל האזורים')
      return this.Workers1=this.Workers;
  else{
    this.Workers1=this.Workers.filter(item=>{debugger;return item.category==this.category}  );//בדיקה שהאלמט שנבחר  זהה לשדה קטגוריה שיש לזמר
  }
}
else {
  this.Workers1=this.Workers;
}
}


// פתיחת קומפוננטה של מידע נוסף 
moreinff(todo){
 this.serve.worker= todo; 
 this.router.navigate(["moreinf",todo.workerid]); debugger;
 }


}





   // /////////////////////////////////////////////////////////////////
  //    this.serve.findByName("userId").subscribe(data=>{this.Workers=data});
      // this.serve.findByName("אמירן דביר").subscribe(data=>{this.Workers=data});
     
      // this.serve.getall().subscribe(data=>{this.Workers=data});//אפשר לשלוח את הנתיב

      // this.serve.getOne(1).subscribe(data =>{this.worker=data[1]});
     
        
   
    
      
      
     
      
      
     
       
        // this.user={"userId":''}
        

      
   
      
      // פתיחת קומפוננטה של מידע נוסף 
  