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

  constructor(private http :HttpClient) { 
  }


  getworker():Worker{
    return this._work1;
  }
  
  setworker(worker:Worker){
     this._work1 = worker;
  }
  

// getOnee(id1:number,id2:number):Observable<any[]>
// {
//  debugger;
//    return  this.http.get<any[]>(this.urlservice+"Workers/GetinformWorker/"+id1+"/"+id2);
   
// }

 
 submit(BB: any)
 {
   // const httpOptions = { headers: new HttpHeaders({'Content-Type': 'application/json'})};
   debugger;
   return this.http.put(this.urlServiece + "Workersregistration", BB);

 }

  
  findByName(name:string): Observable<any> 
  {
    debugger;
    return this.http.get<any>(this.urlServiece+"Workers/GetworkerByName/"+name);debugger;
  }

  getTypeOfWorkers() {
    return this.http.get<any>(this.urlServiece+"Typeofworker");
  }
  
}








