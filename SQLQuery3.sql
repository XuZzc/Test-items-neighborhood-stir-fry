use 
MenuManage
go
insert into ProType values('���'),('�Ȳ�'),('����')
insert into Product values('����˱���','1.jpg','108','�˱���ܺó�','1'),
                          ('������','8.jpg','88','������ܺó�','2'),
						  ('������˿','9.jpg','48','������˿�ܺó�','3')
select * from ProType
select * from Product
DELETE FROM Product WHERE Prold =''
select * from ProType,Product where ProType.Typeld=Product.Typeld

