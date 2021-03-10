/*
Nikolay Anatoliev Nikolaev
3235106
e-s32
*/

--Exercise 1a

SET SERVEROUTPUT ON;

DECLARE
    CURSOR c_managers IS
    SELECT DISTINCT MANAGER_ID
    FROM EMPLOYEES
    WHERE MANAGER_ID IS NOT NULL
    ORDER BY MANAGER_ID;
    
    CURSOR c_employees(man_id EMPLOYEES.MANAGER_ID%type) IS
    SELECT FIRST_NAME, LAST_NAME
    FROM EMPLOYEES
    WHERE MANAGER_ID = man_id
    ORDER BY FIRST_NAME, LAST_NAME;

BEGIN
    FOR M IN c_managers
    LOOP
        DBMS_OUTPUT.PUT_LINE(M.MANAGER_ID || ':');
        
        FOR E IN c_employees(M.MANAGER_ID)
        LOOP
            DBMS_OUTPUT.PUT_LINE(CHR(9) || '- ' || E.FIRST_NAME || ' ' || E.LAST_NAME);
        END LOOP;
    END LOOP;
END;
/

--Exercise 1b

SET SERVEROUTPUT ON;

DECLARE
    CURSOR c_managers IS
    SELECT m.MANAGER_ID, e.FIRST_NAME, e.LAST_NAME
    FROM EMPLOYEES m
    INNER JOIN EMPLOYEES e ON m.MANAGER_ID = e.EMPLOYEE_ID
    GROUP BY m.MANAGER_ID, e.FIRST_NAME, e.LAST_NAME
    ORDER BY m.MANAGER_ID;
    
    CURSOR c_employees(man_id EMPLOYEES.MANAGER_ID%type) IS
    SELECT FIRST_NAME, LAST_NAME
    FROM EMPLOYEES
    WHERE MANAGER_ID = man_id
    ORDER BY FIRST_NAME, LAST_NAME;
    
    employees_counter NUMBER(5) := 0;
    
BEGIN
    FOR M IN c_managers
    LOOP
        DBMS_OUTPUT.PUT_LINE(M.MANAGER_ID || ' ' || M.FIRST_NAME || ' ' || M.LAST_NAME || ':');
        
        FOR E IN c_employees(M.MANAGER_ID)
        LOOP
            employees_counter := employees_counter + 1;
            DBMS_OUTPUT.PUT_LINE(CHR(9) || employees_counter || ': ' || E.FIRST_NAME || ' ' || E.LAST_NAME);
        END LOOP;
        
        employees_counter := 0;
    END LOOP;
END;
/

--Exercise 2

CREATE OR REPLACE FUNCTION Dept_Emps(dep_id IN DEPARTMENTS.DEPARTMENT_ID%type)
RETURN NUMBER
IS
    emp_counter NUMBER(5);

BEGIN
    SELECT COUNT(*) INTO emp_counter
    FROM EMPLOYEES
    WHERE DEPARTMENT_ID = dep_id;
    
    RETURN emp_counter;
END Dept_Emps;
/

SELECT department_name, Dept_Emps(department_id) AS dept_emps
FROM DEPARTMENTS;

--Exercise 3

CREATE OR REPLACE TRIGGER SALARY_CHANGE_CHECK
AFTER UPDATE OF SALARY ON EMPLOYEES
FOR EACH ROW

BEGIN
    IF ABS(:NEW.SALARY - :OLD.SALARY) > 0.1 * :OLD.SALARY THEN
        RAISE_APPLICATION_ERROR(-20001, 'An employees salary may not be increase or decrease by more than 10%.');
    END IF;
END SALARY_CHANGE_CHECK;
/

--Exercise 4a

CREATE OR REPLACE PROCEDURE Emps_Per_City
(
p_city IN LOCATIONS.CITY%type,
p_num_emps OUT NUMBER
)
IS

BEGIN
    SELECT COUNT(*) INTO p_num_emps
    FROM EMPLOYEES e
    LEFT JOIN DEPARTMENTS d ON e.DEPARTMENT_ID = d.DEPARTMENT_ID
    LEFT JOIN LOCATIONS l ON d.LOCATION_ID = l.LOCATION_ID
    WHERE l.CITY = p_city;
END Emps_Per_City;
/

--Exercise 4b

/*
	For a specific city
*/

SET SERVEROUTPUT ON;

DECLARE
city VARCHAR(50) := '&What_city';
employees_count NUMBER(5);

BEGIN
Emps_Per_City(city, employees_count);
DBMS_OUTPUT.PUT_LINE('Employees working in ' || city || ': ' || employees_count);
END;
/

/*
	For all cities
*/

SET SERVEROUTPUT ON;

DECLARE
    CURSOR c_cities IS
    SELECT DISTINCT CITY
    FROM LOCATIONS
    GROUP BY CITY;

emps_count NUMBER(5);

BEGIN
    FOR C IN c_cities
    LOOP
        Emps_Per_City(C.CITY, emps_count);
        DBMS_OUTPUT.PUT_LINE('Employees working in ' || C.CITY || ': ' || emps_count);
    END LOOP;
END;
/