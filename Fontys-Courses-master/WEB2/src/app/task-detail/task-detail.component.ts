import { Component, OnInit, Input } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Location } from '@angular/common';
import { TaskService }  from '../task.service';
import { Task } from '../task';
import {EmployeeService} from '../employee.service';
import {DepartmentService} from '../department.service';
import {Employee} from '../employee';
import {Department} from '../department';

@Component({
  selector: 'app-task-detail',
  templateUrl: './task-detail.component.html',
  styleUrls: ['./task-detail.component.css']
})

export class TaskDetailComponent implements OnInit {
   task: Task;   
   employees: Employee[] = [];
   department: Department;

  constructor(
    private route: ActivatedRoute,
    private taskService: TaskService,
    private departmentService: DepartmentService,
    private employeeService: EmployeeService,
    private location: Location
  ) {}

  ngOnInit(): void {
    this.getTask();
  }
  
  getTask(): void {
    const id = +this.route.snapshot.paramMap.get('id');
    this.taskService.getTasks()
      .subscribe(task => {
       for(let i =0; i< task.length;i++){
         if(task[i].id == id){
           this.task=task[i];
         }
       } 
       
       this.departmentService.getDepartments().subscribe(x => {
           
        for(let i =0; i< x.length;i++){
          if(x[i].id == this.task.department_id){
            this.department=x[i];
          }
        }

        this.employeeService.getEmployees().subscribe(y => {
          
        for(let i =0; i< y.length;i++){          
          for(let j =0; j< this.task.employees.length;j++){
            if(y[i].id == this.task.employees[j]){
              this.employees.push(y[i]);
            }
          }
        }

        });

       });


      });
  }

  onRemove(task: Task): void {
    if(confirm("Are you sure?")) {
      this.taskService.onRemove(this.task).subscribe(()=> this.goBack());
      alert('You Successfully Removed The Task!');
    }
  }

  onUpdate(): void {
    this.taskService.onUpdate(this.task).subscribe(()=> this.goBack());
  }

  goBack(): void {
    this.location.back();
  }
}
