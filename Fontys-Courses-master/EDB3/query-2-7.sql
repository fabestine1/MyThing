SELECT LAST_NAME, HIRE_DATE, TO_CHAR(NEXT_DAY(ADD_MONTHS(HIRE_DATE, 6), 'MONDAY'), 'fmDay, "the" Ddspth "of" Month, fmYYYY') REVIEW FROM EMPLOYEES;