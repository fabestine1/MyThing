SET SERVEROUTPUT ON;

DECLARE
    CURSOR dept_cursor IS
    SELECT DEPARTMENT_ID, DEPARTMENT_NAME
    FROM DEPARTMENTS;
    
    CURSOR emp_cursor(dept_id DEPARTMENTS.DEPARTMENT_ID%TYPE) IS
    SELECT FIRST_NAME, LAST_NAME
    FROM EMPLOYEES
    WHERE DEPARTMENT_ID = dept_id;


BEGIN
    FOR dept IN dept_cursor
    LOOP
        DBMS_OUTPUT.PUT_LINE(dept.DEPARTMENT_ID || ' ' || UPPER(dept.DEPARTMENT_NAME));
        FOR emp IN emp_cursor(dept.DEPARTMENT_ID)
        LOOP
        DBMS_OUTPUT.PUT_LINE(CHR(9) || '-- ' || emp.FIRST_NAME || ' ' || emp.LAST_NAME);
        END LOOP;
    END LOOP;
END;