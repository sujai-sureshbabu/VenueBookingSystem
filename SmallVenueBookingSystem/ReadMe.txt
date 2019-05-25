//Execute Below Script to set up db and table and necessary data.
//1.select any seats to book 
//2.Click on BookSeats to book your seats 
//3.Only Maximum of 3 seats can be booked at a time
//4.Seats marked with 'w' are wheel chair compatible.It needs a person to be accompanied so it cannot be booked separately.You can only book seat marked with w and its near by chair at a time







USE [SmallVenueDb]
GO
/****** Object:  Table [dbo].[SeatLayout]    Script Date: 20-12-2016 12:41:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE DATABASE SmallVenueDb
GO
CREATE TABLE [dbo].[SeatLayout](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[seat_no] [nvarchar](50) NULL,
	[booked_by] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[partially_enabled] [nvarchar](50) NULL,
	[booking_date] [nvarchar](50) NULL,
	[isAvailable] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[SeatLayout] ON 

INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (1, N'A1', N'', NULL, N'NO', N'19-12-2016 11:41:02 PM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (2, N'A2', NULL, NULL, N'NO', N'19-12-2016 11:41:02 PM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (3, N'A3', NULL, NULL, N'NO', N'19-12-2016 11:41:02 PM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (4, N'B1', NULL, NULL, N'NO', N'20-12-2016 12:10:10 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (5, N'B2', NULL, NULL, N'NO', N'20-12-2016 12:19:09 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (6, N'B3w', NULL, NULL, N'YES', N'20-12-2016 12:19:09 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (7, N'C1', NULL, NULL, N'NO', N'19-12-2016 11:33:12 PM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (8, N'C2', NULL, NULL, N'NO', N'20-12-2016 12:19:09 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (9, N'C3', NULL, NULL, N'NO', N'19-12-2016 11:33:12 PM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (10, N'C4', NULL, NULL, N'NO', N'20-12-2016 12:35:17 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (11, N'C5', NULL, NULL, N'NO', N'20-12-2016 12:21:19 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (12, N'C6', NULL, NULL, N'NO', N'20-12-2016 12:21:19 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (13, N'B4', NULL, NULL, N'NO', N'20-12-2016 12:18:51 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (14, N'B5', NULL, NULL, N'NO', N'20-12-2016 12:18:51 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (15, N'B6w', NULL, NULL, N'YES', N'20-12-2016 12:18:51 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (16, N'A4', NULL, NULL, N'NO', N'20-12-2016 12:35:17 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (17, N'A5', NULL, NULL, N'NO', N'20-12-2016 12:35:17 AM', 1)
INSERT [dbo].[SeatLayout] ([Id], [seat_no], [booked_by], [Age], [partially_enabled], [booking_date], [isAvailable]) VALUES (18, N'A6', NULL, NULL, N'NO', N'19-12-2016 10:15:55 PM', 1)
SET IDENTITY_INSERT [dbo].[SeatLayout] OFF
