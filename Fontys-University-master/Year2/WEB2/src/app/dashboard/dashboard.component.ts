import { Component, OnInit } from '@angular/core';
import { Employee } from '../employee';
import { EmployeeService } from '../employee.service';
import { Department } from '../department';
import { DepartmentService } from '../department.service';
import { Task } from '../task';
import { TaskService } from '../task.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: [ './dashboard.component.css' ]
})
export class DashboardComponent implements OnInit {
  employees: Employee[] = [];
  departments: Department[] = [];
  tasks: Task[] = [];

  constructor(private employeeService: EmployeeService, private departmentService: DepartmentService, private taskService: TaskService) { }

  ngOnInit() {
    this.getEmployees();
    this.getDepartments();
    this.getTasks();
  }

  getEmployees(): void {
    this.employeeService.getEmployees()
      .subscribe(employees => this.employees = employees.slice(1, 5));
  }
  getDepartments(): void {
    this.departmentService.getDepartments()
      .subscribe(departments => this.departments = departments.slice(1, 5));
  }
  getTasks(): void {
    this.taskService.getTasks()
      .subscribe(tasks => this.tasks = tasks.slice(1, 5));
  }
}