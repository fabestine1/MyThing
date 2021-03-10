create trigger max7
AFTER insert or update of mealname of ingredient

declare
	v_num	number(2);
begin
	select max(count(*))
	into v_num
	from ingredients
	group by mealname;
	
	if v_num>7 then
	  raise_appl....
	end if;
end;

create trigger max7
AFTER insert or update of mealname of ingredient

declare
	v_num	number(2);
	cursor c_ing is
		select mealname,count(*) NOI
		from ingredients
		group by mealname;
begin
	FOR r_ing IN c_ing loop
	  if r_ing.NOI>7 then
	    raise_application_error.....
	  end if;
	end loop
end;