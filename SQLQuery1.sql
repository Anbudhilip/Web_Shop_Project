
create procedure del_category (
@id int ) as begin 
delete  from tbl_Category where cat_id=@id
end

 exec del_seller 1
 
 create procedure del_medicines (
@id int ) as begin 
delete  from tbl_Medicines where med_id=@id
end

drop

create procedure del_seller (
@id int ) as begin 
delete  from tbl_Seller where id=@id
end
 select * from tbl_Category

 create table admin
( id int primary key,
admin_Name varchar (50),
password varchar(50) )

insert into admin values(1, 'admin', 'admin')

alter procedure admin_login(
@uname varchar(50),
@pwd varchar(50)) as begin select admin_Name,password from admin where admin_Name=@uname and password=@pwd
end

exec admin_login admin,admin

update admin set admin_Name='admin',password='pass'


select count(id) from tbl_Seller 
select count(med_id) from tbl_Medicines
select count(cat_id) from tbl_Category
select count(b_id) from tbl_Bill
select sum(b_amount)from tbl_Bill
select * from admin
create procedure  seller_login(
@uname varchar(50),
@pwd varchar(50)) as begin select fullName,password from tbl_Seller where fullName=@uname and password=@pwd
end
exec seller_login 'ANBUVEL D',123
select * from tbl_Seller