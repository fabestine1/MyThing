SET SERVEROUTPUT ON;

DECLARE
v_empno EMPLOYEES.EMPLOYEE_ID%TYPE := &which_empid;
employee EMPLOYEES%ROWTYPE;

BEGIN

SELECT *
INTO employee
FROM EMPLOYEES
WHERE employee_id = v_empno;

DBMS_OUTPUT.PUT_LINE('ID: ' || employee.employee_id);
DBMS_OUTPUT.PUT_LINE('First name: ' || employee.first_name);
DBMS_OUTPUT.PUT_LINE('Last name: ' || employee.last_name);
DBMS_OUTPUT.PUT_LINE('Phone: ' || employee.phone_number);
DBMS_OUTPUT.PUT_LINE('Department ID: ' || employee.department_id);

EXCEPTION
WHEN NO_DATA_FOUND THEN
DBMS_OUTPUT.PUT_LINE('No employee with that ID number is found');

END;