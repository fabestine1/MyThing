SELECT LAST_NAME, JOB_TITLE FROM EMPLOYEES, JOBS WHERE EMPLOYEES.JOB_ID = JOBS.JOB_ID AND MANAGER_ID IS NULL;