USE [RestaurantManagementProject]
GO
/****** Object:  Table [dbo].[billHistoryAll]    Script Date: 8/24/2021 11:47:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[billHistoryAll](
	[billId] [varchar](50) NOT NULL,
	[items] [varchar](250) NULL,
	[tableNumber] [varchar](50) NULL,
	[totalBill] [varchar](50) NULL,
	[totalPay] [varchar](50) NULL,
	[returned] [varchar](50) NULL,
	[date] [varchar](50) NULL,
	[customerId] [varchar](50) NULL,
 CONSTRAINT [PK_billHistoryAll] PRIMARY KEY CLUSTERED 
(
	[billId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[expenses]    Script Date: 8/24/2021 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[expenses](
	[maintananceCost] [varchar](50) NULL,
	[restaurantRent] [varchar](50) NULL,
	[employeeSalary] [varchar](50) NULL,
	[foodCost] [varchar](50) NULL,
	[othersBill] [varchar](50) NULL,
	[month] [varchar](50) NULL,
	[year] [varchar](50) NULL,
	[totalMonthlyCost] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[foodDetailsAll]    Script Date: 8/24/2021 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[foodDetailsAll](
	[foodItem] [varchar](50) NULL,
	[foodCost] [varchar](50) NULL,
	[category] [varchar](50) NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LoginRestaurant]    Script Date: 8/24/2021 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LoginRestaurant](
	[Id] [varchar](21) NOT NULL,
	[Name] [varchar](30) NULL,
	[Password] [varchar](21) NULL,
	[Role] [varchar](21) NULL,
 CONSTRAINT [PK_LoginRestaurant] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ManagerDetail]    Script Date: 8/24/2021 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ManagerDetail](
	[ManagerId] [varchar](23) NOT NULL,
	[ManagerName] [varchar](23) NULL,
	[ManagerAddress] [varchar](23) NULL,
	[ManagerNID] [varchar](23) NULL,
	[ContactNumber] [varchar](23) NULL,
	[JoiningDate] [varchar](23) NULL,
	[Salary] [varchar](23) NULL,
 CONSTRAINT [PK_ManagerDetail] PRIMARY KEY CLUSTERED 
(
	[ManagerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[reservationTable]    Script Date: 8/24/2021 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[reservationTable](
	[customerId] [varchar](50) NOT NULL,
	[customerName] [varchar](50) NULL,
	[customerContactNumber] [varchar](50) NULL,
	[tableId] [varchar](50) NULL,
	[reservationDate] [varchar](50) NULL,
	[bookingState] [varchar](50) NULL,
 CONSTRAINT [PK_reservationTable] PRIMARY KEY CLUSTERED 
(
	[customerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[StaffDetail]    Script Date: 8/24/2021 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[StaffDetail](
	[StaffId] [varchar](26) NOT NULL,
	[StaffName] [varchar](26) NULL,
	[StaffAddress] [varchar](26) NULL,
	[StaffNID] [varchar](26) NULL,
	[ContactNumber] [varchar](26) NULL,
	[JoiningDate] [varchar](26) NULL,
	[StaffPosition] [varchar](26) NULL,
	[Salary] [varchar](26) NULL,
 CONSTRAINT [PK_StaffDetail] PRIMARY KEY CLUSTERED 
(
	[StaffId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[billHistoryAll] ([billId], [items], [tableNumber], [totalBill], [totalPay], [returned], [date], [customerId]) VALUES (N'b-01', N'Burger   Coca-Cola', N' t-01', N'349', N'400', N'51', N'2021-08-21', N'c-01')
INSERT [dbo].[billHistoryAll] ([billId], [items], [tableNumber], [totalBill], [totalPay], [returned], [date], [customerId]) VALUES (N'b-02', N'Burger   Mountain Due', N't-04', N'1296', N'1300', N'4', N'2021-08-21', N'c-02')
INSERT [dbo].[billHistoryAll] ([billId], [items], [tableNumber], [totalBill], [totalPay], [returned], [date], [customerId]) VALUES (N'b-06', N'Pizza   Coca-Cola', N' t-07', N'1099', N'1500', N'401', N'2021-08-23', N'c-05')
INSERT [dbo].[billHistoryAll] ([billId], [items], [tableNumber], [totalBill], [totalPay], [returned], [date], [customerId]) VALUES (N'b-08', N'French Fries Fried Rice with Chicken Lolly-Pop Ice Cream Coca-Cola', N't-02', N'957', N'1000', N'43', N'2021-08-23', N'c-07')
INSERT [dbo].[billHistoryAll] ([billId], [items], [tableNumber], [totalBill], [totalPay], [returned], [date], [customerId]) VALUES (N'b-09', N'Chicken Lolly-Pop Fried Rice with Chicken Lolly-Pop Ice Cream Coca-Cola', N't-02', N'2997', N'3000', N'3', N'2021-08-24', N'c-09')
INSERT [dbo].[expenses] ([maintananceCost], [restaurantRent], [employeeSalary], [foodCost], [othersBill], [month], [year], [totalMonthlyCost]) VALUES (N'50', N'80', N'57', N'65', N'54', N'August', N'2021', N'317')
INSERT [dbo].[expenses] ([maintananceCost], [restaurantRent], [employeeSalary], [foodCost], [othersBill], [month], [year], [totalMonthlyCost]) VALUES (N'56', N'45', N'33', N'22', N'25', N'February', N'2022', N'178')
INSERT [dbo].[expenses] ([maintananceCost], [restaurantRent], [employeeSalary], [foodCost], [othersBill], [month], [year], [totalMonthlyCost]) VALUES (N'9', N'7', N'6', N'89', N'9', N'January', N'0', N'0')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Burger	', N'299', N'Fastfood')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'French Fries', N'129', N'Fastfood')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Pizza', N'999', N'Fastfood')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Chicken Lolly-Pop', N'399', N'Fastfood')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Fried Chicken', N'99', N'Fastfood')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Chicken Nuggets', N'249', N'Fastfood')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Pan-Cake', N'139', N'Dessert')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Milk Shake', N'179', N'Dessert')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Oreo Shake', N'155', N'Dessert')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Coca-Cola', N'50', N'Drinks')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'	Pepsi', N'50', N'Drinks')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Mountain Due', N'50', N'Drinks')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Fried Rice with Chicken Lolly-Pop', N'399', N'SetMenu')
INSERT [dbo].[foodDetailsAll] ([foodItem], [foodCost], [category]) VALUES (N'Fried Rice with Vegetable and Chicken Curry', N'455', N'SetMenu')
INSERT [dbo].[LoginRestaurant] ([Id], [Name], [Password], [Role]) VALUES (N'19-41310-3', N'Dibya', N'567', N'Manager')
INSERT [dbo].[LoginRestaurant] ([Id], [Name], [Password], [Role]) VALUES (N'19-41373-3', N'Abdullah', N'123', N'Owner')
INSERT [dbo].[LoginRestaurant] ([Id], [Name], [Password], [Role]) VALUES (N'19-41424-3', N'Tanjim', N'234', N'Manager')
INSERT [dbo].[ManagerDetail] ([ManagerId], [ManagerName], [ManagerAddress], [ManagerNID], [ContactNumber], [JoiningDate], [Salary]) VALUES (N'm-01', N'Rakin', N'Dhaka', N'12345678', N'01234567', N'2021-04-21', N'40,000')
INSERT [dbo].[ManagerDetail] ([ManagerId], [ManagerName], [ManagerAddress], [ManagerNID], [ContactNumber], [JoiningDate], [Salary]) VALUES (N'm-02', N'Dibya', N'Tangail', N'  32452346', N'016836382', N'2021-08-09', N'32,000')
INSERT [dbo].[reservationTable] ([customerId], [customerName], [customerContactNumber], [tableId], [reservationDate], [bookingState]) VALUES (N'c-01', N'Sadman', N'0188273', N't-01', N'2021-08-15', N'Booked')
INSERT [dbo].[reservationTable] ([customerId], [customerName], [customerContactNumber], [tableId], [reservationDate], [bookingState]) VALUES (N'c-02', N'Dibya', N'0965421', N't-03', N'2021-08-21', N'Booked')
INSERT [dbo].[reservationTable] ([customerId], [customerName], [customerContactNumber], [tableId], [reservationDate], [bookingState]) VALUES (N'c-03', N'Raj', N'087843', N't-08', N'2021-08-22', N'Booked')
INSERT [dbo].[reservationTable] ([customerId], [customerName], [customerContactNumber], [tableId], [reservationDate], [bookingState]) VALUES (N'c-05', N'Shobhan', N'018728612', N' t-07', N'2021-08-23', N'Booked')
INSERT [dbo].[reservationTable] ([customerId], [customerName], [customerContactNumber], [tableId], [reservationDate], [bookingState]) VALUES (N'c-08', N'Rayhan', N'01820181', N't-05', N'2021-08-24', N'Booked')
INSERT [dbo].[reservationTable] ([customerId], [customerName], [customerContactNumber], [tableId], [reservationDate], [bookingState]) VALUES (N'c-09', N'1', N'1', N't-02', N'2021-08-24', N'Booked')
INSERT [dbo].[reservationTable] ([customerId], [customerName], [customerContactNumber], [tableId], [reservationDate], [bookingState]) VALUES (N'c-10', N'2', N'1', N't-02', N'2021-08-24', N'Booked')
INSERT [dbo].[StaffDetail] ([StaffId], [StaffName], [StaffAddress], [StaffNID], [ContactNumber], [JoiningDate], [StaffPosition], [Salary]) VALUES (N's-01', N'Rajib', N'Barisal', N'45377357', N'01356865', N'2021-08-10', N'Chef', N'30,230')
