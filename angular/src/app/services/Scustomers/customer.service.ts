import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, BehaviorSubject } from 'rxjs';
import { customer } from '../../Classes/customer';

@Injectable({
  providedIn: 'root'
})
export class CustomerService {

  // public cust:BehaviorSubject<customer>=new BehaviorSubject <customer>(null);
  public cust: customer = null;
  public UserDetailes: customer; //מכיל פרטי לקוח 

  urlServiece = 'http://localhost:57438/api/';


  constructor(private http: HttpClient) { ///מקבל את הhttp והוא מעביר את הקריאות שרת
  }


  //הוספת לקוח חדש
  submit(id, BB: any)// פרטים ומכניס לדטה בייס מקבל 
  {
    // const httpOptions = { headers: new HttpHeaders({'Content-Type': 'application/json'})};
    if (id == '0') {
      return this.http.put(this.urlServiece + "Customers", BB);
    } else {
      return this.http.post(this.urlServiece + "Customers/UpdateCustomer", BB);
      
    }

  }

  //עידכון לקוח קיים
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

  //מחיקת לקוח קיים
  DeleteCust(id: string) {
    return this.http.delete(this.urlServiece + "Customers/" + id);

  }

  //שליפת שם משתמש וסיסמא
  findCustomer(id: number, name: string): Observable<any> {//לשנות את הID לSTRING
    // debugger;
    //  return this.http.get(this.urlServiece+"Customers/Getcustomer/"+id/+name);

    return this.http.get<any>(this.urlServiece + "Customers/Getcustomer/" + id + "/" + name)

    // .subscribe((data)=>{
    //   debugger;
    //   this.cust.next(data);
    // })

  }

  getPercents(id: string) : Observable<any> {
    // if(id=='0')
    return this.http.get<any>(this.urlServiece + "Customers/Precents/" + id);

  }




}
  // בן
  // tacziv= ][]

  // this .costomer= cost
  // ng model=costomer.name



