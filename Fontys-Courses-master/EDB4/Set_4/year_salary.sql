CREATE OR REPLACE FUNCTION get_year_salary(emp_id IN EMPLOYEES.EMPLOYEE_ID%TYPE)
RETURN NUMBER
IS
    s_salary EMPLOYEES.SALARY%TYPE;
    s_commission_pct EMPLOYEES.COMMISSION_PCT%TYPE;
    total_salary NUMBER(10);

BEGIN
    SELECT salary, NVL(commission_pct, 0) INTO s_salary, s_commission_pct
    FROM EMPLOYEES
    WHERE employee_id = emp_id;
    
    total_salary := (12 * s_salary) * (1 + s_commission_pct);
    
    RETURN total_salary;
    --DBMS_OUTPUT.PUT_LINE(total_salary);
END;
/