/*1*/
Set serveroutput on
declare emprecords EMPLOYEES%RowType;

Begin   
    select * 
    into emprecords
    from employees
    where employee_id = &empid;
    DBMS_OUTPUT.put_line(emprecords.employee_id || ' ' || emprecords.first_name || ' ' || emprecords.salary);
        Exception 
        when NO_DATA_FOUND then 
        DBMS_OUTPUT.put_line('there is no such employee id');       
End;


/*2*/
Set serveroutput on
Begin   
    Update employees
    Set employees.salary = employees.salary  * 0.05 + employees.salary
    where department_id = &depid;
    DBMS_OUTPUT.put_line(SQL%ROWCOUNT);
        Exception 
        when NO_DATA_FOUND then 
        DBMS_OUTPUT.put_line('there is no such department id');       
End;


/*3*/
Set serveroutput on
Begin   
    SAVEPOINT sv1;
    
    DELETE FROM employees   
    WHERE employees.salary > 1000 and employees.salary < 4000;
    
    if(SQL%ROWCOUNT > 20) then
        DBMS_OUTPUT.put_line('Too much deleted... ' || SQL%ROWCOUNT);  
        ROLLBACK to sv1;
    else
        COMMIT; 
        DBMS_OUTPUT.put_line('Deleted rows: ' || SQL%ROWCOUNT);    d
    end if;
End;


/*4*/
Set serveroutput on
declare emprecords EMPLOYEES%RowType;

Begin   
    select * 
    into emprecords
    from EMPLOYEES
    where EMPLOYEES.last_name = '&emplastname';
    DBMS_OUTPUT.put_line(emprecords.first_name || ' ' || emprecords.last_name);
    
        Exception 
        when NO_DATA_FOUND then 
        DBMS_OUTPUT.put_line('there is no such employee with this lastname');
       
        when TOO_MANY_ROWS then 
        DBMS_OUTPUT.put_line('there more than one employee with this lastname');
End;