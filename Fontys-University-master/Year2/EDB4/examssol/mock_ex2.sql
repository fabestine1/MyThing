create procedure ADDINGR
(p_MN IN	varchar2,
 p_PN	varchar2,
 p_QPP	number,
 p_OrderOfPrep number,
 p_message OUT varchar2)
is
	e_parent_not_found		exception;
	pragma exception_init(-2292,e_parent_not_found);
	v_count number(2);
begin
	/* checking max 7 */
	select count(*)
	into v_count
	from ingredients
	where mealname = p_MN;
	
	if v_count>7 then
	  p_message := 'Problem: more than 7...';
	  return;  -- stop execution of program and return to caller (nicely!!)
	end if;
	insert into ingredients
	values (p_mm,p_pn,p_qpp,p_Orderofprep);
	/* 2 ways of checking max 7
		1: make use of trigger from ex 3
		2: select count and check
	*/
	p_message := 'ok';
exception
		when dup_val_on_index then
			p_message := 'problem: already present';
		when e_parent_not_found then
			p_message := 'problem: no such meal';
		
end;