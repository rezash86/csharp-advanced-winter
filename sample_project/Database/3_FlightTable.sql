USE [Airline]
GO

/****** Object:  Table [dbo].[Flight]    Script Date: 2020-05-10 1:19:20 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Flight](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DepartureTime] [datetime] NULL,
	[ArrivalTime] [datetime] NULL,
	[DepartureCity] [nvarchar](50) NULL,
	[ArrivalCity] [nvarchar](50) NULL,
	[AvailableSeats] [int] NULL,
	[Price] [decimal](12, 2) NULL,
 CONSTRAINT [PK_Flight] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

