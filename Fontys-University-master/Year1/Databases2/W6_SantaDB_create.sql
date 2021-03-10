CREATE DATABASE IF NOT EXISTS EDB2;
USE EDB2;

-- this is comment

-- the following line will drop table Visit if it exists:
DROP TABLE IF EXISTS Visit;

-- drop Santa table if it exists:
DROP TABLE IF EXISTS Santa;

-- create table Santa with necessary atributes, data types and constraints:
CREATE TABLE Santa(
id 		int			NOT NULL,	-- will be used as PK. Therefore, must be NOT NULL.
Name 	varchar(50) NOT NULL,
Country varchar(50) NOT NULL,
Age 	int 		NULL,
CONSTRAINT pk_santa PRIMARY KEY (id),
CONSTRAINT check_sinterklaas CHECK (
	(name = 'sinterklaas' AND country = 'The Netherlands') OR name <> 'sinterklaas'),
CONSTRAINT CHECK (country IN ('Norway', 'Bulgaria', 'The Netherlands')),
CONSTRAINT check_age CHECK (age>100)
);

CREATE TABLE Visit(
id 		int 		NOT NULL,	-- will be used as PK. Therefore, must be NOT NULL.
Address varchar(50) NOT NULL,
HasBeenDetected int NOT NULL,
SantaID	int			NOT NULL,
CONSTRAINT pk_visit PRIMARY KEY (id), -- or we can create PK with auto generated constraint name by writing: PRIMARY KEY (id)
CONSTRAINT fk_santa_visit FOREIGN KEY (SantaID) REFERENCES Santa(id) -- or just: FOREIGN KEY (SantaID) REFERENCES Santa(id)
);