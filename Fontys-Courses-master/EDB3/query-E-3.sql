SELECT PRES_NAME, BIRTH_YR FROM PRESIDENT WHERE DEATH_AGE < (SELECT MIN(DEATH_AGE) FROM PRESIDENT WHERE BIRTH_YR < 1800);