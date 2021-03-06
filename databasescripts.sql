USE [PasswordManager]
GO
ALTER TABLE [dbo].[Reminders] DROP CONSTRAINT [FK_Reminders_Passwords]
GO
ALTER TABLE [dbo].[Settings] DROP CONSTRAINT [DF__Settings__ShowPa__4F7CD00D]
GO
ALTER TABLE [dbo].[Settings] DROP CONSTRAINT [DF__Settings__ShowUs__4E88ABD4]
GO
ALTER TABLE [dbo].[Settings] DROP CONSTRAINT [DF__Settings__ShowEm__4D94879B]
GO
ALTER TABLE [dbo].[Settings] DROP CONSTRAINT [DF__Settings__DateTi__4CA06362]
GO
ALTER TABLE [dbo].[Reminders] DROP CONSTRAINT [DF_Reminders_ReminderShown]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Maxim__4BAC3F29]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Minim__4AB81AF0]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Requi__49C3F6B7]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Requi__48CFD27E]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Requi__47DBAE45]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Requi__46E78A0C]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Requi__45F365D3]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Requi__44FF419A]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Requi__440B1D61]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Allow__4316F928]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Allow__4222D4EF]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Allow__412EB0B6]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Allow__403A8C7D]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Allow__3F466844]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Allow__3E52440B]
GO
ALTER TABLE [dbo].[PasswordOptions] DROP CONSTRAINT [DF__PasswordO__Allow__3D5E1FD2]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23/10/2018 20:26:48 ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 23/10/2018 20:26:48 ******/
DROP TABLE [dbo].[Settings]
GO
/****** Object:  Table [dbo].[Reminders]    Script Date: 23/10/2018 20:26:48 ******/
DROP TABLE [dbo].[Reminders]
GO
/****** Object:  Table [dbo].[PasswordsHistory]    Script Date: 23/10/2018 20:26:48 ******/
DROP TABLE [dbo].[PasswordsHistory]
GO
/****** Object:  Table [dbo].[Passwords]    Script Date: 23/10/2018 20:26:48 ******/
DROP TABLE [dbo].[Passwords]
GO
/****** Object:  Table [dbo].[PasswordOptions]    Script Date: 23/10/2018 20:26:48 ******/
DROP TABLE [dbo].[PasswordOptions]
GO
/****** Object:  Table [dbo].[PasswordOptions]    Script Date: 23/10/2018 20:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Passwords]    Script Date: 23/10/2018 20:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[PasswordsHistory]    Script Date: 23/10/2018 20:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PasswordsHistory](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [int] NOT NULL,
	[NameBefore] [varchar](250) NULL,
	[EmailBefore] [varchar](250) NULL,
	[UsernameBefore] [varchar](250) NULL,
	[WebsiteBefore] [varchar](250) NULL,
	[TextBefore] [varchar](250) NULL,
	[NotesBefore] [varchar](500) NULL,
	[DateModifiedBefore] [varchar](500) NULL,
	[NameAfter] [varchar](250) NULL,
	[EmailAfter] [varchar](250) NULL,
	[UsernameAfter] [varchar](250) NULL,
	[WebsiteAfter] [varchar](250) NULL,
	[TextAfter] [varchar](250) NULL,
	[NotesAfter] [varchar](500) NULL,
	[DateModifiedAfter] [varchar](500) NULL,
	[Operation] [varchar](50) NULL,
	[PasswordID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reminders]    Script Date: 23/10/2018 20:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reminders](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ReminderText] [varchar](250) NULL,
	[ShowReminderDate] [date] NOT NULL,
	[ReminderPassword] [int] NOT NULL,
	[ReminderShown] [bit] NOT NULL,
 CONSTRAINT [PK_Reminders] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Settings]    Script Date: 23/10/2018 20:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
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
/****** Object:  Table [dbo].[Users]    Script Date: 23/10/2018 20:26:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Master] [varchar](50) NOT NULL,
	[LastLoginDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
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
ALTER TABLE [dbo].[Reminders] ADD  CONSTRAINT [DF_Reminders_ReminderShown]  DEFAULT ((0)) FOR [ReminderShown]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ('F') FOR [DateTimeFormat]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ((1)) FOR [ShowEmailColumn]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ((1)) FOR [ShowUsernameColumn]
GO
ALTER TABLE [dbo].[Settings] ADD  DEFAULT ((1)) FOR [ShowPasswordColumn]
GO
ALTER TABLE [dbo].[Reminders]  WITH CHECK ADD  CONSTRAINT [FK_Reminders_Passwords] FOREIGN KEY([ReminderPassword])
REFERENCES [dbo].[Passwords] ([ID])
GO
ALTER TABLE [dbo].[Reminders] CHECK CONSTRAINT [FK_Reminders_Passwords]
GO
