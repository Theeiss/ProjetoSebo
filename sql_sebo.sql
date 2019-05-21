create schema db_sebo;
use db_sebo;

create table usuario(
	id int(4) auto_increment not null,
	login varchar(10) not null,
	senha varchar(30) not null,
    primary key (id)
);