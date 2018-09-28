import { LoginComponent } from '../login/login.component';
import { HomeComponent } from '../home/home.component';
import { AuthGuard } from '../security/auth.guard';
import { Routes } from '@angular/router';
import { DoctorsListComponent } from '../doctors/doctors-list.component';

export const routes:Routes = [
    {
        path:'login',
        component:LoginComponent
    },
    {
        path:'',
        component:LoginComponent
    },
    {
        path:'home',
        component:HomeComponent,
        canActivate:[AuthGuard]
    },
    {
        path:'doctors',
        component:DoctorsListComponent,
        canActivate:[AuthGuard]
    }
]