import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LogInComponent } from './Components/log-in/log-in.component';
import { NewUserComponent } from './Components/new-user/new-user.component';
import { RashiComponent } from './components/rashi/rashi.component';
//import {MatButtonModule} from '@angular/material/button';
import{MusicComponent} from './components/music/music.component';
import {HallComponent} from './components/hall/hall.component';
import { PrecentComponent } from './components/precent/precent.component';
import { PersonalComponent } from './components/personal/personal.component';
import { from } from 'rxjs';
import { MoreinfComponent } from './components/moreinf/moreinf.component';
import { WorkerComponent } from './components/worker/worker.component';
import { UsersComponent } from './components/users/users.component';
import{FlowersComponent} from './components/flowers/flowers.component';
import{RabbiComponent} from './components/rabbi/rabbi.component';
import{PhotographerComponent} from './components/photographer/photographer.component';


const routes: Routes = [
  // {
  //   path:'',component:RashiComponent 
  // },
  {
    path:'log-in',component:LogInComponent
  },
  {
    path:'users',component:UsersComponent
  },
  {
    path:'new-user/:userId',component:NewUserComponent, 
  },
  {
    path:'personal',component:PersonalComponent
  },
  {
    path:'music',component:MusicComponent
  },
  {
    path:'hall',component:HallComponent
  },
  {
    path:'rashi',component:RashiComponent
  },
  {
    path:'precent/:customerId',component:PrecentComponent
  },
   {
    path:'moreinf/:workerId',component:MoreinfComponent
  },
  {
    path:'Worker',component:WorkerComponent
  },
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

 