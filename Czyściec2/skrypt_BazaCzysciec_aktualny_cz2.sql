/****** Object:  Table [dbo].[Autor]    Script Date: 01.12.2018 00:26:36 ******/
CREATE TABLE [dbo].[Autor](
	[IdAutora] [int] IDENTITY(1,1) NOT NULL,
	[Nick] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
	[Imie] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
	[Nazwisko] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
	[Haslo] [varchar](8000) COLLATE Polish_CI_AS NULL,
	[Poziom] [int] NULL,
 CONSTRAINT [PK_AUTOR] PRIMARY KEY CLUSTERED 
(
	[IdAutora] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Funkcjonalnosc]    Script Date: 01.12.2018 00:26:36 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Funkcjonalnosc](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
	[TypFunkcji] [int] NOT NULL,
	[Program] [int] NOT NULL,
 CONSTRAINT [PK_FUNKCJONALNOSC] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Klient]    Script Date: 01.12.2018 00:26:36 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Klient](
	[IdKlienta] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
 CONSTRAINT [PK_KLIENT] PRIMARY KEY CLUSTERED 
(
	[IdKlienta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Notatka]    Script Date: 01.12.2018 00:26:36 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Notatka](
	[IdNotatki] [int] IDENTITY(1,1) NOT NULL,
	[Wpis] [int] NOT NULL,
	[Tresc] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
	[DataCzasNotki] [datetime] NOT NULL,
	[Autor] [int] NOT NULL,
	[PriorytetNotatki] [int] NOT NULL,
	[Oddzwonic] [int] NOT NULL,
	[Klient] [int] NOT NULL,
 CONSTRAINT [PK_Notatka] PRIMARY KEY CLUSTERED 
(
	[IdNotatki] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Program]    Script Date: 01.12.2018 00:26:36 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Program](
	[IdProgramu] [int] IDENTITY(1,1) NOT NULL,
	[Nazwa] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
 CONSTRAINT [PK_Program] PRIMARY KEY CLUSTERED 
(
	[IdProgramu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Slowniki]    Script Date: 01.12.2018 00:26:36 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Slowniki](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[NazwaSlownika] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
	[IdElementu] [int] NOT NULL,
	[Element] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
 CONSTRAINT [PK_SLOWNIKI] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

/****** Object:  Table [dbo].[Wpis]    Script Date: 01.12.2018 00:26:36 ******/
SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE TABLE [dbo].[Wpis](
	[IdWpisu] [int] IDENTITY(1,1) NOT NULL,
	[TypZgloszenia] [int] NOT NULL,
	[DataCzasWpisu] [datetime] NOT NULL,
	[Autor] [int] NOT NULL,
	[Tresc] [varchar](8000) COLLATE Polish_CI_AS NOT NULL,
	[Stan] [int] NOT NULL,
	[PriorytetWpisu] [int] NOT NULL,
	[KiedyPrzekazaneWyzej] [datetime] NULL,
	[Funkcjonalnosc] [int] NOT NULL,
 CONSTRAINT [PK_Wpis_1] PRIMARY KEY CLUSTERED 
(
	[IdWpisu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

SET IDENTITY_INSERT [dbo].[Autor] ON 

INSERT [dbo].[Autor] ([IdAutora], [Nick], [Imie], [Nazwisko], [Haslo], [Poziom]) VALUES (1, N'Admin', N'Admin', N'Admin', N'C7-AD-44-CB-AD-76-2A-5D-A0-A4-52-F9-E8-54-FD-C1-E0-E7-A5-2A-38-01-5F-23-F3-EA-B1-D8-0B-93-1D-D4-72-63-4D-FA-C7-1C-D3-4E-BC-35-D1-6A-B7-FB-8A-90-C8-1F-97-51-13-D6-C7-53-8D-C6-9D-D8-DE-90-77-EC', 0)
SET IDENTITY_INSERT [dbo].[Autor] OFF
SET IDENTITY_INSERT [dbo].[Funkcjonalnosc] ON 

INSERT [dbo].[Funkcjonalnosc] ([Id], [Nazwa], [TypFunkcji], [Program]) VALUES (1, N'Paski do list', 10, 1)
SET IDENTITY_INSERT [dbo].[Funkcjonalnosc] OFF
SET IDENTITY_INSERT [dbo].[Klient] ON 

INSERT [dbo].[Klient] ([IdKlienta], [Nazwa]) VALUES (1, N'Bochnia DPS')
SET IDENTITY_INSERT [dbo].[Klient] OFF
SET IDENTITY_INSERT [dbo].[Program] ON 

INSERT [dbo].[Program] ([IdProgramu], [Nazwa]) VALUES (1, N'Kadry Płace')
INSERT [dbo].[Program] ([IdProgramu], [Nazwa]) VALUES (2, N'Środki Trwałe')
SET IDENTITY_INSERT [dbo].[Program] OFF
SET IDENTITY_INSERT [dbo].[Slowniki] ON 

INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (1, N'TypFunkcji', 10, N'WydrukKP')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (2, N'TypZgloszenia', 10, N'Błąd')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (3, N'Stan', 10, N'Przyjęte')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (4, N'Oddzwonic', 10, N'Tak')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (5, N'TypFunkcji', 20, N'Program Płace')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (6, N'TypFunkcji', 30, N'Program Kadry')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (7, N'Oddzwonic', 20, N'Nie')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (8, N'TypZgloszenia', 20, N'Sugestia')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (11, N'Stan', 90, N'Sprawa zamknięta')
INSERT [dbo].[Slowniki] ([Id], [NazwaSlownika], [IdElementu], [Element]) VALUES (12, N'Oddzwonic', 30, N'Może')
SET IDENTITY_INSERT [dbo].[Slowniki] OFF
SET ANSI_PADDING ON

/****** Object:  Index [UQ__Autor__7D3471B61E921DC6]    Script Date: 01.12.2018 00:26:36 ******/
ALTER TABLE [dbo].[Autor] ADD UNIQUE NONCLUSTERED 
(
	[Nick] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [UQ__Funkcjon__602223FF25BDB195]    Script Date: 01.12.2018 00:26:36 ******/
ALTER TABLE [dbo].[Funkcjonalnosc] ADD UNIQUE NONCLUSTERED 
(
	[Nazwa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

SET ANSI_PADDING ON

/****** Object:  Index [UQ__Klient__602223FFFFBD244C]    Script Date: 01.12.2018 00:26:36 ******/
ALTER TABLE [dbo].[Klient] ADD UNIQUE NONCLUSTERED 
(
	[Nazwa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

ALTER TABLE [dbo].[Funkcjonalnosc]  WITH CHECK ADD  CONSTRAINT [FK_Funkcjonalnosc_Program] FOREIGN KEY([Program])
REFERENCES [dbo].[Program] ([IdProgramu])

ALTER TABLE [dbo].[Funkcjonalnosc] CHECK CONSTRAINT [FK_Funkcjonalnosc_Program]

ALTER TABLE [dbo].[Notatka]  WITH CHECK ADD  CONSTRAINT [Notatka_fk0] FOREIGN KEY([Autor])
REFERENCES [dbo].[Autor] ([IdAutora])
ON UPDATE CASCADE

ALTER TABLE [dbo].[Notatka] CHECK CONSTRAINT [Notatka_fk0]

ALTER TABLE [dbo].[Notatka]  WITH CHECK ADD  CONSTRAINT [Notatka_fk1] FOREIGN KEY([Klient])
REFERENCES [dbo].[Klient] ([IdKlienta])
ON UPDATE CASCADE
ON DELETE CASCADE

ALTER TABLE [dbo].[Notatka] CHECK CONSTRAINT [Notatka_fk1]

ALTER TABLE [dbo].[Notatka]  WITH CHECK ADD  CONSTRAINT [Notatka_fk2] FOREIGN KEY([Wpis])
REFERENCES [dbo].[Wpis] ([IdWpisu])
ON DELETE CASCADE

ALTER TABLE [dbo].[Notatka] CHECK CONSTRAINT [Notatka_fk2]

ALTER TABLE [dbo].[Wpis]  WITH CHECK ADD  CONSTRAINT [Wpis_fk0] FOREIGN KEY([Autor])
REFERENCES [dbo].[Autor] ([IdAutora])
ON UPDATE CASCADE

ALTER TABLE [dbo].[Wpis] CHECK CONSTRAINT [Wpis_fk0]

ALTER TABLE [dbo].[Wpis]  WITH CHECK ADD  CONSTRAINT [Wpis_fk1] FOREIGN KEY([Funkcjonalnosc])
REFERENCES [dbo].[Funkcjonalnosc] ([Id])
ON UPDATE CASCADE

ALTER TABLE [dbo].[Wpis] CHECK CONSTRAINT [Wpis_fk1]

ALTER DATABASE [BazaCzysciec] SET  READ_WRITE 