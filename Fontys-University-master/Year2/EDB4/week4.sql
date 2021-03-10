--1
create or replace procedure set_death_age
        (namePres in varchar2,
        age in number)
is
        cursor pres_den is
            select *
            from President;
begin 
    for pres in pres_den LOOP
        if(pres.pres_name = namePres and pres.death_age is null) THEN
            update President
            set death_age = age
            where pres_name = namePres;
        elsif(pres.pres_name = namePres and pres.death_age is not null) then
            pr('This given president is already death!');
        END IF;
    END LOOP;       
end set_death_age;

--2
create or replace procedure new_hobby(namePres in varchar2, hobby in varchar2)
is        
hasPresident BOOLEAN := false;
hashobby BOOLEAN := false;

    cursor all_presidents is
        select *
        from president;

    cursor all_hobbies is
        select *
        from pres_hobby;
                
begin 
         
    for pres in all_presidents LOOP
        if(pres.pres_name = namePres) then
            hasPresident := true;
            pr('ok');
        END IF;
    END LOOP;  
    
    if(hasPresident)then        
            for hob in all_hobbies LOOP
                if(hob.hobby = hobby) then
                    hashobby := true;
                end if;
            END LOOP;
            
            if (hashobby) then
                    INSERT INTO pres_hobby(pres_name, hobby) VALUES (namePres, hobby);
            else 
                    pr('This hobby does not exist');
            end if;
    else
            pr('There is no such president!');
    end if;
end new_hobby;

--3
create or replace function AGE_PRESIDENTrr(namePres in varchar2, year_inaugurated in number)
return number
is        
YearInaugurated number := 0;

    cursor all_presidents is
        select *
        from president;
begin 
         
    select year_inaugurated
    into YearInaugurated
    from administration
    where pres_name = namePres;
    
    for pres in all_presidents LOOP
        if(pres.pres_name = namePres) then
            YearInaugurated := YearInaugurated - pres.birth_yr;
        END IF;
    END LOOP;  
    
    return YearInaugurated;
    
end AGE_PRESIDENTrr;
