import { Component, OnInit } from '@angular/core';
import { Task } from '../task';
import { TaskService } from '../task.service';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.css']
})
export class TasksComponent implements OnInit {
  tasks: Task[];
  addingTask: string;
  addingDepartment: string;
  addingDepartmentemployees: string;
  addingDueDate: string;
  
  constructor(private taskService: TaskService) { }

  ngOnInit() {
    this.getTasks();
  }
  
  getTasks(): void {
    this.taskService.getTasks()
        .subscribe(tasks => this.tasks = tasks);
  }
  
  onClick(): void {
    var text = this.addingDepartmentemployees.split(' ');
    let newarray: number[] = []; 

    text.forEach(element => {
      let a = Number(element);
      newarray.push(a);
    });
    
    let cTask: Task = {
      department_id: Number(this.addingDepartment),
      id: 0,
       name: this.addingTask,
        due_date: this.addingDueDate,
      employees: newarray
    }
    this.taskService.onClick(cTask).subscribe(t => this.tasks.push(t));
  }
}
 

