SET SERVEROUTPUT ON;

DECLARE
v_first NUMBER(8) := 0;
v_second NUMBER(8) := 1;

BEGIN
DBMS_OUTPUT.PUT_LINE(0);
DBMS_OUTPUT.PUT_LINE(1);
FOR Lcntr IN 1..30
LOOP
v_second := v_first + v_second;
DBMS_OUTPUT.PUT_LINE(v_second);
v_first := v_second - v_first;
END LOOP;

END;