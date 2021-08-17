import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { customer } from '../../Classes/customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  
  public cust: customer = null;
  public UserDetailes: customer; 

  urlServiece = 'http://localhost:57438/api/';


  constructor(private http: HttpClient) { 
  }


  
  submit(id, BB: any)
  {
   
    if (id == '0') {
      return this.http.put(this.urlServiece + "Customers", BB);
    } else {
      return this.http.post(this.urlServiece + "Customers/UpdateCustomer", BB);
      
    }

  }

  
  PutUpdateCustomer(custumer1: customer): Observable<customer> {
    debugger;

    return this.http.put<customer>(this.urlServiece + "Customers/UpdateCustomer", custumer1);

  }
  setCustomer(c) {
    this.cust = c;
  }

  getCustomer() {
    return this.cust;
  }

  
  DeleteCust(id: string) {
    return this.http.delete(this.urlServiece + "Customers/" + id);

  }

  
  findCustomer(id: number, name: string): Observable<any> {
 

    return this.http.get<any>(this.urlServiece + "Customers/Getcustomer/" + id + "/" + name)

  }

  getPercents(id: string) : Observable<any> {
    // if(id=='0')
    return this.http.get<any>(this.urlServiece + "Customers/Precents/" + id);

  }




}
  


