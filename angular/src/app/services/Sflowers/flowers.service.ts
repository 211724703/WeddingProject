import { Injectable } from '@angular/core';
import {  HttpClientModule,HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class FlowersService {
  [x: string]: any;
  urlservice='http://localhost:57438/api/';
  public work:Worker;
  private _work1:Worker;
  constructor(private http :HttpClient) { ///מקבל את הhttp והוא מעביר את הקריאות שרת
  }

  get worker():Worker{
    return this._work1;
  }

  set worker(worker:Worker){
     this._work1 = worker;
  }

  getall():Observable<any> //החזרת רשימה שלטבלה   ם
  {
   debugger;
   return  this.http.get(this.urlservice+ "Workers") ;//הכנסת הנתיב מווב לטבלת בעלי המצוע
    // this.srv.get<NewBB[]>(this.url+"NewBBS/GetAllBB")
   
  }

  
  //החזרת פרטי בעל מיקצוע + מחיר
    getOne(id:number):Observable<any[]>//החזרת שורה בטבלה 
   {
    debugger;
      return  this.http.get<any[]>(this.urlservice+"Workers/GetDetailsWorkerByType/"+id);
      
   }
  }








