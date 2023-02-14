create database bank
use bank

create table customer_master(
customer_number int primary key,
firstname varchar(20),
middlename varchar(20),
lastname varchar(20),
customer_city varchar(50),
customer_contact_no bigint,
occupation varchar(20),
customer_date_of_birth date
)

select * from customer_master

insert into customer_master values(100001,'Aakash','Kumar','Varma','delhi',7708016548,'IAS','2002-06-16')

select count(customer_number) as 'customers from delhi' from customer_master where  customer_city = 'delhi'
select count(customer_number) as 'customers from mumbai' from customer_master where  customer_city = 'mumbai'
select count(customer_number) as 'customers from kolkata' from customer_master where  customer_city = 'kolkata'
select count(customer_number) as 'customers from chennai' from customer_master where  customer_city = 'chennai'

select distinct (customer_city) from customer_master 

select count(customer_number) as 'employees in service' from customer_master where occupation='service'
select count(customer_number) as 'employees in house wife' from customer_master where occupation='house wife'
select count(customer_number) as 'no of students' from customer_master where occupation='student'

select * from customer_master order by firstname

select occupation,customer_date_of_birth from customer_master order by customer_date_of_birth desc

select firstname,occupation from customer_master order by firstname

select * from customer_master where middlename is null
