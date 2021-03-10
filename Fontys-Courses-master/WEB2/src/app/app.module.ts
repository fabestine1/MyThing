import { NgModule }       from '@angular/core';
import { BrowserModule }  from '@angular/platform-browser';
import { FormsModule }    from '@angular/forms';
import { HttpClientModule }    from '@angular/common/http';
import { AppRoutingModule }     from './app-routing.module';
import { AppComponent }         from './app.component';
import { DashboardComponent }   from './dashboard/dashboard.component';
import { EmployeeDetailComponent }  from './employee-detail/employee-detail.component';
import { EmployeesComponent }      from './employees/employees.component';
import { EmployeeSearchComponent }  from './employee-search/employee-search.component';
import { MessagesComponent }    from './messages/messages.component';
import { TasksComponent } from './tasks/tasks.component';
import { DepartmentsComponent } from './department/department.component';
import { DepartmentDetailComponent } from './department-detail/department-detail.component';
import { TaskDetailComponent } from './task-detail/task-detail.component';
import {NgbModule} from '@ng-bootstrap/ng-bootstrap';
import { DepartmentSearchComponent } from './department-search/department-search.component';
import { TasksSearchComponent } from './tasks-search/tasks-search.component';

@NgModule({
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule
  ],
  declarations: [
    AppComponent,
    DashboardComponent,
    EmployeesComponent,
    EmployeeDetailComponent,
    MessagesComponent,
    EmployeeSearchComponent,
    DepartmentsComponent,
    TasksComponent,
    DepartmentDetailComponent,
    TaskDetailComponent,
    DepartmentSearchComponent,
    TasksSearchComponent
  ],
  bootstrap: [ AppComponent ]
})
export class AppModule { }