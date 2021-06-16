import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { workers } from '../../Classes/worker';

@Injectable({
  providedIn: 'root'
})
export class MusicService {

  urlservice='http://localhost:57438/api/';
  public work:workers;
  private _work1:workers;
  constructor(private http :HttpClient) { ///מקבל את הhttp והוא מעביר את הקריאות שרת
  }
  

  get worker():workers{
    return this._work1;
  }

  set worker(worker:workers){
     this._work1 = worker;
  }
  //החזרת פרטי בעל מיקצוע + מחיר
  //   getOne(id:number):Observable<any[]>//החזרת שורה בטבלה 
  //  {
  //   debugger;
  //     return  this.http.get<any[]>(this.urlservice+"Workers/GetDetailsWorkerById/"+id);
      
  //  }
  
   // ינפורמציה החזרת פרטי בעל מיקצוע + מחיר
  //  getOnee(id1:number,id2:number):Observable<any[]>//החזרת שורה בטבלה 
  //  {
  //   debugger;
  //     return  this.http.get<any[]>(this.urlservice+"Workers/GetinformWorker/"+id1+"/"+id2);
      
  //  }

  getall():Observable<any> //החזרת רשימה שלטבלה   ם
  {
   debugger;
   return  this.http.get(this.urlservice+ "Workers") ;//הכנסת הנתיב מווב לטבלת בעלי המצוע
   
  }

  //החזרת פרטי בעל מיקצוע + מחיר
    getOne(id:number):Observable<any[]>//החזרת שורה בטבלה 
   {
    debugger;
      return  this.http.get<any[]>(this.urlservice+"Workers/GetDetailsWorkerByType/"+id);
      
   }

   getMoreinfo(id:number):Observable<any[]>//החזרת שורה בטבלה 
   {
    
      return  this.http.get<any[]>(this.urlservice+"Workers/GetDetailsWorkerById/"+id);
   }


  

   



  }

 

