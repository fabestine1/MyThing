import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';

import { Employee }         from '../employee';
import { EmployeeService }  from '../employee.service';
import { Department }       from '../department';
import { DepartmentService } from '../department.service';


@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styleUrls: [ './employee-detail.component.css' ]
})
export class EmployeeDetailComponent implements OnInit {
  department: Department;

  @Input() employee: Employee;

  constructor(
    private route: ActivatedRoute,
    private employeeService: EmployeeService,
    private departmentService: DepartmentService,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.employeeService.getEmployee(id)
      .subscribe(employee => this.employee = employee);

      this.departmentService.getDepartments().subscribe(x => {
           
        for(let i =0; i< x.length;i++){
          if(x[i].id == this.employee.department_id){
            this.department=x[i];
          }
      }
      });
  }

  goBack(): void {
    this.location.back();
  }

 save(): void {
    this.employeeService.updateEmployee(this.employee)
      .subscribe(() => this.goBack());
  }

  delete() {
    if(confirm("Are you sure?")) {
      this.employeeService.deleteEmployee(this.employee).subscribe(() => this.goBack());
    }
  }
}
