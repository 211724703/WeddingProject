import { Component, OnInit, Input } from '@angular/core';
//import { Chart } from 'angular-highcharts';
import * as Highcharts from 'highcharts';
import { CustomerService } from '../../services/Scustomers/customer.service';
import { customer } from '../../Classes/customer';
import { ActivatedRoute } from '@angular/router';
import { WorkersregistService } from '../../services/SWorkersregist/workersregist.service';
import { workers } from '../../Classes/worker';


@Component({
  selector: 'app-precent',
  templateUrl: './precent.component.html',
  styleUrls: ['./precent.component.scss']
})
export class PrecentComponent implements OnInit {
  [x: string]: any;
  typeOfWorker: any[];
  budget: number;

  all:number=10000;
  incres: number;
  dec: number;
  num: number;
  //hall: number;
  hall: number=3000;
  Music: number = 2000;
  Catering: number = 2500;
  photographer: number = 1500;
  flowerArrangement: number = 1000;
  glish: number;
  other: number;


  constructor(private serv: CustomerService, private activatedRoute: ActivatedRoute) {
    //this.init();

  }

  public options: any = {series: []};
  temp: customer;
  public group:any []=[];
  ngOnInit() {


    this.activatedRoute.params.subscribe(params => {
      console.log(params);
      this.customerId = params["customerId"];

    this.serv.getPercents(this.customerId.toString()).subscribe(data=>{
      console.log('percent', data);
      this.init();

      Highcharts.chart('container', this.options);
    });
  })
  
  }


  aa(the: number) {
    debugger;
    this.num = (this.options.series[0]['data'][0]['y'] + this.options.series[0]['data'][1]['y'] + this.options.series[0]['data'][2]['y'] + this.options.series[0]['data'][3]['y'] + this.options.series[0]['data'][4]['y']);
    if (this.num < this.all) {
      this.incres = this.all / this.num;
      debugger;
      this.options.series[0]['data'][0]['y'] = this.options.series[0]['data'][0]['y'] * this.incres;
      this.options.series[0]['data'][1]['y'] = this.options.series[0]['data'][1]['y'] * this.incres;
      this.options.series[0]['data'][2]['y'] = this.options.series[0]['data'][2]['y'] * this.incres;
      this.options.series[0]['data'][3]['y'] = this.options.series[0]['data'][3]['y'] * this.incres;
      this.options.series[0]['data'][4]['y'] = this.options.series[0]['data'][4]['y'] * this.incres;

    }
    else {
      

      this.glish = this.num - this.all
      
      this.other = this.all - (this.options.series[0]['data'][the]['y'] - this.glish);
      this.dec = (this.all - this.options.series[0]['data'][the]['y']) / this.other;
      if (the != 0)
        this.options.series[0]['data'][0]['y'] = this.options.series[0]['data'][0]['y'] * this.dec;
      if (the != 1)
        this.options.series[0]['data'][1]['y'] = this.options.series[0]['data'][1]['y'] * this.dec;
      if (the != 2)
        this.options.series[0]['data'][2]['y'] = this.options.series[0]['data'][2]['y'] * this.dec;
      if (the != 3)
        this.options.series[0]['data'][3]['y'] = this.options.series[0]['data'][3]['y'] * this.dec;
      if (the != 4)
        this.options.series[0]['data'][4]['y'] = this.options.series[0]['data'][4]['y'] * this.dec;

    }
    Highcharts.chart('container', this.options);

    
  }
  init() {
    this.options = {
      chart: {
        plotBackgroundColor: null,
        plotBorderWidth: null,
        plotShadow: true,
        type: 'pie'
      },
      title: {
        text: 'Browser market shares in January, 2018'
      },
      tooltip: {
        pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
      },
      accessibility: {
        point: {
          valueSuffix: '%'
        }
      },
      plotOptions: {

        pie: {
          allowPointSelect: true,
          cursor: 'pointer',
          dataLabels: {
            enabled: false
          },
          showInLegend: true
        }
      },
      series: [{
        type: undefined,
        name: 'Brands',
        colorByPoint: true,
        data: [
          {
            name: 'אולם',
            y: this.hall,
            sliced: true,
            selected: true
          }, {
            name: 'מוזיקה',
            y: this.Music
          }, {
            name: 'קייטרינג',
            y: this.Catering
          }, {
            name: 'צלם',
            y: this.photographer
          }, {
            name: 'סידור פרחים',
            y: this.flowerArrangement
          }],

      }]
    };

  }


  mmoza(){
   
  }
}







