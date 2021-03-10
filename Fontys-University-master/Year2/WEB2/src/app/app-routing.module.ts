import { NgModule }             from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { DashboardComponent }   from './dashboard/dashboard.component';
import { EmployeesComponent }      from './employees/employees.component';
import { EmployeeDetailComponent }  from './employee-detail/employee-detail.component';
import { DepartmentsComponent }      from './department/department.component';
import { DepartmentDetailComponent }  from './department-detail/department-detail.component';
import { TasksComponent }      from './tasks/tasks.component';
import { TaskDetailComponent }  from './task-detail/task-detail.component';

const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: DashboardComponent },
  { path: 'employees/detail/:id', component: EmployeeDetailComponent },
  { path: 'employees', component: EmployeesComponent },
  { path: 'departments/detail/:id', component: DepartmentDetailComponent },
  { path: 'department', component: DepartmentsComponent },
  { path: 'tasks/detail/:id', component: TaskDetailComponent },
  { path: 'tasks', component: TasksComponent }
];
@NgModule({
  imports: [ RouterModule.forRoot(routes) ],
  exports: [ RouterModule ]
})
export class AppRoutingModule {}
