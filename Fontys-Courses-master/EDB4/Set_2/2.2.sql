SET SERVEROUTPUT ON;

DECLARE
v_deptid EMPLOYEES.department_id%TYPE := &what_department;
employee EMPLOYEES%ROWTYPE;

BEGIN

UPDATE EMPLOYEES
SET salary = salary + 0.05*salary
WHERE department_id = v_deptid;

DBMS_OUTPUT.PUT_LINE(SQL%ROWCOUNT || ' employees received a salary raise!');

EXCEPTION
WHEN NO_DATA_FOUND THEN
DBMS_OUTPUT.PUT_LINE('No employee with that ID number is found');

ROLLBACK;
END;