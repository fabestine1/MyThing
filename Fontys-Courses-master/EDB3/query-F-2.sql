SELECT PRES_NAME, BIRTH_YR FROM PRESIDENT WHERE PRES_NAME IN (SELECT PRES_NAME FROM PRES_HOBBY GROUP BY PRES_NAME HAVING COUNT (*) >= 4);