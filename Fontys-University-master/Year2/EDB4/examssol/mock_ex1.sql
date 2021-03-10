declare
	v_meal	meal.mealname%type;
	
	v_TTP	meal.TimeToPrepare%type;
	v_MOP	meal.MannnerOfPrep%type;
	
	cursor c_ing(p_meal varchar2) is
		select *
		from ingredients
		where MealName=p_meal
		order by orderOfPrep;
	r_ing 	c_ing%rowtype;
begin
	v_meal := '&What_meal';
	
	Select TimeToPrepare,MannerOfPrep
	into v_TTP,v_MOP
	from meal
	where upper(MealName) = upper(v_meal);
	
	print(v_meal);
	print(v_ttp);
	print(v_mop);
	open c_ing(v_meal);
	loop
		fetch c_ing into r_ing;
		exit when c_ing%notfound;
		print(r_ing.productname||' '||r_ing.quntityPP);
	end loop;
	close c_ing;
exception
		when no_data_found then
		  print('No such meal');
end;
