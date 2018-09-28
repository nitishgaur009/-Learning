export class AuthenticatedDataModel{
    public username: string = '';
    public roles:string[] = [];
    public token:string = '';
    public isAuthenticated:boolean = false;
}