SET SERVEROUTPUT ON;

DECLARE
v_name EMPLOYEES.last_name%TYPE := '&last_name';
employee EMPLOYEES%ROWTYPE;

BEGIN

SELECT *
INTO employee
FROM EMPLOYEES
WHERE last_name = v_name;

DBMS_OUTPUT.PUT_LINE('ID: ' || employee.employee_id);
DBMS_OUTPUT.PUT_LINE('First name: ' || employee.first_name);
DBMS_OUTPUT.PUT_LINE('Last name: ' || employee.last_name);
DBMS_OUTPUT.PUT_LINE('Phone: ' || employee.phone_number);
DBMS_OUTPUT.PUT_LINE('Department ID: ' || employee.department_id);

EXCEPTION
WHEN NO_DATA_FOUND THEN
DBMS_OUTPUT.PUT_LINE('No employee with that last name is found.');
WHEN TOO_MANY_ROWS THEN
DBMS_OUTPUT.PUT_LINE('More than one employee with that last name is found.');

END;