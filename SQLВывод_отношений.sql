Use Library
go
Select Book_name, CatName from Relation join Books on Books.ID_book=Relation.ID_Book 
full outer join Category on Relation.ID_Cat=Category.id_Cat
--Relation представляет таблицу соответствий определенной книги и ее категории
 
