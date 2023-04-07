SELECT product.name AS Products, category.name AS Category FROM Mindbox.dbo.Products product 
LEFT JOIN Mindbox.dbo.ProductCategories productCategory ON product.Id = [ProductId]
LEFT JOIN Mindbox.dbo.Categories category ON [CategoryId] = category.Id
