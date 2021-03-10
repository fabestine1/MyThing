import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TasksSearchComponent } from './tasks-search.component';

describe('TasksSearchComponent', () => {
  let component: TasksSearchComponent;
  let fixture: ComponentFixture<TasksSearchComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TasksSearchComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TasksSearchComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
