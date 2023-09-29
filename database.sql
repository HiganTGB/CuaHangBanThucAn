
CREATE DATABASE QuanLiBanThucAn
ON PRIMARY
(
	NAME = 'QuanlySV_PRI',
	FILENAME ='D:\Server\QuanLiBanThucAn\QuanLiBanThucAn.mdf',
	SIZE = 10MB,
	FILEGROWTH = 20 %,
	MAXSIZE = 50MB
)
lOG ON
(
	NAME = 'QuanlySV_LOG',
	FILENAME ='D:\Server\QuanLiBanThucAn\QuanLiBanThucAn.ldf',
	SIZE = 10MB,
	FILEGROWTH = 20 %,
	MAXSIZE = 20MB
)
use QuanLiBanThucAn
create table Role
(
	id int identity not null primary key,
	name nvarchar(max) not null,
	deleted bit default 0 not null,
	permission varchar(max) not null,
)
create table Account
(
	id int identity not null primary key,
	name nvarchar(max) not null,
	email varchar(max) not null,
	password varchar(max) not null,
	deleted bit default 0 not null,
	role_id int not null foreign key references Role(id)
)
create table TypeProduct
(
	id int identity not null primary key,
	name nvarchar(max) not null,
	deleted bit default 0 not null,
)
create table Product
(
	id int identity not null primary key,
	name nvarchar(max) not null,
	type_id int not null foreign key references  TypeProduct(id),
	price money not null,
	discount float not null check (discount >= 0 and discount <=100),
	stock int not null,
	deleted bit default 0 not null
)
create table Bill
(
	id int identity not null primary key,
	total money not null,
	pay money not null,
	change money not null,
	account_id int not null foreign key references account(id),
	date datetime not null default Getdate(),
)
create table BillDetail
(
	bill_id int not null foreign key references Bill(id),
	product_id int not null foreign key references Product(id),
	price money not null,
	discount float not null,
	quantity int not null,
	total money not null
)
CREATE FUNCTION func_Revenue
(
    @date DATE
)
RETURNS TABLE
AS
RETURN
(
    SELECT
        CAST(date AS date) as date,
		COALESCE(count(*),0) as billsale,
		COALESCE(sum(quantity),0) as quantity,
        COALESCE(SUM(b.total),0) AS total
    FROM Bill b join BillDetail d on d.bill_id=b.id
    WHERE CAST(date AS date)  = @date
	group by CAST(date AS date)
)