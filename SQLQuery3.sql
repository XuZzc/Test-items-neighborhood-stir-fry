use 
MenuManage
go
insert into ProType values('火锅'),('热菜'),('凉菜')
insert into Product values('珍珠八宝烩','1.jpg','108','八宝烩很好吃','1'),
                          ('东坡肉','8.jpg','88','东坡肉很好吃','2'),
						  ('凉拌三丝','9.jpg','48','凉拌三丝很好吃','3')
select * from ProType
select * from Product
DELETE FROM Product WHERE Prold =''
select * from ProType,Product where ProType.Typeld=Product.Typeld

