import { Injectable } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Members } from '../Classes/members';

@Injectable({
  providedIn: 'root'
})
export class SignInService {
  constructor(private http: HttpClient) { }
  getMember(name:string, password:string){
    const params=new HttpParams()
    .set('name', name)
    .set( 'password', password);
    return this.http.get<Members>('http://localhost:59936/api/ShapeUp/Members', {params}); 
  } 
}
 
