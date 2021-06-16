import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class WorkersregistService {

  urlServiece = 'http://localhost:57438/api/';
  public work:Worker;
  private _work1:Worker;

  constructor(private http :HttpClient) { ///מקבל את הhttp והוא מעביר את הקריאות שרת
  }


  getworker():Worker{
    return this._work1;
  }
  
  setworker(worker:Worker){
     this._work1 = worker;
  }
  
// // ינפורמציה החזרת פרטי בעל מיקצוע + מחיר
// getOnee(id1:number,id2:number):Observable<any[]>//החזרת שורה בטבלה 
// {
//  debugger;
//    return  this.http.get<any[]>(this.urlservice+"Workers/GetinformWorker/"+id1+"/"+id2);
   
// }

 //הוספת לקוח חדש
 submit(BB: any)// פרטים ומכניס לדטה בייס מקבל 
 {
   // const httpOptions = { headers: new HttpHeaders({'Content-Type': 'application/json'})};
   debugger;
   return this.http.put(this.urlServiece + "Workersregistration", BB);

 }

  //שליפת בעל מיקצוע לפי שם
  findByName(name:string): Observable<any> 
  {
    debugger;
    return this.http.get<any>(this.urlServiece+"Workers/GetworkerByName/"+name);debugger;
  }

  getTypeOfWorkers() {
    return this.http.get<any>(this.urlServiece+"Typeofworker");
  }
  
}








