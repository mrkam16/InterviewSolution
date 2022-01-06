create table CATEGORIES (
	ID int PRIMARY KEY IDENTITY(1,1),
	NAME varchar(80) not null	
);

create table PRODUCTS (
	ID int PRIMARY KEY IDENTITY(1,1),
	NAME varchar(80) not null
);

create table PRODUCTS_CATEGORIES (
	PRODUCT_ID int FOREIGN KEY REFERENCES PRODUCTS(ID),
	CATEGORY_ID int FOREIGN KEY REFERENCES CATEGORIES(ID)
);


insert into CATEGORIES values ('Not high-calorie'), ('Cool'), ('Hot');
insert into PRODUCTS values ('Milk'), ('Pepsi'), ('Lemon');
insert into PRODUCTS_CATEGORIES values (1,1), (1,2), (2,1);



--query
select P.NAME AS PRODUCT_NAME, ISNULL(C.NAME,'NO CATEGORY') AS CATEGORY_NAME 
		from CATEGORIES C 
			join PRODUCTS_CATEGORIES PC on C.ID = PC.CATEGORY_ID
			right join PRODUCTS P on P.ID = PC.PRODUCT_ID