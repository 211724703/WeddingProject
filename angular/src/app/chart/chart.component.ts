import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-chart',
  templateUrl: './chart.component.html',
  styleUrls: ['./chart.component.css']
})
export class ChartComponent implements OnInit {

   chart = {
    type: 'area',
    spacingBottom: 30
 };
  constructor() { }

  ngOnInit() {
  }

}
