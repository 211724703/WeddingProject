import { Component, OnInit } from '@angular/core';
import { RabbiService } from '../../services/Srabbi/rabbi.service';
import { FlowersService } from '../../services/Sflowers/flowers.service';
import { FormGroup,FormControl} from '@angular/forms'
import { PhotographerService } from '../../services/Sphotographer/photographer.service';
import { MusicService } from '../../services/Smusic/music.service';
import { workers } from '../../Classes/worker';
import { Router } from '@angular/router';


@Component({
  selector: 'app-rabbi',
  templateUrl: './rabbi.component.html',
  styleUrls: ['./rabbi.component.scss']
})


export class RabbiComponent implements OnInit {

  [x: string]: any;
  
  Workers:any[]=[];//הגדרת מערך
  Workers1:any[]=[];
  id:number;//הגדרת int רגיל
  worker:any= {};//מופע בודד
  form;
  category:string;
  zaner:string;
  aria:string;
  public work:workers;
  constructor(private router:Router ,private serve:RabbiService) { //מזמנים את הסרוויס)
  }
 
  // this.user={"userId":''}
  
  ngOnInit() {

    // זימון הפונקציה המחזירה את רשימת בעלי המקצוע
 this.serve.getOne(5).subscribe(data =>{
  debugger;
  console.log('רשימה של רבנים',data)
  this.Workers=data;debugger; //החזרה בצורת רשימה 
  console.log(this.Workers);
  this.Workers1=this.Workers;debugger;  //החזרה בצורת טבלה 
 });
}

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
 this.router.navigate(["moreinf", todo.workerid]); debugger;
 }

}   