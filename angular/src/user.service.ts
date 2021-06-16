// import { Injectable } from '@angular/core';
// import { CanActivate, ActivatedRouteSnapshot, RouterStateSnapshot, Router } from '@angular/router';


// //  newuser(){
// //     this.router.navigateByUrl('/log-in')
// //   }
// @Injectable({
//     providedIn: 'root'
//   })
//   export class UserService {
  
//     user: string;
//     password:string;
  
//     // Router - סרוויס של אנגולר שמכיל יכולות שונות שקשורת לניווט
//     constructor(private router: Router) {   
      
//       debugger;
//       // JSON.parse(JSON.stringify(data || null )
//       if(localStorage.getItem('user')!=null&&localStorage.getItem('password')!=null) {
//         this.user = JSON.parse(localStorage.getItem('user'))
//         this.password = JSON.parse(localStorage.getItem('password'))
//       }
//       debugger;
//     }
  
// //     login(user,password) {
// //       debugger;
// //        if(user!=""&&password!="")
// //        {
         
// //       this.user = user;
// //       this.password=password;
  
// //       localStorage.setItem('user', JSON.stringify(user));
// //       localStorage.setItem('password', JSON.stringify(password));
// //       // ניווט דרך הקוד
// //       this.router.navigateByUrl('/WellcomeComponent');
// //     }
// //     }
  
// //     logout() {
// //       localStorage.clear();
// //       this.user="";
// //       this.password="";
// //       this.router.navigateByUrl('/login');
// //     }
  
// //     inorder(){
// //       this.router.navigateByUrl('/inorder')
// //     }
  
    
// //     AddTeachers(){
// //       this.router.navigateByUrl('/AddTeachers')
// //     }
  
// //     Addprofessional(){
// //       this.router.navigateByUrl('/Addprofessional')
// //     }
// //     drag(){
// //       this.router.navigateByUrl('/drag')
// //     }
    
  
// //    // abuot(){
// //     //  debugger;
// //    // this.router.navigateByUrl('/')
// //    // }
  
//     newuse(){
//       this.router.navigateByUrl('/log -in')
//     }
   
  
//     // canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
//     //   debugger;
//     //   if (this.user && state.url.includes('login')&&this.password) {
//     //     this.router.navigateByUrl('/');
//     //     return false;
//     //   } else if(!this.user && !state.url.includes('login')&&!this.password) {
//     //     this.router.navigateByUrl('/login');
//     //     return false;
//     //   }
//     //   return true;
//     // }
  
//   }