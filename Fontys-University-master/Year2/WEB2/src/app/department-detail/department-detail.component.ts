import { Component, OnInit, Input } from '@angular/core';
import { Department } from '../department';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { DepartmentService } from '../department.service';
import {Employee} from '../employee';
import {EmployeeService} from '../employee.service';
@Component({
  selector: 'app-department-detail',
  templateUrl: './department-detail.component.html',
  styleUrls: ['./department-detail.component.css']
})
export class DepartmentDetailComponent implements OnInit {

  department: Department;
  employees: Employee[] = [];

  constructor(private route: ActivatedRoute,
    private departmentService: DepartmentService,
    private employeeService: EmployeeService,
    private location: Location) { }

  ngOnInit() {
    this.getDepartment();
  }

  getDepartment(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.departmentService.getDepartments()
      .subscribe(department => {  
        for(let i = 0; i < department.length; i++)
        {
          if(department[i].id == id)
          {
            this.department = department[i];
          }
        }
        this.employeeService.getEmployees().subscribe(y => {
          
          for(let i =0; i< y.length;i++){          
            for(let j =0; j< this.department.employees.length;j++){
              if(y[i].id == this.department.employees[j]){
                this.employees.push(y[i]);
              }
            }
          }
  
          });
      });
  }

  onRemove(department: Department): void{
    if(confirm("Are you sure?")) {
    this.departmentService.onRemove(this.department).subscribe(()=> this.goBack());
    alert('You Successfully removed The Department!');
    }

   }
   onUpdate(): void {
    this.departmentService.onUpdate(this.department).subscribe(()=> this.goBack());
  }
  
  goBack(): void {
    this.location.back();
  }
}
