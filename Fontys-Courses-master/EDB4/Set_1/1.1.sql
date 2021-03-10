SET SERVEROUTPUT ON;

DECLARE v_name VARCHAR2(20) := '&What_is_your_name';

BEGIN

DBMS_OUTPUT.PUT_LINE('My name is ' || v_name || ' and my user account is: 380279.');

END;