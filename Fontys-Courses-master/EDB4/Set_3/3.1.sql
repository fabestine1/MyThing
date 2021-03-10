SET SERVEROUTPUT ON;
ACCEPT jobid PROMPT 'Enter job id:';

DECLARE
jobid VARCHAR2(20) := UPPER('&jobid');
    CURSOR c_emp IS
        SELECT FIRST_NAME, LAST_NAME
        FROM EMPLOYEES
        WHERE JOB_ID = jobid
        ORDER BY LAST_NAME;
        
    emp_row c_emp%rowtype;
    
BEGIN
    OPEN c_emp;
    LOOP
        FETCH c_emp INTO emp_row;
        EXIT WHEN c_emp%NOTFOUND;
        DBMS_OUTPUT.PUT_LINE(emp_row.FIRST_NAME || ' ' || emp_row.LAST_NAME);
    END LOOP;
    CLOSE c_emp;
END;