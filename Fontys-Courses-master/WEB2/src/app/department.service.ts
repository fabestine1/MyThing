import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Department } from './department';
import { MessageService } from './message.service';
import { HttpClient, HttpHeaders } from '@angular/common/http';


import { catchError, map, tap } from 'rxjs/operators';


const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json'})};

@Injectable({
  providedIn: 'root'
})
export class DepartmentService {

  private departmentsUrl = 'http://i875395.hera.fhict.nl/api/378522/department';

  constructor(private messageService: MessageService, private http: HttpClient) { }

  getDepartments (): Observable<Department[]> {
    return this.http.get<Department[]>(this.departmentsUrl)
      .pipe(
        tap(departments => this.log('fetched tasks')),
        catchError(this.handleError('getHeroes', []))
      );
  }

  getDepartment(id: number): Observable<Department> {
    const url = `${this.departmentsUrl}?id=${id}`;
    return this.http.get<Department>(url).pipe(
      tap(_ => this.log(`fetched department id=${id}`)),
      catchError(this.handleError<Department>(`getDepartment id=${id}`))
    );
  }

  /*getDepartments(): Observable<Department[]> {
    this.messageService.add('DepartmentService: fetched departments');

    //this.http.get<Department[]>('http://i875395.hera.fhict.nl/api/378522/department').subscribe(d => this.departmentArray = d);    
    return this.http.get<Department[]>('http://i875395.hera.fhict.nl/api/378522/department');
    //return of(this.departmentArray);
  }*/
  
  
  onUpdate(department: Department): Observable<any> {
    this.messageService.add('DepartmentService: Updated Department');
    let url = 'http://i875395.hera.fhict.nl/api/378522/department?id=' + department.id;
    return this.http.put(url, department);

  }

  onClick(department: Department): Observable<Department> {
    return this.http.post<Department>('http://i875395.hera.fhict.nl/api/378522/department', { department_id:
     department.id, name: department.name, building: department.building, employees: department.employees }, httpOptions);
  }

  onRemove(department: Department): Observable<Department> {
    this.messageService.add('DepartmentService: Removed Department');
    const id  = typeof department === 'number' ? department : department.id;
    const url = 'http://i875395.hera.fhict.nl/api/378522/department?id=' + id;
    return this.http.delete<Department>(url, httpOptions);

  }

 /* searchDepartments(term: string): Observable<Department[]> {
    if (!term.trim()) {
      // if not search term, return empty hero array.
      return of([]);
    }
    return this.http.get<Department[]>(`${this.departmentsUrl}/?name=${term}`).pipe(
      tap(_ => this.log(`found departments matching "${term}"`)),
      catchError(this.handleError<Department[]>('searchDepartments', []))
    );
  }
  */
 public searchDepartment(term : string) : Observable<Department[]> {
  if(!term.trim()) {
      return of([]);
  }
  let suggestedDeps : Department[] = [];
  this.getDepartments().subscribe(data =>{
       for (let index = 0; index < data.length; index++) {
         const element = data[index];
         if(element.name.search(term) != -1) {
           suggestedDeps.push(element);
         }
       }
     })
     return of(suggestedDeps);
}

  private log(message: string) {
    this.messageService.add(`DepartmentService: ${message}`);
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
  getDepartmentNo404<Data>(id: number): Observable<Department> {
    const url = `${this.departmentsUrl}/?id=${id}`;
    return this.http.get<Department[]>(url)
      .pipe(
        map(departments => departments[0]), // returns a {0|1} element array
        tap(h => {
          const outcome = h ? `fetched` : `did not find`;
          this.log(`${outcome} department id=${id}`);
        }),
        catchError(this.handleError<Department>(`getDepartment id=${id}`))
      );
  }

} 
