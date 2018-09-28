import { Injectable } from '@angular/core';
import { DoctorModel } from '../models/doctor.model';


@Injectable()
export class DoctorsService {

    constructor() {
    }

    getAllDoctors(): DoctorModel[] {
        return [
            {
                Name: "Tarun",
                DepartmentName: "Ortho",
                Qualification: "MBBS",
                TotalExperience: 5
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            },
            {
                Name: "Meena",
                DepartmentName: "Gynocologist",
                Qualification: "MBBS MD",
                TotalExperience: 3
            }
        ];
    }
}