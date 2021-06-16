import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  constructor( private route: ActivatedRoute,
    private router: Router) { }
    name:any={};

  ngOnInit() {
  }
  signUpPage()
  {
      this.router.navigate(['./new-member']);
  }

trydrow()
  {
      this.router.navigate(['./tryDrow']);
  }
  page1()
  {
      this.router.navigate(['./page1']);
  }
}
