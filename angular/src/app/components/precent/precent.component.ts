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

  all:number=10000;//נזמן את הפונקציה של הממוצע הכללי 
  incres: number;
  dec: number;//לחסר
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

    // this.serve.getTypeOfWorkers().subscribe(data => {
    //   console.log('type of workers', data)
    //   this.typeOfWorker = data});

    this.activatedRoute.params.subscribe(params => {
      console.log(params);
      this.customerId = params["customerId"];//מקבלת אם הלקוח חדש או לא

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
      //סכום גלישה

      this.glish = this.num - this.all
      //סכום האולם קודם
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

    // this.options.update({ series:[{ data:["a", 2] }]}); 
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
    //this.serv.submit().subscribe();
  }
}


// ......................
// import { Component, OnInit, Input } from '@angular/core';
// //import { Chart } from 'angular-highcharts';
// import * as Highcharts from 'highcharts';
// //import { CustomerService } from '../../services/Scustomers/customer.service';
// import { CCustomers } from '../../Classes/CCustomers';
// //import { PresentService } from '../../services/Sprecent/present.service';
// import { Typeofworker } from '../../Classes/Typeofworker';
// import { Typetouser } from '../../Classes/Typetouser';
// import { Router, ActivatedRoute } from '@angular/router';
// import { CustomerService } from '../../services/Scustomers/customer.service';
// import{ PresentService} from'../../services/Sprecent/present.service';

// @Component({
//   selector: 'app-precent',
//   templateUrl: './precent.component.html',
//   styleUrls: ['./precent.component.scss']
// })
// export class PrecentComponent implements OnInit {


//   // @Input()// את התקציב פונקציה שמקבלת קוד לקוח ומחזירה 

//   all: number;
//   //all:number=10000;//נזמן את הפונקציה של הממוצע הכללי 
//   incres: number;
//   dec: number;//לחסר
//   num: number;
//   //hall: number;
//   // hall: number=3000;
//   // Music: number = 2000;
//   // Catering: number = 2500;
//   // photographer: number = 1500;
//   // flowerArrangement: number = 1000;
//   hall: number;
//   Music: number;
//   Catering: number;
//   photographer: number;
//   flowerArrangement: number;
//   glish: number;
//   other: number;
//   [x: string]: any;
//   list:Typeofworker[];
//   list1:Typetouser[];
//   public Group:any[]=[];
//   Userid:Typetouser;
//   params:any;
//   constructor(private serv: CustomerService,private ser:PresentService,private rout:ActivatedRoute) {
//     //this.init();

//   }


//   public options: any
//   temp: CCustomers;
//   ngOnInit() {
//     debugger;
//       // //זה טוב להוציא מהערה 
//       this.temp = this.serv.UserDetailes;
      
//      this.rout.params.subscribe(params =>{
//      if (params["isNew"] == "true")//בדיקה האם הוא משתמש חדש ם
//       {
//          this.all = this.serv.UserDetailes.taktziv;
//          this.ser.getOne().subscribe(data =>{
//          debugger;
//          console.log('רשימה של מקצוע +אחוזים')
//          console.log(data);
//          this.list =data;
//          this.list.forEach(element => {
//            switch(element["nametype"])
//            {case "אולם" :this.hall=(this.all/100)*element["Precent"];debugger; ;break;
//            case "מוזיקה" :this.Music=(this.all/100)*element["Precent"];break;
//            case "סידור פרחים" :this.flowerArrangement=(this.all/100)*element["Precent"];break;
//            case "קייטרינג" :this.Catering=(this.all/100)*element["Precent"];break;
//            case "צלם" :this.photographer=(this.all/100)*element["Precent"];break;
//            default:;
//            }
//          });
//         });
      
//       }
     
// else{
//   this.ser.getOneid().subscribe(data =>{
//     debugger;
//     console.log('רשימה של אחוזים  ללקוח')
//     console.log(data);
//     this.list1 =data;
//     this.list.forEach(element => {
//       if (this.serv.UserDetailes.Userid==this.Userid)////החזרת השירותים של לקוח ספציפי 
//       switch(element["typeid"])
//       {case "1" :this.hall=element["Precent"];debugger; ;break;
//       case "2" :this.Music=element["Precent"];break;
//       case "4" :this.flowerArrangement=element["Precent"];break;
//       case "5" :this.Catering=element["Precent"];break;
//       case "3" :this.photographer=element["Precent"];break;
//       default:;
//       }
//     });
//    });


// }
      

// });


// //לקחת  את התקציב ולהציג את הרשימה שבתקציב  


//         //  //פונקציה המקבלת אוביקט מסוג  לקוח ומחזירה רשימה המכילה לכל סוג שירות כמה אחוזים יש

//         //  public int[] GetPrecentToType(int Id)///מקבל קוד לקוח 
//         //  {
//         //      Typeofworker t = new Typeofworker();
//         //      int[] arr = new int[10];//יש 5 שירותים
//         //      var typeofworkergroup = from tmp in iTypetR.GetAllTypetouser()
//         //                              where tmp.Userid== Id       //מביא רק את הלקוח המסוים 
//         //                              group tmp by tmp.Typeid;   //מחלק לקבוצות עפ"י סןג שירות 
//         //      foreach (var group in typeofworkergroup)
//         //      {
//         //          arr[group.Key] = t.Precent;  //כמה אחוזים לכל סוג    /////לשאול שזה טוב               
//         //      }
 
