create database if not exists dblogin2a;
use dblogin2a;

create table if not exists usuarios(
	Id int auto_increment primary key,
    Nome varchar(50) not null,
    Email varchar(100) not null unique,
    SenhaHash varchar(255) not null,
    DataCriacao datetime default current_timestamp
);

select * from usuarios