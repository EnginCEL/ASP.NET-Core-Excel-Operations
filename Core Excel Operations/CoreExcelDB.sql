USE [CoreExcelDB]
GO
/****** Object:  Table [dbo].[Personal]    Script Date: 15.06.2022 23:06:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personal](
	[PersonalID] [int] IDENTITY(1,1) NOT NULL,
	[PersonalName] [nvarchar](50) NOT NULL,
	[PersonalSurName] [nvarchar](80) NOT NULL,
	[PersonalMail] [nvarchar](320) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Personal] ON 

INSERT [dbo].[Personal] ([PersonalID], [PersonalName], [PersonalSurName], [PersonalMail]) VALUES (1, N'Ahmet', N'YILMAZ', N'ahmet.yilmaz@gmail.com')
INSERT [dbo].[Personal] ([PersonalID], [PersonalName], [PersonalSurName], [PersonalMail]) VALUES (2, N'Ayşe', N'NUR', N'aysenur@hotmail.com')
SET IDENTITY_INSERT [dbo].[Personal] OFF