//         //      return arr;
//         //  }
 
      
//    //this.typrecent=data[0];debugger; //החזרה בצורת רשימה 
//   // console.log(this.typrecent);
//    //this.typrecent1=this.typrecent;debugger; 
 
//       // //זימון הפונקציה 
//       // arr[5] for 
//       // hall=arr[0]
//     // }
//     // else {


//     // alert(this.serv.UserDetailes.userId);
//     // let userId = this.serv.UserDetailes.userId;
//     // //  if()
//     // alert(this.all)
//     // כאן שמים את הפונקציה שמקבלת תקיב 
//     this.init();
//     Highcharts.chart('container', this.options);
      
// }

//   //לעשות חישוב
//       //  public int[] GetDefoultPrecentToType(/*List<int> tipe*//*,*/ int scom)///מקבל תקציב ורשימת סוגי שירות 
//       //  {
//       //      Typeofworker t = new Typeofworker();
//       //      int[] arr = new int[10];//יש 5 שירותים
//       //      var typeofworkergroup = from tmp in iTypeofR.GetAllTypeofworker()//חילקנו את הרשימות עפי השדה מפתח 
//       //                              group tmp by tmp.Typeid;
//       //      foreach (var group in typeofworkergroup)
//       //      {
//       //          arr[group.Key] = t.Precent / 100 * scom;  //כמה אחוזים לכל סוג    /////לשאול שזה טוב               
//       //      }

//       //      return arr;
//       //  }
  
//   aa(the: number) {
//     debugger;
//     this.num = (this.options.series[0]['data'][0]['y'] + this.options.series[0]['data'][1]['y'] + this.options.series[0]['data'][2]['y'] + this.options.series[0]['data'][3]['y'] + this.options.series[0]['data'][4]['y']);
//     if (this.num < this.all) {
//       this.incres = this.all / this.num;
//       debugger;
//       this.options.series[0]['data'][0]['y'] = this.options.series[0]['data'][0]['y'] * this.incres;
//       this.options.series[0]['data'][1]['y'] = this.options.series[0]['data'][1]['y'] * this.incres;
//       this.options.series[0]['data'][2]['y'] = this.options.series[0]['data'][2]['y'] * this.incres;
//       this.options.series[0]['data'][3]['y'] = this.options.series[0]['data'][3]['y'] * this.incres;
//       this.options.series[0]['data'][4]['y'] = this.options.series[0]['data'][4]['y'] * this.incres;

//     }
//     else {
//       //סכום גלישה

//       this.glish = this.num - this.all
//       //סכום האולם קודם
//       this.other = this.all - (this.options.series[0]['data'][the]['y'] - this.glish);
//       this.dec = (this.all - this.options.series[0]['data'][the]['y']) / this.other;
//       if (the != 0)
//         this.options.series[0]['data'][0]['y'] = this.options.series[0]['data'][0]['y'] * this.dec;
//       if (the != 1)
//         this.options.series[0]['data'][1]['y'] = this.options.series[0]['data'][1]['y'] * this.dec;
//       if (the != 2)
//         this.options.series[0]['data'][2]['y'] = this.options.series[0]['data'][2]['y'] * this.dec;
//       if (the != 3)
//         this.options.series[0]['data'][3]['y'] = this.options.series[0]['data'][3]['y'] * this.dec;
//       if (the != 4)
//         this.options.series[0]['data'][4]['y'] = this.options.series[0]['data'][4]['y'] * this.dec;

//     }
//     Highcharts.chart('container', this.options);

//     // this.options.update({ series:[{ data:["a", 2] }]}); 
//   }
//   init() {
//     this.options = {
//       chart: {
//         plotBackgroundColor: null,
//         plotBorderWidth: null,
//         plotShadow: true,
//         type: 'pie'
//       },
//       title: {
//         text: ''
//       },
//       tooltip: {
//         pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
//       },
//       accessibility: {
//         point: {
//           valueSuffix: '%'
//         }
//       },
//       plotOptions: {

//         pie: {
//           allowPointSelect: true,
//           cursor: 'pointer',
//           dataLabels: {
//             enabled: false
//           },
//           showInLegend: true
//         }
//       },
//       series: [{
//         type: undefined,
//         name: 'Brands',
//         colorByPoint: true,
//         data: [
//           {
//             name: 'אולם',
//             y: this.hall,
//             sliced: true,
//             selected: true
//           }, {
//             name: 'מוזיקה',
//             y: this.Music
//           }, {
//             name: 'קייטרינג',
//             y: this.Catering
//           }, {
//             name: 'צלם',
//             y: this.photographer
//           }, {
//             name: 'סידור פרחים',
//             y: this.flowerArrangement
//           }],

//       }]
//     };

//   }

// }





