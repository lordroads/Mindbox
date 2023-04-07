CREATE TABLE Products
(
    Id INT PRIMARY KEY IDENTITY (1, 1), 
    NAME nvarchar(128) not null
);
 
CREATE TABLE Categories
(
    Id INT PRIMARY KEY IDENTITY (1, 1), 
    NAME nvarchar(128) not null
);
 
CREATE TABLE ProductCategories
(
    Id INT PRIMARY KEY IDENTITY (1, 1), 
    ProductId int,
    CategoryId int
);

INSERT INTO Products
    ([name])
VALUES
    ('��� ������������'),
    ('���������'),
    ('������ �������'),
    ('����� � ��������'),
	('���� ��� ������')
;
 
INSERT INTO Categories
    ([name])
VALUES
    ('�������'),
    ('�����'),
    ('������� ��������')
;
 
INSERT INTO ProductCategories
  ([ProductId],[CategoryId])
VALUES
  (1,1),
  (2,2),
  (3,3),
  (3,2),
  (4,3)
;