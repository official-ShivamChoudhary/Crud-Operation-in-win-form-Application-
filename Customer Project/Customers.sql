USE [Customerdb]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 12-02-2025 13:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NULL,
	[CustomerAddress] [nvarchar](50) NULL,
	[CustomerNumber] [nvarchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [CustomerName], [CustomerAddress], [CustomerNumber]) VALUES (1, N'Shivam', N'Noida', N'1234569858')
INSERT [dbo].[Customers] ([Id], [CustomerName], [CustomerAddress], [CustomerNumber]) VALUES (2, N'Shubham', N'dhanbad', N'4561236985')
INSERT [dbo].[Customers] ([Id], [CustomerName], [CustomerAddress], [CustomerNumber]) VALUES (3, N'santosh', N'kolkatta', N'7895698569')
INSERT [dbo].[Customers] ([Id], [CustomerName], [CustomerAddress], [CustomerNumber]) VALUES (4, N'himanshu', N'Ranchi', N'7895698562')
INSERT [dbo].[Customers] ([Id], [CustomerName], [CustomerAddress], [CustomerNumber]) VALUES (5, N'Sanjeet', N'Jaipur', N'7894568595')
INSERT [dbo].[Customers] ([Id], [CustomerName], [CustomerAddress], [CustomerNumber]) VALUES (7, N'Testing', N'Testing', N'1231231231')
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
/****** Object:  StoredProcedure [dbo].[SearchCustomerById]    Script Date: 12-02-2025 13:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchCustomerById]
    @CustomerId INT
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, CustomerName, CustomerAddress, CustomerNumber
    FROM Customers
    WHERE Id = @CustomerId;
END;
GO
/****** Object:  StoredProcedure [dbo].[SearchCustomerByName]    Script Date: 12-02-2025 13:26:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SearchCustomerByName]
    @CustomerName NVARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT Id, CustomerName, CustomerAddress, CustomerNumber 
    FROM Customers
    WHERE CustomerName LIKE '%' + @CustomerName + '%';
END;
GO
