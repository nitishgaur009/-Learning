import { Injectable } from '@angular/core';
import { AuthenticatedDataModel } from '../models/auth-data.models';
import { LoginModel } from '../models/login.model';
import { LoginData } from '../mock-login-data';

@Injectable()
export class AuthService {
  public authenticatedData: AuthenticatedDataModel = new AuthenticatedDataModel();
  public returnUrl : string;

  constructor() {
     if(localStorage.getItem('userdata')){
        this.authenticatedData = JSON.parse(localStorage.getItem('userdata'));
     }
   }

  resetAuthenticatedData():void{
    this.authenticatedData.username = '';
    this.authenticatedData.roles = [];
    this.authenticatedData.token = '';
  }
  
  login(loginModel:LoginModel):void{
    this.resetAuthenticatedData();

    Object.assign(this.authenticatedData,
      LoginData.find(u => u.username == loginModel.username && loginModel.password == "123"));

      if(this.authenticatedData.isAuthenticated){
        localStorage.setItem("userdata", JSON.stringify(this.authenticatedData));
      }
  }

  logout():void{
    this.resetAuthenticatedData();
    localStorage.removeItem("userdata");
  }
}
