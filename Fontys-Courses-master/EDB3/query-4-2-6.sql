SELECT EMPLOYEE_ID, LAST_NAME, JOB_ID, DEPARTMENT_ID FROM EMPLOYEES e WHERE NOT EXISTS (SELECT 'X' FROM EMPLOYEES WHERE MANAGER_ID = e.EMPLOYEE_ID);