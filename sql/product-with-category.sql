CREATE TABLE [Product]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	[Title] NVARCHAR(50) NOT NULL
);

CREATE TABLE [Category]
(
	[Id] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID() PRIMARY KEY,
	[Title] NVARCHAR(50) NOT NULL
);

CREATE TABLE [ProductCategory]
(
	[CategoryId] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	[ProductId] UNIQUEIDENTIFIER NOT NULL DEFAULT NEWID(),
	FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id]),
	FOREIGN KEY ([ProductId]) REFERENCES [Product] ([Id])
);


SELECT [Product].[Title] AS 'Продукт', [Category].[Title] AS 'Категория' FROM [Product]
LEFT JOIN [ProductCategory] ON [ProductCategory].[ProductId] = [Product].[Id]
LEFT JOIN [Category] ON [ProductCategory].[CategoryId] = [Category].[Id]