USE [A_Zawodnicy]
GO

/****** Object:  Table [dbo].[zawodnicy]    Script Date: 11.05.2022 10:55:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[zawodnicyHistoria](
    id int IDENTITY(1,1) NOT NULL,
	idUzytkownika int not null,
	czasModyfikacji datetime2 not null, 
	typOperacji int, 

	[id_zawodnika] [int] NOT NULL,
	[id_trenera] [int] NULL,
	[imie] [varchar](255) NULL,
	[nazwisko] [varchar](255) NULL,
	[kraj] [varchar](255) NULL,
	[data_ur] [datetime] NULL,
	[wzrost] [int] NULL,
	[waga] [int] NULL,
 CONSTRAINT [PK_zawodnicyHistoria] PRIMARY KEY CLUSTERED 
(
	id ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


