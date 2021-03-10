import { Component, OnInit, Input } from '@angular/core'
import { Employee } from '../employee';

@Component({
  selector: 'app-employee-detail',
  templateUrl: './employee-detail.component.html',
  styleUrls: ['./employee-detail.component.css']
})

export class EmployeeDetailComponent implements OnInit {
  @Input() selectedEmployee: Employee;
  @Input() selectedUpdate: Employee;
  @Input() selectedView: Employee;

  constructor() { }

  ngOnInit() {
  }

}
