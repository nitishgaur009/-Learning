import { Component, OnInit } from '@angular/core';
import { DoctorsService } from '../services/doctors.service';
import { DoctorModel } from '../models/doctor.model';
import * as $ from 'jquery';
import 'datatables.net';
import 'datatables.net-bs4';

@Component({
  selector: 'app-doctors-list',
  templateUrl: './doctors-list.component.html',
  styleUrls: ['./doctors-list.component.css']
})
export class DoctorsListComponent implements OnInit {
  doctorsData:DoctorModel[];
  dataTable: any;

  constructor(private doctorService:DoctorsService) { }

  ngOnInit() {
    this.doctorsData = this.doctorService.getAllDoctors();
    const table: any = $('table');
    this.dataTable = table.DataTable();
  }
}
