import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule} from '@angular/router'
import { FormsModule} from '@angular/forms'


import { AppComponent } from './app.component';
import { routes } from './route/router';
import { LoginComponent } from './login/login.component';
import { HomeComponent } from './home/home.component';
import { AuthService } from './services/auth.service';
import { AuthGuard } from './security/auth.guard';
import { MenuComponent } from './common/menu.component';
import { DoctorsListComponent } from './doctors/doctors-list.component';
import { DoctorsService } from './services/doctors.service';


@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    HomeComponent,
    MenuComponent,
    DoctorsListComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [AuthService, AuthGuard, DoctorsService],
  bootstrap: [AppComponent]
})

export class AppModule { }
