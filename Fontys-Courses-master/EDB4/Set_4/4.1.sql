CREATE OR REPLACE PROCEDURE set_death_age(name IN VARCHAR2, age IN NUMBER)
IS
    PRESIDENT_NOT_EXIST EXCEPTION;
    PRESIDENT_IS_DECEASED EXCEPTION;
    president_age NUMBER(3);
    
    BEGIN
    
        SELECT DEATH_AGE INTO president_age FROM PRESIDENT WHERE PRES_NAME = name;
    
        IF president_age IS NOT NULL THEN
            RAISE PRESIDENT_IS_DECEASED;
        END IF;
    
        UPDATE PRESIDENT
        SET DEATH_AGE = age
        WHERE PRES_NAME = name;
    
        DBMS_OUTPUT.PUT_LINE('President''s decease age is entered.');
    
    EXCEPTION
    WHEN NO_DATA_FOUND THEN
        DBMS_OUTPUT.PUT_LINE('The president does not exist.');
    WHEN PRESIDENT_IS_DECEASED THEN
        DBMS_OUTPUT.PUT_LINE('President is already deceased.');
    
END set_death_age;
/