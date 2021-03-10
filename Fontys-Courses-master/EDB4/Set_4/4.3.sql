CREATE OR REPLACE FUNCTION AGE_PRESIDENT(president_name IN VARCHAR2, year_inaugurated IN NUMBER)
RETURN NUMBER
IS
    birth_year NUMBER(4);
BEGIN
    SELECT BIRTH_YR INTO birth_year
    FROM PRESIDENT
    WHERE PRES_NAME = president_name;
    
    RETURN year_inaugurated - birth_year;
END AGE_PRESIDENT;
/