SET SERVEROUTPUT ON;

DECLARE
v_number NUMBER(9) := &What_is_your_number;
r NUMBER(11) := 0;

BEGIN
FOR Lcntr IN REVERSE 1..9
LOOP
r := r + MOD(v_number, 10) * Lcntr;
v_number := v_number / 10;
END LOOP;

IF MOD(r, 11) = 0
THEN DBMS_OUTPUT.PUT_LINE('valid');
ELSE DBMS_OUTPUT.PUT_LINE('invalid');
END IF;

END;