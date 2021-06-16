import { Injectable } from '@angular/core';
import { Observable} from 'rxjs';
import { HttpParams, HttpClient, HttpHeaders} from '@angular/common/http';
import { Members } from 'src/app/Classes/members';
import {catchError, tap} from 'rxjs/operators';
@Injectable({
  providedIn: 'root'
})
export class NewMemberServiceService {

  url='http://localhost:59936/api/ShapeUp/Members';
  constructor(private http:HttpClient) { }
  addMember(name: string, password:string, email:string):Observable<Members>{
    const params=new HttpParams()
    .set('name', name)
    .set('password', password)
    .set('email', email);
      const httpOptions={
        headers:new HttpHeaders({
        'Content-Type': 'application/json'})
      };
      return this.http.post<Members>
      (this.url, params, httpOptions);
  }
  httpOptions={headers: new HttpHeaders({
    'Content-Type': 'application/json'})
  };
//   private handleError<T> (operation='operation', result?: T){
//     return (error:any):Observable<T>=>{
//       return of(result as T);
//     }
//   }
//   addMember (name:string, password:string, email:string): Observable<Members> {
  
//   params as unknown as Members;
//   return this.http.post<Members>('http://localhost:59936/api/ShapeUp/Members', params, this.httpOptions)
//   .pipe(tap((newMember: Members)=>catchError(this.handleError<Members>('addMember'))));
// }
}
