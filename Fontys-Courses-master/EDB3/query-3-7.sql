SELECT d.FIRST_NAME || ' ' || d.LAST_NAME "Employee Name", d.HIRE_DATE "Employee Hire Date", af.FIRST_NAME || ' ' || af.LAST_NAME "Manager Name", af.HIRE_DATE "Manager Hire Date"
FROM EMPLOYEES d JOIN EMPLOYEES af ON af.EMPLOYEE_ID = d.MANAGER_ID WHERE d.HIRE_DATE < af.HIRE_DATE;