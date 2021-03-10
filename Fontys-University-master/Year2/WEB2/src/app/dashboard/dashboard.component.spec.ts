import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DashboardComponent } from './dashboard.component';
import { EmployeeSearchComponent } from '../employee-search/employee-search.component';

import { RouterTestingModule } from '@angular/router/testing';
import { of } from 'rxjs';
import { EMPLOYEES } from '../mock-employees';
import { EmployeeService } from '../employee.service';

describe('DashboardComponent', () => {
  let component: DashboardComponent;
  let fixture: ComponentFixture<DashboardComponent>;
  let employeeService;
  let getEmployeesSpy;

  beforeEach(async(() => {
    employeeService = jasmine.createSpyObj('EmployeeService', ['getEmployees']);
    getEmployeesSpy = employeeService.getEmployees.and.returnValue( of(EMPLOYEES) );
    TestBed.configureTestingModule({
      declarations: [
        DashboardComponent,
        EmployeeSearchComponent
      ],
      imports: [
        RouterTestingModule.withRoutes([])
      ],
      providers: [
        { provide: EmployeeService, useValue: employeeService }
      ]
    })
    .compileComponents();

  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DashboardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should be created', () => {
    expect(component).toBeTruthy();
  });

  it('should display "Top Employees" as headline', () => {
    expect(fixture.nativeElement.querySelector('h3').textContent).toEqual('Top Employees');
  });

  it('should call employeeService', async(() => {
    expect(getEmployeesSpy.calls.any()).toBe(true);
    }));

  it('should display 4 links', async(() => {
    expect(fixture.nativeElement.querySelectorAll('a').length).toEqual(4);
  }));

});
