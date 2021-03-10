SET SERVEROUTPUT ON;

DECLARE
    CURSOR emp_cursor IS
    SELECT EMPLOYEE_ID, SALARY
    FROM EMPLOYEES
    ORDER BY SALARY;
    
    emp_record emp_cursor%ROWTYPE;
    total_salary_raise NUMBER(6) := 0;
    salary_raise NUMBER(6) := 0;

BEGIN
    OPEN emp_cursor;
    LOOP
        FETCH emp_cursor INTO emp_record;
        salary_raise := 0.05 * emp_record.SALARY;
        UPDATE EMPLOYEES SET SALARY = SALARY + salary_raise
        WHERE EMPLOYEE_ID = emp_record.EMPLOYEE_ID;
        ROLLBACK;
        EXIT WHEN total_salary_raise + salary_raise >= 15000;
        total_salary_raise := total_salary_raise + salary_raise;
    END LOOP;
    DBMS_OUTPUT.PUT_LINE('Number of raises: ' || emp_cursor%rowcount);
    DBMS_OUTPUT.PUT_LINE('Amount spent: ' || total_salary_raise);
    CLOSE emp_cursor;
END;