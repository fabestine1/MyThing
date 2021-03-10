import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { Observable, of } from 'rxjs';
import { catchError, map, tap } from 'rxjs/operators';

import { Employee } from './employee';
import { MessageService } from './message.service';

const httpOptions = {
  headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable({ providedIn: 'root' })
export class EmployeeService {

  private employeesUrl = 'http://i875395.hera.fhict.nl/api/378522/employee';  // URL to web api

  constructor(
    private http: HttpClient,
    private messageService: MessageService) { }

  /** GET employees from the server */
  getEmployees (): Observable<Employee[]> {
    return this.http.get<Employee[]>(this.employeesUrl)
      .pipe(
        tap(employees => this.log('fetched employees')),
        catchError(this.handleError('getEmployees', []))
      );
  }

  /** GET employee by id. Return `undefined` when id not found */
  getEmployeeNo404<Data>(id: number): Observable<Employee> {
    const url = `${this.employeesUrl}/?id=${id}`;
    return this.http.get<Employee[]>(url)
      .pipe(
        map(employees => employees[0]), // returns a {0|1} element array
        tap(h => {
          const outcome = h ? `fetched` : `did not find`;
          this.log(`${outcome} employee id=${id}`);
        }),
        catchError(this.handleError<Employee>(`getEmployee id=${id}`))
      );
  }

  /** GET employee by id. Will 404 if id not found */
  getEmployee(id: number): Observable<Employee> {
    const url = `${this.employeesUrl}?id=${id}`;
    return this.http.get<Employee>(url).pipe(
      tap(_ => this.log(`fetched employee id=${id}`)),
      catchError(this.handleError<Employee>(`getEmployee id=${id}`))
    );
  }

  /* GET employees whose name contains search term */
  searchEmployees(term : string) : Observable<Employee[]> {
    if(!term.trim()) {
        return of([]);
    }
    let suggestedEmployees : Employee[] = [];
    this.http.get<Employee[]>(`${this.employeesUrl}`).pipe(
      tap(_ => this.log(`found employees matching "${term}"`)),
      catchError(this.handleError<Employee[]>('searchEmployees', []))
    ).subscribe(data =>{
         for (let index = 0; index < data.length; index++) {
           const element = data[index];
           if(element.first_name.toLowerCase().indexOf(term.toLowerCase()) > -1 || element.last_name.toLowerCase().indexOf(term.toLowerCase()) > -1) {
             suggestedEmployees.push(element);
           }
         }
       })
       return of(suggestedEmployees);
}

  //////// Save methods //////////

  /** POST: add a new employee to the server */
  addEmployee (employee: Employee): Observable<Employee> {
    return this.http.post<Employee>(this.employeesUrl, employee, httpOptions).pipe(
      tap((employee: Employee) => this.log(`added employee w/ id=${employee.id}`)),
      catchError(this.handleError<Employee>('addEmployee'))
    );
  }

  /** DELETE: delete the employee from the server */
  deleteEmployee (employee: Employee | number): Observable<Employee> {
    const id = typeof employee === 'number' ? employee : employee.id;
    const url = `${this.employeesUrl}/?id=${id}`;

    return this.http.delete<Employee>(url, httpOptions).pipe(
      tap(_ => this.log(`deleted employee id=${id}`)),
      catchError(this.handleError<Employee>('deleteEmployee'))
    );
  }

  /** PUT: update the employee on the server */
  updateEmployee (employee: Employee): Observable<any> {
    const url = `${this.employeesUrl}?id=${employee.id}`;
    return this.http.put(url, employee, httpOptions).pipe(
      tap(_ => this.log(`updated employee id=${employee.id}`)),
      catchError(this.handleError<any>('updateEmployee'))
    );
  }

  /**
   * Handle Http operation that failed.
   * Let the app continue.
   * @param operation - name of the operation that failed
   * @param result - optional value to return as the observable result
   */
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

  /** Log a EmployeeService message with the MessageService */
  private log(message: string) {
    this.messageService.add(`EmployeeService: ${message}`);
  }
}
