SELECT ProductName, CategoryName
FROM (SELECT Products.ProductName, 
				 ProductCategories.ProductId, 
				 ProductCategories.CategoryId 
	  FROM Products
      LEFT JOIN ProductCategories ON Products.ProductId = ProductCategories.ProductId) as PC
LEFT JOIN Categories ON Categories.CategoryId = PC.CategoryId
