select * from dbo.Product
insert into dbo.Product([Name],[BrandName],[Price],[Count],[IsActivate])
values('millk','mahsham',15000,0,1)

update dbo.Product Set[Name] = 'Cocomilk' where [Id] = 3

delete dbo.Product where[Id] = 6