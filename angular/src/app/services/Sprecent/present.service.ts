import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';



@Injectable({
  providedIn: 'root'
})
export class PresentService {
  [x: string]: any;

  urlservice='http://localhost:57438/api/';
  constructor( private http :HttpClient) { }

 
  
  
  submit(BB:any)
  {
 
    debugger;
    return this.http.put(this.urlservice + "Typetouser",BB);

  }



  


}


