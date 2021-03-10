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
  addingDepartmentname: string;
  addingDepartmentbuilding: string;
  addingDepartmentemployees: string;

  constructor(private departmentService: DepartmentService) { }

  ngOnInit() {
    this.getDepartments();
  }
   
  onClick(): void{
    var text = this.addingDepartmentemployees.split(' ');

    for(let i=0;i>this.addingDepartmentemployees.length;i++)
    {

    }
    let newarray: number[] = []; 

    text.forEach(element => {
      let a = Number(element);
      newarray.push(a);
    });
    
    let cDepartment: Department = {
      id: 0,
      name: this.addingDepartmentname,
      building: this.addingDepartmentbuilding,
      employees: newarray
    }
    this.departmentService.onClick(cDepartment).subscribe(d => this.departments.push(d));
  }

  getDepartments(): void {
    this.departmentService.getDepartments()
        .subscribe(departments => this.departments = departments);

  }
}

