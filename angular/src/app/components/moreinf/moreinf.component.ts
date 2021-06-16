import { Component, OnInit } from '@angular/core';
import { MusicService } from '../../services/Smusic/music.service';
import { workers } from '../../Classes/worker';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-moreinf',
  templateUrl: './moreinf.component.html',
  styleUrls: ['./moreinf.component.scss']
})
export class MoreinfComponent implements OnInit {
  [x: string]: any;
  work:workers;
  Workers:any[]=[];//הגדרת מערך
  Workers1:any[]=[];
  id:number;//הגדרת ינט רגיל
  worker1:any= {};//מופע בודד
 // work:workers;
  form;
  category:string;
  zaner:string;
  aria:string;
  obj: any;
  user:any={};
  //public work:workers;
  //worker1:any= {};//מופע בודד
  constructor(public serve:MusicService,private activatedRoute: ActivatedRoute ) {
    this.activatedRoute.params.subscribe(prm => {
      this.id = parseInt(prm['workerId'], 10);
      console.log('workerid', this.id);
      this.serve.getMoreinfo(this.id).subscribe((data: any) =>{
        console.log('worker', data);
        this.serve.worker = data;
      })
    })
    // this.activatedRoute.params.subscribe(myParams => {
    //     this.obj = myParams["todo"];
        // console.log("params:"+JSON.stringify(this.obj));
      //  });
      this.user={};
      this.user={"namchatan":'',"mailChatan":"","selfphone":" ","massege":" "};
     
   }


  // this.worker1={};
  // this.worker1={"Workerid":'',"nameworker":"","selfphone":" ","description":" ","category":" ",};
 
  ngOnInit() {
   this.work =  this.serve.worker;
   console.log("my worker:"+JSON.stringify(this.work));


   

    }
    aa(){
      if(this.worker.namchatan===" "||this.worker.mailChatan===" "||this.worker.selfphone===" "||this.worker.massege===" ")
      {
        alert(" השלם את כל השדות!")
      }
      else
      {
        //this.serv.submit(this.worker).subscribe();   
    
        alert("!הפרטים נקלטו בהצלחה!"+" "+ "הפניה מחכה לאישור המערכת ");
      }
    }
    
  }





  ///זימון הפונקציה שמקבל זמר מסוים ומחזיר את פרטיו

