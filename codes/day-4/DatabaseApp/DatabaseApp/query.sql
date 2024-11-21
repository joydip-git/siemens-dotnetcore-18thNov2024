--use siemensdatabase
create table categories(
	category_id int primary key identity(100,1) not null,
	category_name varchar(20) not null
)

create table products(
	product_id int primary key identity(100,1) not null,
	product_name varchar(50) not null,
	product_description varchar(max),
	price decimal(18,2) default(0),
	category_id int foreign key references categories(category_id)
)

insert into categories(category_name) values('laptop')
insert into categories(category_name) values('mobile')

insert into products(product_name,product_description,price,category_id) values('dell xps 15','new laptop from dell',120000,100)
insert into products(product_name,product_description,price,category_id) values('iPhone 16','new mobile from apple',160000,101)

select * from categories
select * from products