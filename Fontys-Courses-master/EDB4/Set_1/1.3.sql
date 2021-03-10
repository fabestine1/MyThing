DECLARE
v_to_multiply NUMBER(4) := '&What_number';
x NUMBER(2) := 0;

BEGIN

DBMS_OUTPUT.PUT_LINE('With a basic loop:');

LOOP

x := x + 1;
DBMS_OUTPUT.PUT_LINE(x || ' * ' || v_to_multiply || ' = ' || x*v_to_multiply);

IF x = 10 THEN
exit;
END IF;

END LOOP;

x := 0;
DBMS_OUTPUT.PUT_LINE('With a while loop:');
WHILE x < 10
LOOP
x := x + 1;
DBMS_OUTPUT.PUT_LINE(x || ' * ' || v_to_multiply || ' = ' || x*v_to_multiply);
END LOOP;

x := 0;
DBMS_OUTPUT.PUT_LINE('With a for loop:');
FOR Lcntr IN 1..10
LOOP
DBMS_OUTPUT.PUT_LINE(Lcntr || ' * ' || v_to_multiply || ' = ' || Lcntr*v_to_multiply);
END LOOP;

END;
