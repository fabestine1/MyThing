SELECT LAST_NAME "Employee", SALARY "MonthlySalary" FROM EMPLOYEES WHERE SALARY BETWEEN 5000 AND 12000 AND DEPARTMENT_ID IN (20, 50) ORDER BY LAST_NAME;