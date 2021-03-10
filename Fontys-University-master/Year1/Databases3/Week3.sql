select l.LOCATION_ID, l.STREET_ADDRESS, l.CITY, l.STATE_PROVINCE, c.COUNTRY_NAME
from LOCATIONS l
join COUNTRIES c on l.COUNTRY_ID = c.COUNTRY_ID;

select e.LAST_NAME, e.DEPARTMENT_ID, d.DEPARTMENT_NAME
from employees e
LEFT JOIN departments d
on d.DEPARTMENT_ID = e.DEPARTMENT_ID;

select e.LAST_NAME, e.DEPARTMENT_ID, d.DEPARTMENT_NAME
from employees e
LEFT JOIN departments d
on d.DEPARTMENT_ID = e.DEPARTMENT_ID
JOIN LOCATIONS l
on l.location_id = d.location_id
where l.city = 'Toronto';

select e.LAST_NAME, e.EMPLOYEE_ID as Emp#, m.LAST_NAME, m.EMPLOYEE_ID as Mgr#
from employees e
JOIN employees m
on m.MANAGER_ID = e.EMPLOYEE_ID;

select e.LAST_NAME, e.EMPLOYEE_ID as Emp#, m.LAST_NAME, m.EMPLOYEE_ID as Mgr#
from employees e
LEFT JOIN employees m
on m.MANAGER_ID = e.EMPLOYEE_ID;

select e.LAST_NAME, e.HIRE_DATE
from employees e join employees d
on d.LAST_NAME = 'Davies'
where e.HIRE_DATE > d.HIRE_DATE;

select e.LAST_NAME, e.HIRE_DATE, m.LAST_NAME, m.HIRE_DATE
from employees e
JOIN employees m
on m.MANAGER_ID = e.EMPLOYEE_ID
where e.HIRE_DATE > m.HIRE_DATE;