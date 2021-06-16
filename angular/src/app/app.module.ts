import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LogInComponent } from './Components/log-in/log-in.component';
import { NewUserComponent } from './Components/new-user/new-user.component';
import { RashiComponent } from './components/rashi/rashi.component';
import { MusicComponent } from './components/music/music.component';
import { PrecentComponent } from './components/precent/precent.component';
import { HallComponent } from './components/hall/hall.component';
import {MatToolbarModule} from '@angular/material/toolbar';
import {ServeService} from './serve.service';
import { FlowersComponent } from './components/flowers/flowers.component';
import { PhotographerComponent } from './components/photographer/photographer.component';
import { RabbiComponent } from './components/rabbi/rabbi.component';
import { RouterModule } from '@angular/router';
import {MatRadioModule} from '@angular/material/radio';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import {MatCheckboxModule} from '@angular/material/checkbox';
import { from } from 'rxjs';
import {PersonalComponent} from './components/personal/personal.component';
import { MoreinfComponent } from './components/moreinf/moreinf.component';
import { WorkerComponent } from './components/worker/worker.component';
import { UsersComponent } from './components/users/users.component';
// import {TextFieldModule} from '@angular/cdk/text-field';
import { customer } from './Classes/customer';


@NgModule({
  declarations: [
    AppComponent,
    LogInComponent,
    NewUserComponent,
    RashiComponent,
    MusicComponent,
    HallComponent,
    FlowersComponent,
    PhotographerComponent,
    RabbiComponent,
    PrecentComponent,
    NewUserComponent,
    PersonalComponent,
    MoreinfComponent,
    WorkerComponent,
    UsersComponent,
    //TextFieldModule
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    MatToolbarModule,
    MatRadioModule,
    HttpClientModule,
    FormsModule,
    MatCheckboxModule,
    //TextFieldModule,
 
    RouterModule.forRoot([
      {
        path:'flowers',
        component:FlowersComponent
      },
      {
        path:'rabbi',
        component:RabbiComponent
      },
      {
        path:'photographer',
        component:PhotographerComponent
      },{
        path:'music',
        component:MusicComponent
      },
      {
        path:'hall',
        component:HallComponent
      },
      {
        path:'log-in',
        component:LogInComponent
      },
      {
        path:'worker',
        component:WorkerComponent
      } /* ,
      {
        path:'**',
        component:AppComponent
      },*/
    ])
    
  ],
  providers: [ customer],
  bootstrap: [AppComponent]
})
export class AppModule { }
