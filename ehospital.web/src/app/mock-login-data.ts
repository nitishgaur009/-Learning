import { AuthenticatedDataModel } from "./models/auth-data.models";

export const LoginData: AuthenticatedDataModel[] = [
    {
        username : "nitish",
        roles : ["Admin","User"],
        token: "jfjdf-fdsfsdf-fdsfdsfsdfsdf-fdsfsdfsdfsd",
        isAuthenticated:true
    },

    {
        username : "user",
        roles : ["User"],
        token: "jfjdf-fdsfsdf-sdadsadsad-fdsfsdfsdfsd",
        isAuthenticated:true
    }
];