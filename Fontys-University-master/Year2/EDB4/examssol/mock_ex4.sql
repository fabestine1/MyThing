declare  -- stored procedure is also allowed
	cursor c_meal is
		select mealname
		from meal
		for update of energyPP;
		
	cursor c_ing(p_mn varchar2) is
		select quantitypp*energyPU EPU
		from ingredient join product on productname;
		
	v_energyPP meal.energypp%type;
begin

	for r_meal in c_meal loop
		v_energyPP  := 0;
		for r_ing in c_ing(r_meal.mealname) loop
			v_energyPP := v_energyPP + r_ing.EPU;
		end loop;
		update meal
		set energyPP = v_energyPP 
		where current of c_meal;
	end loop;
end;