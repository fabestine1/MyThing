SET SERVEROUTPUT ON;
CREATE OR REPLACE PROCEDURE state_presidents(p_state_born IN VARCHAR2)
IS
sql_statement VARCHAR2(1000);
BEGIN

sql_statement := 'INSERT INTO temp_state_presidents
SELECT * FROM PRESIDENT
WHERE STATE_BORN = ''' || p_state_born || '''';

EXECUTE IMMEDIATE sql_statement;

FOR pres IN (SELECT * FROM temp_state_presidents) LOOP
    DBMS_OUTPUT.PUT_LINE(pres.PRES_NAME);
END LOOP;

END state_presidents;
/