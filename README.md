# README

## DB Schema

### Table Per Hierarchy (TPH)

```sql
USE [TPH]
GO
/****** Object:  Table [dbo].[PersonTph]    Script Date: 2020/10/23 下午 02:02:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonTph](
	[id] [uniqueidentifier] NOT NULL,
	[type] [int] NULL,
	[first_name] [nvarchar](32) NULL,
	[last_name] [nvarchar](32) NULL,
	[date_of_birth] [datetime] NULL,
	[turnover] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[PersonTph] ([id], [type], [first_name], [last_name], [date_of_birth], [turnover]) VALUES (N'ab4df396-5ddc-4420-a523-ba508b2c0400', 1, N'Larry', N'Su', CAST(N'1974-05-09T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[PersonTph] ([id], [type], [first_name], [last_name], [date_of_birth], [turnover]) VALUES (N'90ec4349-f7a7-432b-8153-c6e7e397c134', 1, N'Terry', N'Sing', CAST(N'1988-07-21T00:00:00.000' AS DateTime), NULL)
GO
INSERT [dbo].[PersonTph] ([id], [type], [first_name], [last_name], [date_of_birth], [turnover]) VALUES (N'44710a4c-a5b6-47d9-b61f-bfc241f42069', 2, N'Kubing', N'Lin', NULL, CAST(150 AS Decimal(18, 0)))
GO
INSERT [dbo].[PersonTph] ([id], [type], [first_name], [last_name], [date_of_birth], [turnover]) VALUES (N'9f330d53-f771-47c6-9120-6530c5e1a9f2', 2, N'EE', N'ee', NULL, CAST(120 AS Decimal(18, 0)))
GO
/****** Object:  Index [PK__PersonTp__3213E83E428B1078]    Script Date: 2020/10/23 下午 02:02:56 ******/
ALTER TABLE [dbo].[PersonTph] ADD PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
```

### Table Per Type (TPT)

```sql
USE [TPT]
GO
/****** Object:  Table [dbo].[CustomerTpt]    Script Date: 2020/10/23 下午 02:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CustomerTpt](
	[id] [uniqueidentifier] NOT NULL,
	[date_of_birth] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeTpt]    Script Date: 2020/10/23 下午 02:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeTpt](
	[id] [uniqueidentifier] NOT NULL,
	[turnover] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonTpt]    Script Date: 2020/10/23 下午 02:05:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonTpt](
	[id] [uniqueidentifier] NOT NULL,
	[first_name] [nvarchar](32) NULL,
	[last_name] [nvarchar](32) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[CustomerTpt] ([id], [date_of_birth]) VALUES (N'cfd7817c-bd46-4cf7-994c-558c6000a6ba', CAST(N'1974-05-09T00:00:00.000' AS DateTime))
INSERT [dbo].[CustomerTpt] ([id], [date_of_birth]) VALUES (N'8c91df1b-4a76-4ade-958b-b3361ce93ca5', CAST(N'1988-07-21T00:00:00.000' AS DateTime))
INSERT [dbo].[CustomerTpt] ([id], [date_of_birth]) VALUES (N'2c82a9f8-9ef5-46ba-a169-26ba183c5889', CAST(N'2020-10-22T16:48:56.160' AS DateTime))
INSERT [dbo].[EmployeeTpt] ([id], [turnover]) VALUES (N'4a2a7163-e3dc-4c18-a525-3357c00134ab', CAST(150 AS Decimal(18, 0)))
INSERT [dbo].[PersonTpt] ([id], [first_name], [last_name]) VALUES (N'4a2a7163-e3dc-4c18-a525-3357c00134ab', N'Kubing', N'Lin')
INSERT [dbo].[PersonTpt] ([id], [first_name], [last_name]) VALUES (N'cfd7817c-bd46-4cf7-994c-558c6000a6ba', N'Larry', N'Su')
INSERT [dbo].[PersonTpt] ([id], [first_name], [last_name]) VALUES (N'8c91df1b-4a76-4ade-958b-b3361ce93ca5', N'Terry', N'Sing')
INSERT [dbo].[PersonTpt] ([id], [first_name], [last_name]) VALUES (N'2c82a9f8-9ef5-46ba-a169-26ba183c5889', N'KK', N'kk')
/****** Object:  Index [PK__Customer__3213E83E94A4B620]    Script Date: 2020/10/23 下午 02:05:36 ******/
ALTER TABLE [dbo].[CustomerTpt] ADD PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK__Employee__3213E83E7E6F74F9]    Script Date: 2020/10/23 下午 02:05:36 ******/
ALTER TABLE [dbo].[EmployeeTpt] ADD PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [PK__PersonTp__3213E83E2F8B523C]    Script Date: 2020/10/23 下午 02:05:36 ******/
ALTER TABLE [dbo].[PersonTpt] ADD PRIMARY KEY NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
```
