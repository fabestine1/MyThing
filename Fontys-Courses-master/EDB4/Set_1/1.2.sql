SET SERVEROUTPUT ON;

DECLARE v_date VARCHAR2(100) := TO_CHAR(SYSDATE, 'day dd fmmonth year');

BEGIN

DBMS_OUTPUT.PUT_LINE('Tomorrow: ' || v_date);

END;