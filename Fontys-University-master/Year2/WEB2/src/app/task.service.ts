import { Injectable } from '@angular/core';
import { Task } from './task';
import { Observable, of } from 'rxjs';
import { MessageService } from './message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';
  
import { catchError, map, tap } from 'rxjs/operators';

const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'})};

@Injectable({
  providedIn: 'root'
})

export class TaskService {

  private tasksUrl = 'http://i875395.hera.fhict.nl/api/378522/task';  // URL to web api

  constructor(private messageService: MessageService, private http: HttpClient) { }
  

  getTasks(): Observable<Task[]> {
    this.messageService.add('TaskService: fetched tasks');
   return this.http.get<Task[]>(this.tasksUrl)
      .pipe(
        tap(tasks => this.log('fetched tasks')),
        catchError(this.handleError('getTasks', []))
      );
  }

  onUpdate(task: Task): Observable<any> {
    this.messageService.add('TaskService: Updated Task');
    let url = 'http://i875395.hera.fhict.nl/api/378522/task?id=' + task.id;
    return this.http.put(url, task);
  }
  
  onClick(task: Task): Observable<Task> {
    console.log(task.employees);
    return this.http.post<Task>('http://i875395.hera.fhict.nl/api/378522/task', { department_id: task.department_id, 
    name: task.name, employees: task.employees,  due_date: task.due_date }, httpOptions);
    //'2018-02-01 15:22:02'
  }

  onRemove(task: Task): Observable<Task> {
    this.messageService.add('TaskService: Removed Task');
    const id  = typeof task === 'number' ? task : task.id;
    const url = 'http://i875395.hera.fhict.nl/api/378522/task?id=' + id;
    return this.http.delete<Task>(url, httpOptions);
  }

  searchTasks(term: string): Observable<Task[]> {
    /*if (!term.trim()) {
      // if not search term, return empty hero array.
      return of([]);
    }
    return this.http.get<Task[]>(`${this.tasksUrl}/?name=${term}`).pipe(
      tap(_ => this.log(`found tasks matching "${term}"`)),
      catchError(this.handleError<Task[]>('searchTasks', []))
    );*/

    if(!term.trim()) {
      return of([]);  
  }
  let suggestedDeps : Task[] = [];
  this.getTasks().subscribe(data =>{
       for (let index = 0; index < data.length; index++) {
         const element = data[index];
         if(element.name.search(term) != -1) {
           suggestedDeps.push(element);
         }
       }
     })
     return of(suggestedDeps);
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  /** Log a HeroService message with the MessageService */
  private log(message: string) {
    this.messageService.add(`TaskService: ${message}`);
  }
}
