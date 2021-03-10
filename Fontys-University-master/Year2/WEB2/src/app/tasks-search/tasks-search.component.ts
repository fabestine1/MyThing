import { Component, OnInit } from '@angular/core';

import { Observable, Subject } from 'rxjs';

import {
   debounceTime, distinctUntilChanged, switchMap
 } from 'rxjs/operators';

import { Task } from '../task';
import { TaskService } from '../task.service';

@Component({
  selector: 'app-tasks-search',
  templateUrl: './tasks-search.component.html',
  styleUrls: [ './tasks-search.component.css' ]
})
export class TasksSearchComponent implements OnInit {
  tasks$: Observable<Task[]>;
  private searchTerms = new Subject<string>();

  constructor(private taskService: TaskService) {}

  // Push a search term into the observable stream.
  search(term: string): void {
    this.searchTerms.next(term);
  }

  ngOnInit(): void {
    this.tasks$ = this.searchTerms.pipe(
      // wait 300ms after each keystroke before considering the term
      debounceTime(300),

      // ignore new term if same as previous term
      distinctUntilChanged(),

      // switch to new search observable each time the term changes
      switchMap((term: string) => this.taskService.searchTasks(term)),
    );
  }
}


/*
Copyright 2017-2018 Google Inc. All Rights Reserved.
Use of this source code is governed by an MIT-style license that
can be found in the LICENSE file at http://angular.io/license
*/