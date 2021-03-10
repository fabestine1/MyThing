CREATE TABLE job_grades
(Grade			CHAR(1) primary key
,Lowest_sal		NUMBER(6) not null
,Highest_sal	NUMBER(6) not null
);

insert into job_grades values('A',1000,2999);
insert into job_grades values('B',3000,5999);
insert into job_grades values('C',6000,9999);
insert into job_grades values('D',10000,14999);
insert into job_grades values('E',15000,24999);
insert into job_grades values('F',25000,40000);