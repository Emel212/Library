USE [master]
GO
/****** Object:  Database [Library]    Script Date: 7.03.2022 21:17:04 ******/
CREATE DATABASE [Library]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Library', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Library.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Library_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Library_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Library] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Library].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Library] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Library] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Library] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Library] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Library] SET ARITHABORT OFF 
GO
ALTER DATABASE [Library] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Library] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Library] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Library] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Library] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Library] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Library] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Library] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Library] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Library] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Library] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Library] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Library] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Library] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Library] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Library] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Library] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Library] SET  MULTI_USER 
GO
ALTER DATABASE [Library] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Library] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Library] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Library] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Library] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Library] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Library] SET QUERY_STORE = OFF
GO
USE [Library]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](150) NULL,
	[Author] [nvarchar](50) NULL,
	[PublisherID] [int] NULL,
	[CategoryID] [int] NULL,
 CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookStatus]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookStatus](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DateTime] [datetime] NULL,
	[LoanPeriod] [datetime] NULL,
	[MemberID] [int] NULL,
	[BookID] [int] NULL,
	[IsBorrowed] [bit] NULL,
	[IsAvailable] [bit] NULL,
	[IsOnHold] [bit] NULL,
 CONSTRAINT [PK_BookStatus] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Comment] [nvarchar](150) NULL,
	[Datetime] [datetime] NULL,
	[IsApproved] [bit] NULL,
	[MemberID] [int] NULL,
	[BookID] [int] NULL,
 CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Images]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Images](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Path] [nvarchar](max) NULL,
	[BookID] [int] NULL,
 CONSTRAINT [PK_Images] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Likes]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Likes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NULL,
	[CommentID] [int] NULL,
	[MemberID] [int] NULL,
 CONSTRAINT [PK_Likes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Members]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Members](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](25) NULL,
	[LastName] [nvarchar](25) NULL,
	[Phone] [nvarchar](15) NULL,
	[Adress] [nvarchar](150) NULL,
	[MemberSince] [datetime] NULL,
 CONSTRAINT [PK_Members] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personels]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[JobDescription] [nvarchar](50) NULL,
	[Phone] [nchar](20) NULL,
	[Adress] [nvarchar](50) NULL,
 CONSTRAINT [PK_Personels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 7.03.2022 21:17:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](150) NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Books] ON 

INSERT [dbo].[Books] ([Id], [Name], [Description], [Author], [PublisherID], [CategoryID]) VALUES (2, N'Dawn of Andromeda', N'-', N'McJohn', 1, 1)
INSERT [dbo].[Books] ([Id], [Name], [Description], [Author], [PublisherID], [CategoryID]) VALUES (3, N'Avian Colony', N'-', N'Ruslan Conri', 1, 1)
INSERT [dbo].[Books] ([Id], [Name], [Description], [Author], [PublisherID], [CategoryID]) VALUES (4, N'Marked For Mercy', N'The International best seller', N'Florencio Milla', 1, 1)
INSERT [dbo].[Books] ([Id], [Name], [Description], [Author], [PublisherID], [CategoryID]) VALUES (5, N'City of Winter', N'-', N'Sudarshan Monika', 1, 2)
INSERT [dbo].[Books] ([Id], [Name], [Description], [Author], [PublisherID], [CategoryID]) VALUES (6, N'Mystery of the Mute Conductor', N'an interesting story about a mute conductor', N'Alisa Lake', 1, 1)
INSERT [dbo].[Books] ([Id], [Name], [Description], [Author], [PublisherID], [CategoryID]) VALUES (7, N'2938:Judgment', N'-', N'Helen Lynnette', 1, 1)
INSERT [dbo].[Books] ([Id], [Name], [Description], [Author], [PublisherID], [CategoryID]) VALUES (8, N'Bard''s Inferno', N'-', N'Séamus Colby', 1, 2)
SET IDENTITY_INSERT [dbo].[Books] OFF
GO
SET IDENTITY_INSERT [dbo].[BookStatus] ON 

