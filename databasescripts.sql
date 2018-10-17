/****** Object:  Table [dbo].[PasswordOptions]    Script Date: 10/14/18 6:31:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PasswordOptions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[SettingsID] [int] NOT NULL,
	[AllowLowercaseCharacters] [bit] NULL,
	[AllowUppercaseCharacters] [bit] NULL,
	[AllowNumberCharacters] [bit] NULL,
	[AllowSpecialCharacters] [bit] NULL,
	[AllowUnderscoreCharacters] [bit] NULL,
	[AllowSpaceCharacters] [bit] NULL,
	[AllowOtherCharacters] [bit] NULL,
	[RequireLowercaseCharacters] [bit] NULL,
	[RequireUppercaseCharacters] [bit] NULL,
	[RequireNumberCharacters] [bit] NULL,
	[RequireSpecialCharacters] [bit] NULL,
	[RequireUnderscoreCharacters] [bit] NULL,
	[RequireSpaceCharacters] [bit] NULL,
	[RequireOtherCharacters] [bit] NULL,
	[MinimumCharacters] [int] NULL,
	[MaximumCharacters] [int] NULL,
	[OtherCharacters] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Passwords]    Script Date: 10/14/18 6:31:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Passwords](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[Email] [varchar](250) NULL,
	[Username] [varchar](250) NULL,
	[Website] [varchar](250) NULL,
	[Text] [varchar](250) NULL,
	[Notes] [varchar](500) NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 10/14/18 6:31:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Settings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[DateTimeFormat] [varchar](50) NULL,
	[ShowEmailColumn] [bit] NULL,
	[ShowUsernameColumn] [bit] NULL,
	[ShowPasswordColumn] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/14/18 6:31:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Master] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((1)) FOR [AllowLowercaseCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((1)) FOR [AllowUppercaseCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((1)) FOR [AllowNumberCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((1)) FOR [AllowSpecialCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((0)) FOR [AllowUnderscoreCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((0)) FOR [AllowSpaceCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((0)) FOR [AllowOtherCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((1)) FOR [RequireLowercaseCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((1)) FOR [RequireUppercaseCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((1)) FOR [RequireNumberCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((0)) FOR [RequireSpecialCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((0)) FOR [RequireUnderscoreCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((0)) FOR [RequireSpaceCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((0)) FOR [RequireOtherCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((10)) FOR [MinimumCharacters]
GO
ALTER TABLE [dbo].[PasswordOptions] ADD  DEFAULT ((12)) FOR [MaximumCharacters]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ('F') FOR [DateTimeFormat]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ((1)) FOR [ShowEmailColumn]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ((1)) FOR [ShowUsernameColumn]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ((1)) FOR [ShowPasswordColumn]
GO
