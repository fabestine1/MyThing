import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css']
})
export class EmployeesComponent implements OnInit {
  employees: Employee[];

  selectedEmployee: Employee;
 
  selectedUpdate: Employee;

  selectedView: Employee;


  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.getEmployees();
  }

  onSelect(employee: Employee): void {
    this.selectedEmployee = employee;
    this.selectedView = this.selectedEmployee;
    this.selectedUpdate = null;
  }
  
  onUpdate(): void {
    this.selectedView = null;
    this.selectedUpdate = this.selectedEmployee;
  }

  onView(): void {
    this.selectedUpdate = null;
    this.selectedView = this.selectedEmployee;
  }
  
  onClick(): void {
    this.employees.push(new Employee());
  }

  onRemove(): void {
    let currentEmployee = this.selectedEmployee;
    for(var i = this.employees.length - 1; i >= 0; i--) {
      if(this.employees[i].id === currentEmployee.id) {
        this.employees.splice(i, 1);
      }
    }
      this.selectedEmployee = null;
  }
  getEmployees(): void {
    this.employeeService.getEmployees()
        .subscribe(employees => this.employees = employees);
  }
}