INSERT [dbo].[BookStatus] ([Id], [DateTime], [LoanPeriod], [MemberID], [BookID], [IsBorrowed], [IsAvailable], [IsOnHold]) VALUES (1, CAST(N'2021-11-13T00:00:00.000' AS DateTime), CAST(N'2021-11-14T00:00:00.000' AS DateTime), 1, 6, 1, 0, 0)
INSERT [dbo].[BookStatus] ([Id], [DateTime], [LoanPeriod], [MemberID], [BookID], [IsBorrowed], [IsAvailable], [IsOnHold]) VALUES (2, CAST(N'2022-06-02T00:00:00.000' AS DateTime), CAST(N'2021-12-15T00:00:00.000' AS DateTime), 2, 3, 1, 0, 0)
INSERT [dbo].[BookStatus] ([Id], [DateTime], [LoanPeriod], [MemberID], [BookID], [IsBorrowed], [IsAvailable], [IsOnHold]) VALUES (3, CAST(N'2022-06-02T00:00:00.000' AS DateTime), CAST(N'2021-12-15T00:00:00.000' AS DateTime), 3, 4, 0, 0, 1)
SET IDENTITY_INSERT [dbo].[BookStatus] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (1, N'ScienceFiction', N'fictionbook')
INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (2, N'Novel', N'novel')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Members] ON 

INSERT [dbo].[Members] ([Id], [Name], [LastName], [Phone], [Adress], [MemberSince]) VALUES (1, N'Emma', N'Adams', N'+25678931145', N'215st-78B', CAST(N'2021-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[Members] ([Id], [Name], [LastName], [Phone], [Adress], [MemberSince]) VALUES (2, N'Joe', N'White', N'+12154623233', N'abc', CAST(N'2021-12-01T00:00:00.000' AS DateTime))
INSERT [dbo].[Members] ([Id], [Name], [LastName], [Phone], [Adress], [MemberSince]) VALUES (3, N'Hemera', N'Cora', N'+35366535121', N'218st-78B', CAST(N'2022-02-12T00:00:00.000' AS DateTime))
INSERT [dbo].[Members] ([Id], [Name], [LastName], [Phone], [Adress], [MemberSince]) VALUES (4, N'Uliana', N'Boris', N'+65665656232', N'218st-78B', CAST(N'2021-12-10T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Members] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([Id], [Name], [Description]) VALUES (1, N'Coder', N'-')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
ALTER TABLE [dbo].[BookStatus] ADD  CONSTRAINT [DF_BookStatus_IsBorrowed]  DEFAULT ((0)) FOR [IsBorrowed]
GO
ALTER TABLE [dbo].[BookStatus] ADD  CONSTRAINT [DF_BookStatus_IsAvailable]  DEFAULT ((0)) FOR [IsAvailable]
GO
ALTER TABLE [dbo].[BookStatus] ADD  CONSTRAINT [DF_BookStatus_IsOnHold]  DEFAULT ((0)) FOR [IsOnHold]
GO
ALTER TABLE [dbo].[Comments] ADD  CONSTRAINT [DF_Comments_IsApproved]  DEFAULT ((0)) FOR [IsApproved]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Category]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Publisher] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([Id])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Publisher]
GO
ALTER TABLE [dbo].[BookStatus]  WITH CHECK ADD  CONSTRAINT [FK_BookStatus_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[BookStatus] CHECK CONSTRAINT [FK_BookStatus_Books]
GO
ALTER TABLE [dbo].[BookStatus]  WITH CHECK ADD  CONSTRAINT [FK_BookStatus_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([Id])
GO
ALTER TABLE [dbo].[BookStatus] CHECK CONSTRAINT [FK_BookStatus_Members]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Books]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_Comments_Members2] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([Id])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_Comments_Members2]
GO
ALTER TABLE [dbo].[Images]  WITH CHECK ADD  CONSTRAINT [FK_Images_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Images] CHECK CONSTRAINT [FK_Images_Books]
GO
ALTER TABLE [dbo].[Likes]  WITH CHECK ADD  CONSTRAINT [FK_Likes_Books] FOREIGN KEY([BookID])
REFERENCES [dbo].[Books] ([Id])
GO
ALTER TABLE [dbo].[Likes] CHECK CONSTRAINT [FK_Likes_Books]
GO
ALTER TABLE [dbo].[Likes]  WITH CHECK ADD  CONSTRAINT [FK_Likes_Comments] FOREIGN KEY([CommentID])
REFERENCES [dbo].[Comments] ([Id])
GO
ALTER TABLE [dbo].[Likes] CHECK CONSTRAINT [FK_Likes_Comments]
GO
ALTER TABLE [dbo].[Likes]  WITH CHECK ADD  CONSTRAINT [FK_Likes_Members] FOREIGN KEY([MemberID])
REFERENCES [dbo].[Members] ([Id])
GO
ALTER TABLE [dbo].[Likes] CHECK CONSTRAINT [FK_Likes_Members]
GO
USE [master]
GO
ALTER DATABASE [Library] SET  READ_WRITE 
GO
