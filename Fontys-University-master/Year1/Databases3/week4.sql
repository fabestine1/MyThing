    --Part1
--2
select *
from employees
where salary > (select AVG(salary)
                from employees);
--3    
select *
from employees
where DEPARTMENT_ID > any (select DEPARTMENT_ID
                from employees
                where LAST_NAME like '%u%');
--4               
select *
from employees
where DEPARTMENT_ID in (select DEPARTMENT_ID
                from DEPARTMENTS
                where location_id = '1700');
                
--5                
select *
from employees
where MANAGER_ID in (select EMPLOYEE_ID
                from EMPLOYEES
                where LAST_NAME = 'King');
                
--6                
select *
from employees
where DEPARTMENT_ID in (select DEPARTMENT_ID
                from DEPARTMENTS
                where DEPARTMENT_NAME = 'Executive');
                
--7                
select *
from employeesp
where salary > (select AVG(salary)
                from employees e1
                where e1.employee_id IN (select e2.employee_id
                                        from employees e2
                                        where DEPARTMENT_ID in (select DEPARTMENT_ID
                                                                    from employees
                                                                    where LAST_NAME like '%u%')));
      
      --Part2      
--1
select *
from employees
where (DEPARTMENT_ID,salary) in (select DEPARTMENT_ID,salary
                                from employees e1
                                where commission_pct is not null);
                
--2
select *
from employees
where (commission_pct,salary) in (select commission_pct,salary
                                from DEPARTMENTS e1
                                where e1.LOCATION_ID = '1700');
                                
--3
select *
from employees
where (nvl(commission_pct,0),salary) in (select nvl(commission_pct,0),salary
                                        from employees e1
                                        where e1.LAST_NAME  = 'Kochhar')
 and LAST_NAME != 'Kochhar';
 
--4
select *
from employees
where salary > all (select salary
                from employees e1
                where e1.job_id  = 'SA_MAN')
order by salary desc;

--5
select *
from employees
where EMPLOYEE_ID in (select EMPLOYEE_ID
                    from DEPARTMENTS d
                    where LOCATION_ID in (select location_id
                                        from Locations
                                        where city like 'T%'));

--6
select last_name
from employees outer
where NOT EXISTS (select 'x'
                 from employees el
                 where manager_id = outer.employee_id); 
                          
--7
select *
from employees outer
where salary < (select AVG(salary)
                from employees
                where department_id = outer.DEPARTMENT_ID);
                
--8
select *
from employees outer
where EXISTS (select 'x'
                 from employees el
                 where department_id = outer.department_id
                 and hire_date > outer.hire_date
                 and salary > outer.salary); 
