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
  constructor(private http :HttpClient) { 
  }
  

  get worker():workers{
    return this._work1;
  }

  set worker(worker:workers){
     this._work1 = worker;
  }
 
  getall():Observable<any> 
  {
   debugger;
   return  this.http.get(this.urlservice+ "Workers") ;
   
  }

  
    getOne(id:number):Observable<any[]>
   {
    debugger;
      return  this.http.get<any[]>(this.urlservice+"Workers/GetDetailsWorkerByType/"+id);
      
   }

   getMoreinfo(id:number):Observable<any[]>
   {
    
      return  this.http.get<any[]>(this.urlservice+"Workers/GetDetailsWorkerById/"+id);
   }


  

   



  }

 

