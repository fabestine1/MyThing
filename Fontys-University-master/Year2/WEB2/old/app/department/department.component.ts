import { Component, OnInit } from '@angular/core';
import { DepartmentService } from '../department.service';
import {Department} from '../department';

@Component({
  selector: 'app-department',
  templateUrl: './department.component.html',
  styleUrls: ['./department.component.css']
})
export class DepartmentsComponent implements OnInit {

  departments: Department[];

  constructor(private departmentService: DepartmentService) { }

  ngOnInit() {
    this.getDepartments();
  }
   
  onClick(): void{
    this.departmentService.onClick();
  }

  getDepartments(): void {
    this.departmentService.getDepartments()
        .subscribe(departments => this.departments = departments);

  }
}

