CREATE OR REPLACE TRIGGER PRESIDENT_HOBBIES_CHECK
BEFORE INSERT ON PRES_HOBBY
FOR EACH ROW
DECLARE
    numberOfHobbies NUMBER(1);
BEGIN
    SELECT COUNT(*) INTO numberOfHobbies
    FROM PRES_HOBBY
    WHERE PRES_NAME = :NEW.PRES_NAME;
    
    IF (numberOfHobbies > 5) THEN
        RAISE_APPLICATION_ERROR(-20003, 'The maximum number of president hobbies cannot exceed 5.');
    END IF;
END;
/