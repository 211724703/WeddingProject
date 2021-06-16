import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
// import{Typetouser} from '../../Classes/Typetouser';


@Injectable({
  providedIn: 'root'
})
export class PresentService {
  [x: string]: any;

  urlservice='http://localhost:57438/api/';
  constructor( private http :HttpClient) { }

 
  
  //הוספת לקוח חדש
  submit(BB:any)// פרטים ומכניס לדטה בייס מקבל 
  {
    // const httpOptions = { headers: new HttpHeaders({'Content-Type': 'application/json'})};
    debugger;
    return this.http.put(this.urlservice + "Typetouser",BB);

  }



  //  //החזרת רשימה של סוגי בעלי מקצוע (ברירת מחדל) 
  //  getOne():Observable<Typeofworker[]>//החזרת שורה בטבלה 
  //  {
  //   debugger;
  //     return  this.http.get<Typeofworker[]>(this.urlservice+"Typeofworker");
      
  //  }

  //   //החזרת רשימה של סוגים  ללקוח 
  //   getOneid():Observable<Typetouser[]>//החזרת שורה בטבלה 
  //   {
  //    debugger;
  //      return  this.http.get<Typetouser[]>(this.urlservice+"Typeofworker");
       
  //   }
    


}


