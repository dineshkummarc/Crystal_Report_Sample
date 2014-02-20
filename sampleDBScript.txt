USE [SampleDB]
GO
/****** Object:  Table [dbo].[Customer_Orders]    Script Date: 02/17/2011 16:37:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer_Orders](
	[Cust_ord_id] [int] IDENTITY(1,1) NOT NULL,
	[Customer_Name] [varchar](200) NULL,
	[Order_ID] [int] NULL,
	[Product_Name] [varchar](200) NULL,
	[Product_Qty] [int] NULL,
 CONSTRAINT [PK_Customer_Orders] PRIMARY KEY CLUSTERED 
(
	[Cust_ord_id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customer_Orders] ON
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (1, N'Customer 1', 1, N'Product 1', 4)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (2, N'Customer 1', 1, N'Product 2', 5)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (3, N'Customer 1', 2, N'Product 3', 5)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (4, N'Customer 1', 2, N'Product 4', 3)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (5, N'Customer 1', 2, N'Product 5', 6)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (6, N'Customer 2', 3, N'Product 1', 2)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (7, N'Customer 2', 3, N'Product 2', 3)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (8, N'Customer 2', 3, N'Product 3', 5)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (9, N'Customer 2', 4, N'Product 4', 3)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (10, N'Customer 2', 4, N'Product 5', 8)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (11, N'Customer 3', 5, N'Product 1', 9)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (12, N'Customer 3', 5, N'Product 2', 4)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (13, N'Customer 3', 6, N'Product 3', 7)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (14, N'Customer 3', 6, N'Product 4', 5)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (15, N'Customer 3', 6, N'Product 5', 2)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (16, N'Customer 4', 7, N'Product 1', 6)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (17, N'Customer 4', 7, N'Product 2', 9)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (18, N'Customer 4', 7, N'Product 3', 21)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (19, N'Customer 4', 8, N'Product 4', 25)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (20, N'Customer 4', 8, N'Product 5', 20)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (21, N'Customer 5', 9, N'Product 1', 32)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (22, N'Customer 5', 9, N'Product 2', 5)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (23, N'Customer 5', 10, N'Product 3', 3)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (24, N'Customer 5', 10, N'Product 4', 0)
INSERT [dbo].[Customer_Orders] ([Cust_ord_id], [Customer_Name], [Order_ID], [Product_Name], [Product_Qty]) VALUES (25, N'Customer 5', 10, N'Product 5', 1)
SET IDENTITY_INSERT [dbo].[Customer_Orders] OFF
/****** Object:  StoredProcedure [dbo].[getAllOrders]    Script Date: 02/17/2011 16:37:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[getAllOrders]

AS
BEGIN
	Select * from Customer_Orders
END
GO
