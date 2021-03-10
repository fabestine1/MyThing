/* 
	implementation of the tables
*/



CREATE TABLE PRESIDENT 
	  (PRES_NAME                     VARCHAR2(20) NOT NULL,                                                                                                                           
	   BIRTH_YR                      NUMBER(4)
					 CONSTRAINT CHECK_BIRTH_YR 
					 	CHECK (BIRTH_YR BETWEEN 1600 AND 2100),                                                                                                                                                        
	   YRS_SERV                      NUMBER(2),                                                                                                                                                        
	   DEATH_AGE                     NUMBER(2) 
					 CONSTRAINT CHECK_DEATH_AGE
						CHECK (DEATH_AGE > 20 OR DEATH_AGE IS NULL),                                                                                                                                                        
	   PARTY                         VARCHAR2(10),                                                                                                                                                       
	   STATE_BORN                    VARCHAR2(15),
	   CONSTRAINT PRIM_KEY_PRES      PRIMARY KEY (PRES_NAME)
	  );
CREATE TABLE ELECTION  
	  (ELECTION_YEAR                 NUMBER(4) NOT NULL 
					 CONSTRAINT CHECK_ELECTION_YEAR
						CHECK (ELECTION_YEAR BETWEEN 1600 AND 2100),                                                                                                                             
	   CANDIDATE                     VARCHAR2(20) NOT NULL,                                                                                                                                               
	   VOTES                         NUMBER(3)
					 CONSTRAINT CHECK_VOTES CHECK (VOTES > 0),                                                                                                                                                        
	   WINNER_LOSER_INDIC            CHAR(1)
						CONSTRAINT CHECK_WINNER_LOSER_INDIC 
						CHECK (WINNER_LOSER_INDIC = 'W' OR 
						       WINNER_LOSER_INDIC = 'L'),
	   CONSTRAINT PRIM_KEY_ELEC      PRIMARY KEY (ELECTION_YEAR,CANDIDATE)
	  );                            
CREATE TABLE PRES_MARRIAGE 
	  (PRES_NAME                     VARCHAR2(20) NOT NULL,                                                                                                                       
	   SPOUSE_NAME                   VARCHAR2(20) NOT NULL,                                                                                                                                               
	   PR_AGE                        NUMBER(2)
					 CONSTRAINT CHECK_PR_AGE CHECK (PR_AGE > 15),                                                                                                                                                        
	   SP_AGE                        NUMBER(2)
					 CONSTRAINT CHECK_SP_AGE CHECK (SP_AGE > 15),                                                                                                                                                        
	   NR_CHILDREN                   NUMBER(2),                                                                                                                                                        
	   MAR_YEAR                      NUMBER(4)
					 CONSTRAINT CHECK_MAR_YEAR 
						CHECK (MAR_YEAR BETWEEN 1600 AND 2100),
           CONSTRAINT PRIM_KEY_PRESMAR   PRIMARY KEY (PRES_NAME,SPOUSE_NAME)
	  );
CREATE TABLE ADMINISTRATION 
	  (ADMIN_NR                      NUMBER(2) NOT NULL,                                                                                                                       
	   PRES_NAME                     VARCHAR2(20) NOT NULL,                                                                                                                                               
	   YEAR_INAUGURATED              NUMBER(4)
					 CONSTRAINT CHECK_YEAR_INAUG 
						CHECK (YEAR_INAUGURATED BETWEEN 1600 AND 2100),
	   CONSTRAINT PRIM_KEY_ADM       PRIMARY KEY (ADMIN_NR,PRES_NAME)                                                                                                                                                       
	  );			   
CREATE TABLE ADMIN_PR_VP
          (ADMIN_NR                      NUMBER(2) NOT NULL,                                                                                                                          
	   PRES_NAME                     VARCHAR2(20) NOT NULL,                                                                                                                                               
	   VICE_PRES_NAME                VARCHAR2(20) NOT NULL,
	   CONSTRAINT PRIM_KEY_ADMVP     PRIMARY KEY (ADMIN_NR,PRES_NAME,VICE_PRES_NAME)		                                                                                                                                                 
          );                                                                                                                                                                                                                              
CREATE TABLE STATE
          (STATE_NAME                    VARCHAR2(15) NOT NULL,                                                                                                                               
	   ADMIN_ENTERED                 NUMBER(2),                                                                                                                                                        
	   PRESNAME_ENTERED		 VARCHAR2(20),		
	   YEAR_ENTERED                  NUMBER(4)
					 CONSTRAINT CHECK_YEAR_ENTERED
						CHECK (YEAR_ENTERED BETWEEN 1600 AND 2100),
	   CONSTRAINT PRIM_KEY_STATE     PRIMARY KEY (STATE_NAME)
	  );
CREATE TABLE PRES_HOBBY
	  (PRES_NAME                     VARCHAR2(20) NOT NULL,                                                                                                                          
	   HOBBY                         VARCHAR2(20) NOT NULL,
           CONSTRAINT PRIM_KEY_HOBBY     PRIMARY KEY (PRES_NAME,HOBBY)
          );                                                                                                                                                                                                                                                      


CREATE VIEW RECENT_PRESIDENTS AS                                                             
select *                                                                                     
from president                                                                               
where birth_yr > '1880';                                                                                                                                            

