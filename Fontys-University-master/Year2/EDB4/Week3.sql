SET SERVEROUTPUT ON

 /*1*/
declare
    cursor emp_job is
    select first_name, last_name
    from employees
    where upper(employees.job_id) = upper('&empjob')
    order by last_name asc; 
    
    emp_recond  emp_job%ROWTYPE;
begin
    open emp_job;
    LOOP
        FETCH emp_job into emp_recond;
        exit when emp_job%NOTFOUND;
        dbms_output.put_line(emp_recond.first_name || ' ' || emp_recond.last_name);
    END LOOP;
    close emp_job;
end;

 /*2*/
  
 declare 
    cursor emp_dep is
    select  d.department_id, d.department_name
    from departments d;     
        
    emp_recond  emp_dep%ROWTYPE;
    
    cursor emps is
    select  first_name, last_name,  department_id      
    from employees;
        
    employes  emps%ROWTYPE;
begin
    open emp_dep;
    LOOP
        FETCH emp_dep into emp_recond;
        exit when emp_dep%NOTFOUND;
        dbms_output.put_line(emp_recond.department_id || '-' || upper(emp_recond.department_name || ':'));
        
    open emps;
        LOOP
            FETCH emps into employes;
            exit when emps%NOTFOUND;
            
            if(employes.department_id = emp_recond.department_id)
            then dbms_output.put_line('-- ' || employes.last_name || ', ' || employes.first_name);  
            end if;
        END LOOP;
    close emps;
                    
    END LOOP;
    close emp_dep;
end;

 /*3*/
 

declare
    cursor emp_lowest_salary is
    select *
    from employees
    order by salary asc
    /*
    Update employees 
    set salary = salary * 0.05 + salary
    */
    emp_recond  emp_lowest_salary%ROWTYPE;
    totalsum number(23):= 0;
begin
    open emp_lowest_salary;
    LOOP
        FETCH emp_lowest_salary into emp_recond;
        exit when emp_lowest_salary%NOTFOUND;
        if totalsum >=15000
        rollback;
        else
        totalsum := emp_recond.salary + emp_recond.salary*0.05;
            Update employees 
            set salary = salary * 0.05 + salary
            where emloyee_id = emp_recond.employee_id;
    END LOOP;
        dbms_output.put_line(totalsum);
    close emp_job;
end;
