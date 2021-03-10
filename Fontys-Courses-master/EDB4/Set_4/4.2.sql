CREATE OR REPLACE PROCEDURE add_president_hobby(name IN VARCHAR2, new_hobby IN VARCHAR2)
IS
    HOBBY_NOT_EXIST EXCEPTION;
    PRESIDENT_NOT_EXIST EXCEPTION;
    
    s_pres_name PRESIDENT.PRES_NAME%type;
    s_pres_hobby PRES_HOBBY.HOBBY%type;
    
    BEGIN
    
    SELECT COUNT(*) HOBBY INTO s_pres_hobby
    FROM PRES_HOBBY
    WHERE HOBBY = new_hobby;
    
    IF s_pres_hobby = 0 THEN
    RAISE HOBBY_NOT_EXIST;  
    END IF;
    
    SELECT COUNT(*) PRES_NAME INTO s_pres_name
    FROM PRESIDENT
    WHERE PRES_NAME = name;
    
    IF s_pres_name = 0 THEN
    RAISE PRESIDENT_NOT_EXIST;  
    END IF;
    
    INSERT INTO PRES_HOBBY (PRES_NAME, HOBBY) VALUES(name, new_hobby);
    
    DBMS_OUTPUT.PUT_LINE('New president hobby inserted.');
    
    EXCEPTION
    WHEN HOBBY_NOT_EXIST THEN
    DBMS_OUTPUT.PUT_LINE('The hobby does not exist.');
    WHEN PRESIDENT_NOT_EXIST THEN
    DBMS_OUTPUT.PUT_LINE('The president does not exist.');
    
END add_president_hobby;
/