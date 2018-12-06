-- CREATION BASE DE DONNEES DU PROJET C#

-- Creer une base de données (Ici = "Geppetto")

-- Création table "Product"

USE [Geppetto]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](100) NOT NULL,
	[Stock] [int] NULL,
	[LastAdd] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO


-- Création table "Ingredients" (Zone référencant chaque aliment et sa zone)

USE [Geppetto]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Ingredients](
	[IgId] [int] IDENTITY(1,1) NOT NULL,
	[IgName] [varchar](100) NOT NULL,
	[IgZone] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IgId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



-- Création table "DryArea" (Zone aliments secs)

USE [Geppetto]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DryArea](
	[DryID] [int] IDENTITY(1,1) NOT NULL,
	[IncDate] [date] NULL,
	[RottenDate] [date] NULL,
	[DryPID] [int] NULL,
	[StockD] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[DryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[DryArea]  WITH CHECK ADD FOREIGN KEY([DryPID])
REFERENCES [dbo].[Product] ([ProductID])
GO


-- Création table "ColdArea" (Zone aliments froids)

USE [Geppetto]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ColdArea](
	[ColdID] [int] IDENTITY(1,1) NOT NULL,
	[IncDate] [date] NULL,
	[RottenDate] [date] NULL,
	[ColdPID] [int] NULL,
	[StockC] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ColdID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[ColdArea]  WITH CHECK ADD FOREIGN KEY([ColdPID])
REFERENCES [dbo].[Product] ([ProductID])
GO


-- Création table "FrozenArea" (Zone aliments gelés)

USE [Geppetto]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[FrozenArea](
	[FrozenID] [int] IDENTITY(1,1) NOT NULL,
	[IncDate] [date] NULL,
	[RottenDate] [date] NULL,
	[FrozenPID] [int] NULL,
	[StockF] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[FrozenID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[FrozenArea]  WITH CHECK ADD FOREIGN KEY([FrozenPID])
REFERENCES [dbo].[Product] ([ProductID])
GO

-- VIder les caches auto_increment et reini à 0. A UTILISER 1 FOIS PAR TEST

DBCC CHECKIDENT('Product', RESEED, 0)
DBCC CHECKIDENT('DryArea', RESEED, 0)
DBCC CHECKIDENT('ColdArea', RESEED, 0)
DBCC CHECKIDENT('FrozenArea', RESEED, 0)

-- Remplir la table [Product]

insert into Product values ('Tomates',0,0)
insert into Product values ('Salades',0,0)
insert into Product values ('Pâtes',0,0)
insert into Product values ('Seiche',0,0)
insert into Product values ('Fromages',0,0)
insert into Product values ('Courgettes',0,0)
insert into Product values ('Aubergines',0,0)
insert into Product values ('Mascarpone',0,0)  

-- Remplur la table [Ingredients]

insert into Ingredients values ('Tomates','C')  
insert into Ingredients values ('Salades','C')  
insert into Ingredients values ('Pâtes','D')  
insert into Ingredients values ('Seiche','F')  
insert into Ingredients values ('Fromages','C')  
insert into Ingredients values ('Courgettes','C')  
insert into Ingredients values ('Aubergines','C')  
insert into Ingredients values ('Mascarpone','C')  

-- Trigger pour la table [Product]

/* Ce trigger lors de l'ajout d'un nouveau produit, nouvelle livraison, va mettre à jour le stock dans [Product] 
et ajouter l'enregistrement à la table de la zone attribuée (selon la zone du produit dans [Ingredients])
Pour chaque enregistrement et selon la zone, une date de mise en stock et de fin de validité est crée. 
L'ID (PID) dans chacune des tables correspondant aux zones se refère au produit (3 = Pâtes par exemple) */

USE [Geppetto]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TRIGGER [dbo].[trgAfterUpdate] ON [dbo].[Product]
FOR UPDATE
AS
DECLARE
--declare les vars de la table dans laquelle on va inserter/deleter/updater
@ProductID int, 
@ProductName varchar(100),
@StockINI int,
@StockP int,
@PdZone varchar(100),
@dateTODAY date = getDate(),
@dateDRY date = DATEADD(year, +1, GETDATE()),
@dateCOLD date = DATEADD(day, +3, GETDATE()),
@dateFROZ date = DATEADD(month, +1, GETDATE())

-- Active only if the 'Stock' column is altered
IF UPDATE(Stock)
BEGIN
	SELECT @StockINI = LastAdd from INSERTED 
	SELECT @StockP = Stock from INSERTED
	SELECT @ProductID = ProductID from INSERTED 
	SELECT @ProductName = ProductName from INSERTED 
	SELECT @PdZone = IgZone from Geppetto.dbo.Ingredients where @ProductName = IgName;
	IF @PdZone = 'D'
		INSERT INTO DryArea Values (@dateTODAY,@dateDRY, @ProductID, @StockINI)

	ELSE IF @PdZone = 'C'
		INSERT INTO ColdArea Values (@dateTODAY,@dateCOLD, @ProductID, @StockINI)

	ELSE IF @PdZone = 'F'
		INSERT INTO FrozenArea Values (@dateTODAY,@dateFROZ, @ProductID, @StockINI)

	ELSE
		Print('Error in INSERT method')
END

GO

ALTER TABLE [dbo].[Product] ENABLE TRIGGER [trgAfterUpdate]
GO

-- Requête utilisé pour ajouter des éléments (Le reste se met à jour avec le trigger)

<<<<<<< HEAD
UPDATE Product SET Stock = Stock + 5 /* Paramètre 1 */, LastAdd = 5 /* Paramètre 1 */ where ProductName = 'SEICHE' /* Paramètre 2 */
=======
--UPDATE Product SET Stock = Stock - 5 /* Paramètre 1 */, LastAdd = 5 /* Paramètre 1 */ where ProductName = 'SEICHE' /* Paramètre 2 */
>>>>>>> 7df35fccb5227a1e297c7eb05a54375ba78acc86

--SUITE A VENIR LORS DE LA CREATION D'UN TRIGGER QUI SUPPRIME LORSQUE UN ELEMENT EST PERIMEE
--La requête qui recupère l'élément pour une recette ayant la date de peremption la plus proche

UPDATE DryArea SET StockD = StockD - 1 /* paramètre 1 */ WHERE DryPID = 3 /* paramètre 2 */ AND RottenDate = (SELECT MAX (RottenDate) FROM DryArea)
