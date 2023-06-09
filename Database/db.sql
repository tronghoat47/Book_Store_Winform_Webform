USE [master]
GO
/****** Object:  Database [Project_Book]    Script Date: 3/20/2023 3:25:45 PM ******/
CREATE DATABASE [Project_Book]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project_Book', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ANHBOM\MSSQL\DATA\Project_Book.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_Book_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.ANHBOM\MSSQL\DATA\Project_Book_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Project_Book] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Project_Book].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Project_Book] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Project_Book] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Project_Book] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Project_Book] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Project_Book] SET ARITHABORT OFF 
GO
ALTER DATABASE [Project_Book] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Project_Book] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Project_Book] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Project_Book] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Project_Book] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Project_Book] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Project_Book] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Project_Book] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Project_Book] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Project_Book] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Project_Book] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Project_Book] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Project_Book] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Project_Book] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Project_Book] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Project_Book] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Project_Book] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Project_Book] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Project_Book] SET  MULTI_USER 
GO
ALTER DATABASE [Project_Book] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Project_Book] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Project_Book] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Project_Book] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Project_Book] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Project_Book] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Project_Book] SET QUERY_STORE = OFF
GO
USE [Project_Book]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[AccountId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](20) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Phone] [varchar](15) NULL,
	[Address] [nvarchar](50) NULL,
	[RoleId] [int] NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookId] [int] IDENTITY(1,1) NOT NULL,
	[BookName] [nvarchar](300) NOT NULL,
	[Author] [nvarchar](100) NULL,
	[Title] [nvarchar](200) NULL,
	[Describe] [nvarchar](max) NULL,
	[Price] [money] NOT NULL,
	[Discount] [float] NULL,
	[ReleaseDate] [date] NULL,
	[CategoryId] [int] NULL,
	[Sold] [int] NULL,
	[RatingPoint] [float] NULL,
 CONSTRAINT [PK__Book__3DE0C20790834B46] PRIMARY KEY CLUSTERED 
(
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cart]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cart](
	[CartID] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NULL,
	[TotalMoney] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[CartID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CartDetail]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CartDetail](
	[CartId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Quantity] [int] NULL,
 CONSTRAINT [PK__CartDeta__51BCD7B7FDFBEC35] PRIMARY KEY CLUSTERED 
(
	[CartId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](100) NOT NULL,
	[Image] [varchar](max) NULL,
 CONSTRAINT [PK__Category__19093A0B35171006] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[AccountId] [int] NOT NULL,
	[OrderDate] [date] NULL,
	[Note] [nvarchar](200) NULL,
	[ShippingAddress] [nvarchar](200) NULL,
	[Status] [nvarchar](50) NULL,
	[TotalMoney] [money] NULL,
 CONSTRAINT [PK__Order__C3905BCFE5A0D37E] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[OrderId] [int] NOT NULL,
	[BookId] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_OrderDetail_1] PRIMARY KEY CLUSTERED 
(
	[OrderId] ASC,
	[BookId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[BookId] [int] NOT NULL,
	[AccountId] [int] NOT NULL,
	[Comment] [varchar](200) NULL,
	[Rating] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[BookId] ASC,
	[AccountId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 3/20/2023 3:25:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](30) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 

INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (2, N'ad', N'1', N'Trọng Hòa dz vkl', N'fgdgdg', N'34324234', N'Tiểu vương quốc', 1)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (3, N'ahihi', N'123@123a', N'vxcvxcv', N'rwerwe', N'565656', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (4, N'anhthang', N'anhtu', N'42342342', N'fgdgdg', N'2434324', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (5, N'hieuthu2', N'thuhai', N'dfgdg', N'hdghd', N'23232', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (6, N'hoa', N'2222', N'bdbdf', N'fadsfasd', N'455435', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (7, N'hoaahihihi', N'tronghoa', N'fsdfsd', N'adasdsad', N'123123', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (8, N'hoadz', N'123321', N'fdsfsdf', N'dd', N'576474', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (9, N'hoiahi', N'0000', N'hfghgh', N'das', N'32434312', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (10, N'khongbiet', N'123456', N'fsdfsdf', N'd', N'123131', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (11, N'mnsd', N'111', N'sadasd', N'asddas', N'4534534', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (12, N'nguoiho', N'thitho', N'dasdad', N'dasd', N'12313', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (13, N'nhieukhi', N'123321', N'dasdasdasd', N'dsdsdsds', N'53453', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (14, N'sa', N'123', N'hfghfh', N'sdaas', N'12313123', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (15, N'sonphot', N'dinhphot', N'bvcbcvc', N'ds', N'54235435', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (16, N'tambeo', N'beo123', N'dsfdfadf', N'asdasdas', N'31312321', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (17, N'wibu', N'imwibu', N'rewrwerw', N'dsadas', N'543543', NULL, 2)
INSERT [dbo].[Account] ([AccountId], [Username], [Password], [Name], [Email], [Phone], [Address], [RoleId]) VALUES (18, N'a', N'1', N'Ảo', N'dfsdfsdf', N'423432', N'Test', 2)
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (1, N'Hà Nội Phố Ngàn Phố', N'Nhiều tác giả', N'NXB Dân Trí', N'Dù với kẻ ở hay người đi, thành phố luôn là một mảng ký ức, là chốn rong chơi, hay đơn giản là nơi hẹn hò một thuở. Và dù có thể tiếc nuối, so sánh, chê bai, hay bực tức về những còn và mất của thành phố này, dường như ai cũng muốn nói và viết một chút ý niệm của mình về nó. Có những ngõ phố nhỏ, những gánh hàng rong, những cây cổ thụ trăm năm, và cũng có những tòa nhà cao vút, xe cộ đi lại như mắc cửi, khói bụi ồn ào. ', 80.0000, 20, CAST(N'2019-08-26' AS Date), 1, 12, 1.3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (2, N'Bi Kịch Gia Đình', N'Hoàng Lại Giang', N'NXB Trọng Hòa', N'Bi Kịch Gia Đ&igrave;nh l&agrave; cuốn tiểu thuyết phản ảnh nguy&ecirc;n nh&acirc;n của tấn bi kịch m&agrave; mỗi gia đ&igrave;nh &iacute;t hoặc nhiều đều trải qua. Ở đ&acirc;y vai tr&ograve; của người phụ nữ l&agrave; cực k&igrave; quan trọng. Người phụ nữ phương Đ&ocirc;ng, đặc biệt l&agrave; Việt Nam, vốn gi&agrave;u đức hy sinh, t&iacute;nh chịu đựng, nh&iacute;n nhịn, chịu thương chịu kh&oacute;, v&agrave; đặc biệt l&agrave; tr&aacute;i tim nồng ấm v&agrave; vị tha... nhằm giữ tổ ấm gia đ&igrave;nh. Gia đ&igrave;nh ở Việt Nam l&agrave; tế b&agrave;o quan trọng nhất của x&atilde; hội. Nếu gia đ&igrave;nh kh&ocirc;ng ổn định th&igrave; đất nước sẽ kh&ocirc;ng ổn định. Khi đất nước kh&ocirc;ng ổn định th&igrave; c&aacute;i họa mất nước sẽ l&agrave; thời gian m&agrave; th&ocirc;i!!! Nguy&ecirc;n nh&acirc;n của sự mất ổn định gia đ&igrave;nh thường bắt đầu bằng t&iacute;nh quyết đo&aacute;n đến vũ đo&aacute;n của người đ&agrave;n &ocirc;ng, của người chồng, người cha. H&agrave;ng ngh&igrave;n năm phong kiến tạo ra từ trong huyết quản của người đ&agrave;n &ocirc;ng t&iacute;nh gia trưởng dẫn đến quyết đo&aacute;n v&agrave; vũ đo&aacute;n. Th&aacute;i độ cực đoan n&agrave;y ở người đ&agrave;n &ocirc;ng bắt nguồn từ sự xả th&acirc;n trước kẻ th&ugrave; nhằm gi&agrave;nh lại nền độc lập v&agrave; giữ vững nền độc lập, tự chủ v&agrave; tự cường. Từ đ&oacute; dẫn đến sự nể trọng tự nhi&ecirc;n của x&atilde; hội trước đ&acirc;y v&agrave; sau n&agrave;y. Ở c&aacute;c nước phương T&acirc;y, con c&aacute;i đến tuổi 18 l&agrave; tự lực, hoặc tự xin việc l&agrave;m, hoặc vay tiền nh&agrave; nước v&agrave;o c&aacute;c trường đại học. Ở Việt Nam mỗi gia đ&igrave;nh thường c&oacute; đến hai thế hệ, hoặc ba thế hệ trong một m&aacute;i nh&agrave;. M&acirc;u thuẫn gay gắt nhất thường l&agrave; m&acirc;u thuẫn giữa cha v&agrave; con. Trong Bi Kịch Gia Đ&igrave;nh, t&aacute;c giả phản ảnh người con trai cả kh&ocirc;n kh&eacute;o đi theo con đường ri&ecirc;ng của m&igrave;nh; dựa v&agrave;o thế của bố nhằm thăng tiến. Người con thứ hai trung thực v&agrave; thẳng t&iacute;nh, lu&ocirc;n coi mỗi thế hệ đều c&oacute; tr&aacute;ch nhiệm của m&igrave;nh. Anh đ&atilde; lăn xả v&agrave;o cuộc chiến tranh chống Mỹ, kh&ocirc;ng sợ hy sinh. May mắn anh kh&ocirc;ng hy sinh, nhưng anh nhận ra c&aacute;i gi&aacute; của cuộc chiến tranh l&agrave; qu&aacute; lớn, l&agrave; qu&aacute; đắt! Người con g&aacute;i &uacute;t th&igrave; dựa uy thế bố... lo l&agrave;m gi&agrave;u cho ri&ecirc;ng m&igrave;nh bằng những con đường bất ch&iacute;nh! Vai tr&ograve; người vợ người mẹ ở đ&acirc;y thật kh&ocirc;ng dễ!!! Đấy l&agrave; chưa kể người phụ nữ kh&aacute;c m&agrave; chồng m&igrave;nh một thời từng dan d&iacute;u c&ugrave;ng với đứa con ri&ecirc;ng, m&agrave; &ocirc;ng kh&ocirc;ng nhận. Bi kịch của gia đ&igrave;nh n&agrave;y thật gay gắt, gay gắt đến kh&ocirc;ng tưởng tượng nổi! L&ograve;ng vị tha đ&atilde; đẩy những người phụ nữ tưởng l&agrave; kẻ th&ugrave; của nhau x&iacute;ch lại gần nhau... L&ograve;ng vị tha của người phụ nữ một lần nữa lại khiến ch&uacute;ng ta kh&acirc;m phục. Dầu sao, t&aacute;c giả cũng l&agrave; chứng nh&acirc;n của nhiều gia đ&igrave;nh đương thời với những bi kịch thật kh&oacute; h&oacute;a giải! T&aacute;c giả xin ghi lại đ&acirc;y những tấn bi kịch... hy vọng đọc giả sẽ suy nghĩ ở đất nước Việt Nam ch&uacute;ng ta, h&ocirc;m qua v&agrave; h&ocirc;m nay... vẫn c&ograve;n những gia đ&igrave;nh ẩn chứa những tấn bi kịch m&agrave; người chịu đựng vẫn l&agrave; những người vợ; người mẹ
', 91.9900, 18, CAST(N'2022-10-23' AS Date), 1, 3, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (3, N'Hướng Dẫn Kiếm Tiền Trên Tiktok', N'Giang Trung Nguyên', N'NXB Tiền Phong', N'TikTok là m&ocirc;̣t ph&acirc;̀n m&ecirc;̀m giao ti&ecirc;́p xã h&ocirc;̣i đ&ecirc;̉ tạo nhạc và có th&ecirc;̉ quay các video ngắn, đ&ocirc;̀ng thời, đ&acirc;y cũng là c&ocirc;̣ng đ&ocirc;̀ng video có đ&ocirc;̣ dài 15 gi&acirc;y chuy&ecirc;n dành cho giới trẻ. Fan có th&ecirc;̉ lựa chọn ca khúc và quay m&ocirc;̣t video ngắn 15 gi&acirc;y th&ocirc;ng qua ph&acirc;̀n m&ecirc;̀m này và tạo ra tác phẩm của chính mình. Kh&ocirc;ng ít cá nh&acirc;n thu được lợi tức tr&ecirc;n TikTok. Ngoài ra, cũng có kh&ocirc;ng ít c&ocirc;ng ty cũng xem TikTok như m&ocirc;̣t địa đi&ecirc;̉m marketing mới của mình. TikTok n&ocirc;̉i ti&ecirc;́ng, hay có th&ecirc;̉ nói là m&ocirc;̣t hi&ecirc;̣n tượng v&ocirc; cùng n&ocirc;̉i ti&ecirc;́ng. Khi TikTok n&ocirc;̉i ti&ecirc;́ng, m&ocirc;̣t s&ocirc;́ thương hi&ecirc;̣u hoạt đ&ocirc;̣ng tr&ecirc;n TikTok cũng n&ocirc;̉i ti&ecirc;́ng theo, đồng thời, những lợi tức mà thương gia và các cá nh&acirc;n thu được tr&ecirc;n TikTok l&agrave; kh&aacute; lớn. Kiếm tiền l&agrave; mục ti&ecirc;u cu&ocirc;́i cùng của vi&ecirc;̣c làm TikTok. N&ecirc;́u tài khoản TikTok mu&ocirc;́n hoạt đ&ocirc;̣ng dài l&acirc;u mà chỉ có đam m&ecirc; và y&ecirc;u thích thì chưa đủ, mà nó c&acirc;̀n có nhi&ecirc;̀u tài nguy&ecirc;n đ&ecirc;̉ duy trì, đi&ecirc;̀u này đòi hỏi tài khoản TikTok phải ki&ecirc;́m được ti&ecirc;̀n, chỉ như v&acirc;̣y mới có th&ecirc;̉ giúp hoạt đ&ocirc;̣ng giao dịch của bản th&acirc;n trở n&ecirc;n lớn mạnh hơn. Bất kể l&agrave; c&aacute; nh&acirc;n hay c&ocirc;ng ty, nếu muốn c&oacute; được thời gian của fan, ngo&agrave;i việc sử dụng nội dung hấp dẫn để k&iacute;ch th&iacute;ch thị gi&aacute;c ra, điều quan trọng nhất ch&iacute;nh l&agrave; bồi dưỡng th&oacute;i quen sử dụng của fan. Một khi fan đ&atilde; &ldquo;nghiện&rdquo; th&igrave; t&agrave;i khoản sẽ nổi tiếng hơn. Th&agrave;nh c&ocirc;ng của Tiktok ch&iacute;nh l&agrave; nắm bắt được điểm n&agrave;y. Cho dù là sử dụng n&ecirc;̀n tảng giao ti&ecirc;́p xã h&ocirc;̣i nào cũng phải học được cách marketing cho bản th&acirc;n. N&ecirc;́u mu&ocirc;́n tài khoản TikTok của bạn được chú ý nhi&ecirc;̀u hơn thì phải h&acirc;́p d&acirc;̃n được nhi&ecirc;̀u fan, phải nắm vững nhi&ecirc;̀u cách phát tri&ecirc;̉n chuy&ecirc;n nghi&ecirc;̣p đ&ecirc;̉ th&ecirc;̉ hi&ecirc;̣n bản th&acirc;n trước mặt mọi người. Xét từ góc đ&ocirc;̣ thay đ&ocirc;̉i và sức mua của fan, ch&acirc;́t lượng lưu lượng của TikTok là cao nh&acirc;́t và cũng phù hợp với hoạt đ&ocirc;̣ng quảng cáo nh&acirc;́t. Hi&ecirc;̣n nay, lợi tức của TikTok đang ở giai đoạn tăng trong hình chữ U ngược, n&ecirc;́u mu&ocirc;́n thu được nhi&ecirc;̀u lợi tức thì phải nắm bắt được. V&acirc;̣y sử dụng TikTok như th&ecirc;́ nào mới thu hút được nhi&ecirc;̀u lượng truy c&acirc;̣p hơn? &ldquo;Hướng dẫn kiếm tiền tr&ecirc;n TikTok&rdquo; sẽ giải quy&ecirc;́t v&acirc;́n đ&ecirc;̀ đó. Cu&ocirc;́n sách này đề cập đ&ecirc;́n mọi khía cạnh việc l&agrave;m TikTok bao gồm x&aacute;c định vị tr&iacute;, content, video, thu h&uacute;t fan, ph&aacute;t triển, ma trận, lặp lại v&agrave; kiếm tiền, với những ví dụ đầy đủ, bắt đ&acirc;̀u từ khái ni&ecirc;̣m TikTok đ&ecirc;́n kỹ xảo thao tác thực t&ecirc;́. TikTok có giá trị cao là đi&ecirc;̀u kh&ocirc;ng th&ecirc;̉ nào nghi ngờ, các cá nh&acirc;n và thương gia hãy nh&acirc;n cơ h&ocirc;̣i t&ocirc;́t đ&ecirc;̉ nắm vững kỹ xảo và phương hướng đặt n&ecirc;̀n tảng cho vi&ecirc;̣c hoạt đ&ocirc;̣ng TikTok, kịp thời thu lợi nhu&acirc;̣n từ TikTok!', 189.0000, 15, CAST(N'2021-11-09' AS Date), 2, 4, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (4, N'Bùng Nổ Tiếng Anh - 27 Giới Từ Hữu Ích Trong Tiếng Anh Giao Tiếp', N'Moon Deok , Jihu Ju', N'NXB Dân Trí', N'Cuốn sách đưa ra ý nghĩa và cách sử dụng của 27 giới từ phổ biến trong tiếng Anh. 27 giới từ này đồng thời được chia thành các nhóm dựa vào những “điểm liên quan” giữa chúng, như: “Top 4 giới từ” (phổ biến nhất) gồm At, On, In và To; giới từ “Ra ra vào vào” (Into, Out, Off, From); nhóm “Đi lên nào, ta đi lên nào!” bao gồm Over, Above, Beyond và Up,… cùng nhiều màu sắc và hình ảnh vui tươi giúp việc học tiếng Anh trở nên thú vị hơn rất nhiều.

Với mỗi giới từ, tác giả trình bày nghĩa gốc cùng vị trí đứng khi chúng ở trong câu. Mỗi trường hợp đều đi kèm với các ví dụ “bám sát” thực tế khi giới từ kết hợp với các động từ và danh từ cụ thể, hình ảnh minh họa ngộ nghĩnh, lưu ý đối với các trường hợp đặc biệt mà người học có thể nhầm lẫn và một câu chuyện thường ngày của chú Vịt Mặt Trăng hài hước. Cuối cùng, phần Ôn tập vừa giúp người đọc luyện tập về giới từ vừa học cách hiểu và dịch nghĩa cả một câu tiếng Anh hoàn chỉnh.', 199.0000, 15, CAST(N'2017-03-21' AS Date), 7, 12, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (5, N'Cách Mạng Công Nghệ 4.0 (Chuyên Đề 1 - Tháng 4/2018)', N'NXB Thanh Niên', N'NXB Dân Trí', N'Chuyên đề Cách mạng công nghệ 4.0 đồng hành cùng độc giả để đưa đến cho các bạn những kiến thức cũng như trải nghiệm mới nhất về công nghệ, cùng hướng tới những mục tiêu:

Nỗ lực trở thành ấn phẩm công nghệ có uy tín và vị thế hàng đầu tại Việt Nam;
Xây dựng một cộng đồng đam mê công nghệ và đầu tư thông minh;
Góp phần nâng cao hiểu biết của cộng đồng và nâng cao vị thế của người Việt trong công nghệ Blockchain nói riêng và công nghệ 4.0 nói chung trên trường quốc tế.', 29.0000, 19, CAST(N'2022-02-11' AS Date), 8, 1, 2)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (6, N'Trên Những Dặm Đường', N' Nguyễn Đức Liên', N'NXB Dân Trí', N'“Tôi may mắn đi vòng quanh đến 40 quốc gia và vùng lãnh thổ, so với các phượt thủ chưa đáng là bao, nhưng “Trên những dặm đường”thực sự vượt cả mong đợi, giúp tôi có trong tay bộ sưu tập hình ảnh tương đối về năm châu, bốn biển.

Thiên nhiên, phong cảnh, lịch sử, văn hóa, kiến trúc, ẩm thực... của mỗi quốc gia trở thành bài học sinh động, thực tế, giúp tôi tích lũy kiến thức, mở rộng tầm nhìn, nuôi dưỡng trong tôi tình yêu thiên nhiên cùng trái tim luôn khát khao về cuộc sống bình an, hạnh phúc. Ước mơ bay cao, bay xa còn ở phía trước và tôi hy vọng tiếp tục được khám phá”...trích "Trên Những Dặm Đường"', 140.0000, 15, CAST(N'2015-11-02' AS Date), 1, 2, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (7, N'Hỏi Nhỏ Biết To - Cổ Sinh Vật (Tái Bản 2022)', N'Nhiều tác giả', N'NXB Dân Trí', N'Sự sống bắt nguồn như thế nào?

“Đại sát thủ” của kỉ Jura là loài nào?

Có chuồn chuồn nào to như chim không?

Với những câu hỏi thú vị về cổ sinh vật, phần trả lời ngắn ngon, súc tích cùng hình ảnh minh họa sinh động, ngộ nghĩnh, bộ sách Hỏi nhỏ biết to Cổ sinh vật mở ra cho các bạn nhỏ cả một kho tri thức diệu kì về thế giới cổ sinh vật. Từ nguồn gốc của sự sống, đến những thông tin thú vị về các loài khủng long, hóa thạch, voi ma mút... đầy kì bí.

Bộ sách sẽ là nguồn cảm hứng vô tận cho các bạn nhỏ yêu thích đam mê tìm tòi, khám phá, chắp cánh cho những ước mơ bay cao.', 34.0000, 32, CAST(N'2022-01-02' AS Date), 5, 2, 2)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (8, N'Người Mẹ Tốt Hơn Là Người Thầy Tốt', N'Doãn Kiến Lợi', N'NXB Dân Trí', N'Người Mẹ Tốt Hơn Là Người Thầy Tốt đã đặt ra vẫn đề muôn thuở với các vị phụ huynh, đó là giáo dục con cái. Là một trong số ít những cuốn sách được đánh giá cao về giáo dục gia đình, Người Mẹ Tốt Hơn Là Người Thầy Tốtt gồm bảy chương với các chủ đề khác nhau, theo trẻ trừ khi còn nhỏ cho đến lúc trưởng thành.

Người Mẹ Tốt Hơn Là Người Thầy Tốt đưa ra nhiều quan điểm mà các bậc cha mẹ phải lưu ý khi dạy trẻ bởi có thể đối với người lớn, đó là vấn đề rất nhỏ nhặt nhưng với con trẻ lại là chuyện lớn. Cuốn sách phân tích và nhận xét toàn diện quanh việc giáo dục con cái như điểm số, học hành, giải trí, khen, phạt, Những kinh nghiệm trong sách được tác giả đúc rút bằng chính trải nghiệm của bản thân mình qua việc dạy dỗ con cái.

Người Mẹ Tốt Hơn Là Người Thầy Tốt đánh giá rất cao vai trò của giáo dục gia đình trong việc định hình nhân cách những đứa trẻ. Và tất nhiên, không thể thiếu trong mọi phương pháp dạy trẻ, Người Mẹ Tốt Hơn Là Người Thầy Tốt có nền tảng bằng tình yêu thương của người mẹ dành cho con.

Cuốn sách Người Mẹ Tốt Hơn Là Người Thầy Tốt là một cuốn sổ tay về cách nuôi dạy con của nhà giáo, thạc sĩ Doãn Kiến Lợi. Chị đã tổng kết kinh nghiệm gần hai mươi năm nuôi dạy con, đồng thời kết hợp với một nền tảng lí thuyết vững chắc và kinh nghiệm thực tế có được trong quá trình trực tiếp dạy học cũng như tiếp xúc với khá nhiều trẻ em, từ đó đúc rút ra được những bài học quý báu trong cuốn sách này.

Người mẹ tốt hơn là người thầy tốt đề cập đến rất nhiều vấn đề lớn nhỏ trong quá trình nuôi dạy con cái, nhưng tựu chung lại có thể gói gọn thành hai vế: đó là nuôi dưỡng tâm hồn và trí tuệ của con trẻ. Tác giả không viết về những thứ quá vĩ mô và trừu tượng mà ngược lại, thạc sĩ Doãn Kiến Lợi nuôi dưỡng tâm hồn và trí tuệ của trẻ từ những điều đơn giản nhất, như chính tác giả đã viết “Với trẻ em không có chuyện nhỏ, mọi chuyện nhỏ đối với trẻ đều là chuyện lớn”.

Cuốn sách được trình bày dưới dạng những bài viết nhỏ, mỗi bài viết đề cập đến một vấn đề trong quá trình nuôi dạy con cái mà hầu hết các bậc phụ huynh đều gặp phải như làm thế nào để trẻ không sợ tiêm, trả lời thế nào khi trẻ hỏi em bé từ đâu đến, làm thế nào khi con trẻ nói dối, tạo lập những phẩm chất tính cách tốt đẹp cho con trẻ… đến những vấn đề trong học tập như dạy con biết chữ, làm toán, viết văn… Những bài viết này rất chân thực, gần gũi, dễ hiểu, không đi vào lối mòn sáo rỗng và nặng về lí thuyết, rất dễ dàng cho các bậc phụ huynh đọc và ứng dụng.

Ngoài ra, trong cuốn sách này, thạc sĩ Doãn Kiến Lợi cũng đề cập đến một số vấn đề bất cập trong hệ thống giáo dục Trung Quốc và các đối sách cần có của các bậc phụ huynh. Hệ thống giáo dục của Việt Nam có nhiều điểm tương đồng với hệ thống giáo dục của Trung Quốc, vì vậy bạn đọc cũng có thể tham khảo và tự tìm ra cho mình những cách giải quyết riêng.

Tác giả cuốn sách là một nhà giáo, một chuyên gia giáo dục có nhiều năm làm công tác giảng dạy, tư vấn và nghiên cứu giáo dục gia đình, nhưng trên hết chị còn là một người mẹ. Vì vậy, trong cuốn sách này, ngoài những quan niệm giáo dục độc đáo đầy trí tuệ, người đọc còn có thể bắt gặp tình yêu con sâu sắc ngập tràn trong từng trang viết của chị. Tác giả quan niệm: Các bậc phụ huynh cần đứng trên góc độ của con trẻ để nhìn nhận vấn đề, đừng bắt ép con trẻ sống theo lối sống mà người lớn áp đặt cho chúng. Bởi vì “trẻ em là một thế giới tồn tại độc lập hoàn mỹ, trong cơ thể bé nhỏ của chúng ẩn chứa sức sống mạnh mẽ vô biên, trong quá trình trưởng thành chúng có một tiềm lực biểu đạt tự mình nhào nặn, tự mình thành hình, giống như bên trong một hạt giống có ẩn chứa rễ, lá, hoa, trong điều kiện thích hợp tự nhiên sẽ phát triển" (Trích “Người mẹ tốt hơn là người thầy tốt”). Đây thực sự là một quan niệm giáo dục độc đáo và đầy tiến bộ, rất đáng cho chúng ta nghiên cứu và học hỏi.

Cuốn sách phù hợp cho những người làm công tác giáo dục, quan tâm đến giáo dục và những người sắp làm cha, làm mẹ cũng như các bậc phụ huynh có con ở độ tuổi thiếu nhi đến độ tuổi mười bảy, mười tám.', 135.0000, 15, CAST(N'2021-12-04' AS Date), 4, 3, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (9, N'Tư Duy Đột Phá (Tái Bản 2022)', N'Gerald Nadler, Shozo Hibino', N'Bìa mềm', N'“Tư duy, một khi đã được mở ra và vươn đến những chiều kích rộng lớn hơn về ý tưởng, sẽ không bao giờ thụt lùi về giới hạn ban đầu”', 143.0000, 36, CAST(N'2022-04-21' AS Date), 3, 2, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (10, N'100 Truyện Ngụ Ngôn Song Ngữ Anh - Việt Hay Nhất', N'Nguyễn Châu Nguyên', N'Nxb Mỹ thuật', N'Cuốn sách này tổng hợp 100 truyện ngụ ngôn đặc sắc nhất của nhiều quốc gia trên thế giới.

Mỗi truyện lại mang đến những bài học đáng quý khác nhau, nhờ đó mà trẻ có thể học được nhiều điều hay, lẽ phảo, tu dưỡng ý chí phấn đấu, tự hoàn thiện bản thân.

Không chỉ vậy, cuốn sách được viết dưới dạng song ngữ Anh - Việt sẽ giúp trẻ nâng cao vốn từ vựng, học cách sử dụng đúng ngữ pháp và trở nên thích thú với Tiếng Anh.', 106.0000, 15, CAST(N'2022-03-01' AS Date), 5, 32, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (11, N'101 Từ Đầu Tiên: Chữ Số-Hình Dạng-Màu Sắc - 101 First Words: Numbers-Shapes-Colours', N'Milo Kids', N'Nxb Mỹ thuật', N'- Bé sẽ được phát triển vốn từ tiếng Anh thông qua các chủ đề gần gũi như Giao thông, Bảng chữ cái, Các vật dụng trong nhà hay các chủ đề mang tính khám phá như Động vật…

- Không những thế, việc chọn lựa phương pháp chuyển tải thú vị của cuốn sách đã mở ra cho các em một thế giới hình ảnh sinh động và đầy màu sắc, giúp bé tiếp thu kiến thức và ghi nhớ dễ dàng hơn.

- Cuốn sách không chỉ có hình ảnh minh hoạ màu sắc, đáng yêu, mà còn là công cụ tuyệt vời để các bậc phụ huynh giúp bé yêu của mình sớm nhận diện được mọi thứ xung quanh, giúp bé phát triển giác quan, ngôn ngữ.', 51.0000, 8, CAST(N'2021-04-02' AS Date), 5, 2, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (12, N'Hướng Dẫn Luyện Thi VSTEP - Trình Độ B1-C1', N' 1980 Edu', N' NXB Dân Trí', N'Nếu bạn đang có chung những câu hỏi như:

- VSTEP là kỳ thi như thế nào?

- Bài thi ở trình độ B1- C1 gồm những phần nào?

- Làm thế nào để ôn luyện được từng dạng bài xuất hiện trong kỳ thi?

Hướng dẫn luyện thi VSTEP trình độ B1 – C1 sẽ giải đáp toàn bộ những thắc mắc này. Cùng với việc giới thiệu chi tiết cấu trúc về một bài thi ở trình độ B1 – C1, cuốn sách còn giúp bạn định hướng và rèn luyện từng dạng bài cơ bản bám sát theo từng kỹ năng. Thông qua hệ thống bài tập và bài thi thử đa dạng, các bạn sẽ dễ dàng làm quen, củng cố kiến thức và xây dựng được chiến lược ôn luyện hiệu quả để bứt phá điểm số nhanh chóng trong kỳ thi sắp tới.', 135.0000, 15, CAST(N'2014-02-04' AS Date), 7, 23, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (13, N'Giúp Con Nói “Không” Với Đường', N'Michael Goran, Emily Ventura', N'NXB Dân Trí', N'Phần lớn chúng ta đều biết rằng đường có hại cho cơ thể người nhưng rất ít người nhận ra tác hại kinh khủng mà đường gây ra cho những đứa trẻ của chúng ta, về mặt thể chất, cảm xúc và sức khỏe tâm thần. Tiến sĩ, nhà nghiên cứu hàng đầu về tình trạng béo phì của trẻ em, Michael Goran (Trường Đại học Nam California) đã chỉ ra rằng ngày nay trẻ em không chỉ tiêu dùng nhiều lượng đường hơn mà còn nhiều dạng đường hơn trước. Điều này đặc biệt có hại cho sự phát triển của gan, tim và não bộ. Quan trọng hơn là không có nhiều bậc phụ huynh nhận ra ảnh hưởng xấu này lên những cơ thể non nớt của con cái họ.

Trong cuốn sách Giúp con nói “Không” với đường, các tác giả Goran và Ventura sẽ giúp cha mẹ nhận diện các loại đường trong thực phẩm, đồ ăn sẵn, chế độ ăn cho trẻ, xác định liệu trẻ có mắc các chứng bệnh rối loạn có liên quan đến đường, từ đó gây dựng giải pháp khả thi để bảo vệ con cái khỏi môi trường và thói quen tiêu thụ quá nhiều đường như hiện nay.

Thông qua nhiều nghiên cứu khoa học vững chắc, nhóm của Goran đã tiến hành những phân tích cụ thể về những loại thực phẩm mà trẻ yêu thích như sữa chua, nước ngọt, ngũ cốc, để phát hiện ra chúng thường chứa nhiều đường hơn quảng cáo, thậm chí nhiều loại đường hơn hiểu biết thông thường hay ghi chú trên nhãn thực phẩm. Nhiều đường hơn và có hại cho sức khỏe hơn, tệ nhất là cha mẹ không hay biết.

Tin tức khủng khiếp nhưng vẫn còn đó những hi vọng. Cuốn sách này chắc chắn sẽ mang đến cho các bậc phụ huynh những hướng dẫn cụ thể và những sự thật kinh ngạc về đường, tác động của đường đến với cơ thể và trí óc trẻ, nhưng đồng thời cũng sẽ chỉ ra những tiến bộ có thể thấy rõ rệt như trí nhớ được tăng cường, khả năng học tập và sức đề kháng khi chúng ta cắt giảm đường. Cuốn sách cung cấp cho độc giả những chiến lược để giảm đường, kế hoạch dần dần loại bỏ đường ra khỏi chế độ ăn thông qua Thử thách 7 Ngày và 28 Ngày, kèm theo những gợi ý về bữa ăn và cách để mọi người trong gia đình cùng tham gia vào chiến dịch “chống đường” ngọt ngào này, mang đến một khởi đầu mới cho thế hệ tương lai.', 127.0000, 25, CAST(N'2021-03-23' AS Date), 5, 2, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (14, N'Tâm Lý Học Thuyết Phục', N'Oren Klaff', N'NXB Công Thương', N'“Ngày nay, sản phẩm không phải để bán, mà là để mua.” Hoạt động bán hàng biến đổi hằng ngày và cách thức người mua thực hiện giao dịch cũng đang thay đổi cách thức người bán thực hiện chào hàng. Thay vì thúc ép dẫn đến kháng cự, cách hiệu quả hơn để chinh phục người mua là khiến họ bị thuyết phục và tự nguyện chi tiền. “Tâm lý học thuyết phục” cung cấp cho bạn phương pháp bán hàng hoàn toàn mới, không chèo kéo, không gây áp lực, giúp bạn có thể bán bất kỳ thứ gì cho bất kỳ ai.', 144.0000, 15, CAST(N'2018-03-05' AS Date), 3, 32, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (15, N'Blockchain: Bản Chất Của Blockchain, Bitcoin, Tiền Điện Tử, Hợp Đồng Thông Minh Và Tương Lai Của Tiền Tệ', N'Mark Gates', N'Nxb Lao động', N'Tiền điện tử, với đại diện tiêu biểu nhất là Bitcoin, đang là mối quan tâm hàng đầu của giới tài chính toàn cầu. Khả năng thanh toán bằng tiền điện tử mở ra hàng loạt tiềm năng cho thương mại và thay đổi toàn diện thói quen tiêu dùng của con người. Hạt nhân của công nghệ hứa hẹn rung chuyển thế giới này được gọi là Blockchain. Blockchain được giới công nghệ đánh giá là phát kiến vĩ đại nhất sau khi mạng Internet ra đời. Ứng dụng phổ biến nhất của nó là các loại tiền điện tử nổi tiếng (Bitcoin, Ethereum, Ripple...) đang làm mưa làm gió trên thị trường. Nhưng nghịch lý là, lại rất ít người nắm được bản chất của tiền điện tử và Blockchain. Rốt cuộc, Blockchain là gì? Nó hoạt động như thế nào? Blockchain thật sự là một đột phá trong công nghệ hay chỉ là một trào lưu nhất thời? Blockchain có liên hệ như thế nào với Bitcoin? Liệu Blockchain có nắm giữ tiềm năng thay đổi thế giới?... Thực chất, những bài viết cung cấp thông tin về Blockchain và tiền điện tử không thiếu trên các website hay mạng xã hội, nhưng lại chưa đủ tính bao quát và còn khó tiếp thu. Đó là lý do cuốn sách “BLOCKCHAIN: Bản chất của Blockchain, Bitcoin, tiền điện tử, hợp đồng thông minh và tương lai của tiền tệ” của Mark Gates ra đời. Gates cung cấp một bản tóm lược dễ hiểu nhất, cung cấp nền tảng thiết yếu cho những người mới bắt đầu và cả những ai muốn nghiên cứu sâu hơn về công nghệ Blockchain và tiền điện tử. Đọc cuốn sách này, bạn sẽ hiểu được Blockchain dưới nhiều khía cạnh, trong đó không chỉ có những lời ngợi khen mà còn không thiếu các chỉ trích, bình luận trái chiều.', 88.0000, 20, CAST(N'2021-12-04' AS Date), 8, 2, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (16, N'Được Nuôi Bởi Mẹ, Được Dạy Bởi Cha', N'An Nhĩ Tử', N'NXB Thanh Niên', N'Mỗi chúng ta, trước khi làm bố mẹ, đều vẫn luôn là một con người

Tuổi thơ một đi sẽ bao giờ quay trở lại, nhưng những gì đã trải qua vài thời thơ ấu không bao giờ biến mất. Nó hằn sâu vào trong chúng ta. Nếu đó la vết thương, nó dẽ trở thành sẹo, theo ta suốt cuộc đời

Câu nói “ Sinh con rồi mới sinh cha” thật sự vô cùng hữu lý. Muốn thay đổi con trẻ, quan trọng nhất là thay đổi bậc làm cha mẹ. Mong rằng mỗi đứa trẻ sẽ được ảnh hưởng một nền giáo dục tốt. Mong sao mỗi bậc phục huynh đều cảm nhận được niềm vui trong quá trình giáo dục con, tạo nên một đứa trẻ biết yêu thương và biết cách trưởng thành.', 83.0000, 15, CAST(N'2017-03-02' AS Date), 5, 2, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (17, N'Sống Sót Nơi Công Sở English Conversation- Tự Tin Giao Tiếp Với 25 Động Từ Và 75 Cấu Trúc Cơ Bản', N'Oh Soktae', N'NXB Dân Trí', N'Cuốn sách nằm trong bộ Cakewalk, tổng hợp 100 từ và cấu trúc hội thoại cơ bản dành cho những người mới bắt đầu. Thông qua các ví dụ cụ thể bám sát thực tiễn kèm file nghe và hình ảnh minh họa sinh động, người học có thể nhớ nghĩa của từ/cấu trúc lâu hơn và dễ dàng áp dụng chúng để diễn đạt được ý mình muốn nói, từ đó trở nên tự tin hơn khi giao tiếp tiếng Anh.', 169.0000, 15, CAST(N'2022-12-31' AS Date), 7, 34, 2)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (18, N'7 Loại Hình Thông Minh - Seven Kinds Of Smart', N'Thomas Armstrong', N'NXB Công Thương', N'Nội dung cuốn sách "7 loại hình thông minh" gồm có:

Những hiểu biết căn bản làm nền tảng về quá trình diễn ra hoạt động nhận thức của bạn.

Danh sách kiểm tra để xách định khả năng nhận thức nào của bạn là mạnh nhất và khả năng nào là yếu nhất.

Các bài tập thực hành nhằm khảo sát và làm quen với những phương pháp giúp trở nên thông minh, khôn ngoan hơn.

Các mẹo thực hành và những ý kiến đề nghị nhằm mục đích phát triển từng loại tài năng, trí thông minh khác nhau.

Các ý tưởng và nguồn động lực để áp dụng trực tiếp được học thuyết về nhiều loại trí thông minh này vào cuộc sống của bạn.

Thêm vào đó, quyển sách này đưa ra những ví dụ cụ thể về những phương pháp ứng xử thông minh, tài năng đã giành được điểm cao trong các cuộc thi nghề nghiệp, được lấy từ vô số những nền văn hoá khác nhau trên thế giới. Bạn cũng có cơ hội để thực tập những kỹ năng quan sát của Klahari Bushman, khả năng giao cảm, hiểu người của vị quan Manhatan, phương pháp thiền của vị sư Phật giáo Theravadan, năng lực sáng tạo hình tượng âm nhạc của một nhà soạn nhạc châu Âu và nhiều trường hợp khác nữa.

Quyển sách này chính là thứ dành cho bạn nếu bạn thực sự là người muốn mở rộng và phát triển được những năng khiếu tự nhiên của mình trong suốt cả cuộc đời.', 127.0000, 12, CAST(N'2016-11-03' AS Date), 3, 5, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (19, N'Thế Giới Miyazaki - Một Cuộc Đời Nghệ Thuật', N'Susan Napier', N'NXB Dân Trí', N'Nhắc đến anime, hẳn nhiều người trong chúng ta sẽ nghĩ ngay đến Studio Ghibli – một tượng đài huyền thoại của nền công nghiệp hoạt hình Nhật Bản. Xưởng phim hoạt hình nổi tiếng này từng được ví như giấc mơ của anime Nhật Bản, với những bộ phim hoạt hình của hãng làm mưa làm gió không chỉ trong nước mà còn trên khắp thế giới. Là một trong hai nhà sáng lập, đạo diễn kiêm hoạt họa gia vĩ đại, tài ba của Studio Ghibli, Hayao Miyazaki đã để lại ấn tượng không nhỏ trong lòng khán giả. Niềm ngưỡng mộ tài năng và những sáng tạo để đời của ông đã truyền cảm hứng cho tác giả Susan Napier viết cuốn sách Thế giới Miyazaki – Một cuộc đời nghệ thuật.

Thế giới Miyazaki được xem là cuốn tiểu sử bỏ túi mà những người đặc biệt yêu thích Miyazaki, Studio Ghibli, hay những bộ phim, nhân vật của ông nên có. Cuốn sách bao gồm 16 chương, với 3 chương đầu viết về quá trình Miyazaki bước chân vào thế giới hoạt hình, từ những ngày thơ bé đến khi thành lập nên xưởng phim Ghibli hiện thực hóa đam mê. Trong 13 chương còn lại, tác giả Napier lần lượt nói về những sáng tạo xen lẫn cuộc đời và cá tính của riêng ông.

Thông qua những bộ phim nổi tiếng, thậm chí là bom tấn như Dịch vụ chuyển phát nhanh của phù thủy Kiki, Lâu đài bay của pháp sư Howl, Hàng xóm của tôi là Totoro,… Napier đã cho độc giả thấy niềm yêu thích châu Âu cháy bỏng trong Miyazaki, đồng thời đề cập đến mối quan hệ của chính ông với mẹ, mối quan tâm về những phức tạp của tuổi trung niên, về thiên nhiên, đất nước, con người,… Có thể thấy mỗi sự kiện đó đã góp phần không nhỏ tạo nên nhà hoạt họa Nhật Bản vĩ đại, cùng những bộ phim, bộ truyện không chỉ mang tính giải trí cao mà còn chứa đựng những ẩn ý sâu sắc mang tính thời đại.

Susan Napier đã mở ra cánh cửa mời gọi bạn đọc bước vào những thế giới, nơi cuộc sống và quá khứ của vị đạo diễn tài ba được dùng làm bối cảnh cho cuộc thảo luận về chính Thế giới Miyazaki. Những bí mật về cuộc đời và nghệ thuật của Miyazaki đều sẽ được bật mí trong cuốn sách này. Và đúng như một lời khen dành cho cuốn sách rằng: “Trong Thế giới Miyazaki, Susan Napier thể hiện năng khiếu tường thuật và niềm đam mê đầy mê hoặc trong việc khám phá không – thời gian giữa các thế giới tưởng tượng trong những sáng tạo của Hayao Miyazaki và những thế giới nghiệt ngã hơn đã tạo ra vị đạo diễn tài ba ấy.”', 169.0000, 15, CAST(N'2019-02-24' AS Date), 1, 65, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (20, N'Tuyển Tập Truyện Cổ Grimm', N'Nhiều tác giả', N'NXB Phụ Nữ', N'Các em thiếu nhi luôn dành tình cảm đặc biệt cho thế giới cổ tích rộng lớn, kì ảo – nơi có các chàng hoàng tử quả cảm và những nàng công chúa đẹp xinh, có các bà tiên nhân hậu nhưng cũng có những mụ phù thủy độc ác, những con quỷ đáng sợ Ở đó, như các em luôn mong, luôn tin, luôn hi vọng, cái Thiện sẽ chiến thắng cái Ác, những người hiền lành, ngay thẳng sẽ được hưởng hạnh phúc, còn kẻ ác phải chịu trừng phạt.

Năm nay, Nhà xuất bản Phụ nữ Việt Nam trân trọng giới thiệu tới quý vị độc giả, đặc biệt là các bạn nhỏ, Tuyển tập truyện cổ Grimm được dịch từ nguyên bản tiếng Đức, với phiên bản bìa hoàn toàn mới, thích hợp làm quà tặng.

Bên cạnh những câu chuyện hấp dẫn mang đậm màu sắc dân gian Đức, tuyển tập này còn kèm theo minh họa màu sinh động, giúp các em hình dung rõ nét hơn về không gian cổ tích Grimm màu nhiệm, li kì, đầy ắp bất ngờ.', 132.0000, 15, CAST(N'2021-12-03' AS Date), 5, 54, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (21, N'Đắc Nhân Tâm', N'Donna Dale Carnegie', N'Nxb Tổng hợp TP.HCM', N'Phần 1: Nghệ thuật ứng xử cơ bản
Phần 2: 6 cách tạo thiện cảm
Phần 3: 12 cách hướng người khác suy nghĩ theo bạn
Phần 4: Chuyển hóa người khác mà không gây ra sự chống đối hay oán giận
Phần 5: Những bức thư nhiệm mầu
Phần 6: 7 Lời khuyên cho gia đình hạnh phúc', 58.0000, 12, CAST(N'2010-02-04' AS Date), 3, 43, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (22, N'Tránh Xa Người Lạ - Bộ Kỹ Năng Cho Trẻ Từ 1-6 Tuổi', N'Hồ Huy Sơn', N'Nhà phát hành: Trí Việt', N'Dạy kỹ năng cho trẻ luôn là điều mà các bậc phụ huynh luôn trăn trở. Nhất là khi trẻ ở độ tuổi từ 1 đến 6 tuổi, vì giai đoạn này, trẻ đã có nhiều cơ hội giao tiếp với cuộc sống, đã bắt đầu đi học mẫu giáo nhưng chưa ý thức được cũng như hiểu ý nghĩa hết những điều xảy ra ở môi trường xung quanh.

Để giúp trẻ có được những kỹ năng cơ bản khi giao tiếp với môi trường bên ngoài cũng như khi tiếp xúc với mọi người xung quanh. First News cho ra mắt Bộ kỹ năng cho trẻ từ 1 – 6 tuổi với phiên bản đẹp, được in 4 màu với phần minh họa được vẽ rất bắt mắt. Nội dung các quyển sách gần gũi và thiết thực với các em. Sau mỗi câu chuyện là mục Bé Biết Không? và Bé ơi nhớ nhé! giúp các bé hiểu được những kỹ năng cần có sau mỗi câu chuyện.

Với truyện Bé Nấm đi siêu thị có thể giúp các bé hiểu được việc phải xếp hàng đợi đến lượt mình được tính tiền, hay không nên vòi mẹ mua thật nhiều quà, bánh… Còn truyện Tránh xa người lạ lại giúp các bé hiểu được việc không nên tiếp xúc với người lạ, hoặc không để người lạ vuốt ve, hay không nên đi một mình đến nơi công cộng hay chỗ vắng người mà phải có người lớn đi cùng. Hoặc bé cần biết khi nào mình nên cảm ơn hoặc xin lỗi thông qua câu chuyện Xin lỗi và Cảm ơn. Và cám ơn hay xin lỗi cũng không phải đặc quyền của riêng trẻ nhỏ, mà ngay cả người lớn, bậc phụ huynh cũng nên cám ơn và xin lỗi con khi cần thiết.

Hình vẽ sinh động, màu sắc rực rỡ sẽ là món quà đầy ý nghĩa mà các bậc phụ huynh dành cho con mình. Nếu bé chưa biết đọc, bố hoặc mẹ có thể vừa đọc vừa giảng dạy cho bé hiểu để giúp bé có được những kỹ năng cần thiết trong cuộc sống.', 27.0000, 16, CAST(N'2020-12-04' AS Date), 5, 12, 2)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (23, N'Con Gái Tuổi Dậy Thì Muốn Nói Gì Với Cha Mẹ', N'Nakano Hidemi', N'NXB Phụ Nữ', N'Tinh thần và thể chất của con gái khi bước vào giai đoạn dậy thì thường ở trạng thái mất cân bằng và rất nhạy cảm. Con chưa phải là người lớn hẳn nhưng cũng không còn là một đứa trẻ con. Bị mắc kẹt giữa sự tự lập và sự phụ thuộc khiến nội tâm con tồn tại nhiều mâu thuẫn, xung đột. Hơn nữa, môi trường xung quanh con cũng ẩn chứa nhiều điều không an toàn. Do đó, với các bậc cha mẹ, giai đoạn con mới bước vào tuổi dậy thì cũng là giai đoạn quyết định trong quá trình nuôi dạy con. Chính vì vậy, thời kỳ này là thời kỳ cuối cùng để có những bước sửa đổi lớn trong phương pháp dạy con. 

Gửi tới bạn, những bậc phụ huynh đang lo lắng về cô con gái trong độ tuổi dậy thì của mình. Cảm ơn bạn vì đã lựa chọn cuốn sách này! ', 72.0000, 15, CAST(N'2019-12-18' AS Date), 4, 434, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (24, N'Bách Khoa Tri Thức Cho Trẻ Em - Câu Hỏi Và Trả Lời', N' NXB Dân Trí', N'NXB Dân Trí', N'Bạn đã bao giờ băn khoăn tự hỏi... Tại sao chim hồng hạc lại ăn ngược? Cái gì giữ một chiếc máy bay trực thăng trên trời? Xây một tòa lâu đài mất bao lâu? Ai đã phát minh ra hệ thống sưởi trung tâm? Cái gì đã giết chết loài khủng long? Trái đất bao nhiêu tuổi? Một quả cầu khí khổng lồ là gì?.

Được thiết kế với rất nhiều dữ liệu hấp dẫn và những câu hỏi thú vị, cuốn sách này là một món quà dành cho tất cả các em nhỏ thích khám phá từ khủng long, các loài chim, đại dương cho đến các lâu đài thời Trung cổ và kỷ nguyên công nghệ vũ trụ.

Được trình bày dưới dạng dễ đọc, mỗi một đề tài có một lời giới thiệu ngắn gọn kèm theo các câu hỏi thường gặp ở trẻ em, đưa các em trực tiếp đến với tri thức để gieo những hạt mầm trí tuệ ở khắp mọi nơi.Thích hợp cho việc tự đọc, hoặc đọc cùng bạn bè hay với người lớn. Mỗi một câu hỏi đều được trình bày một cách rõ ràng và dễ hiểu, đầy đủ ý bằng các hình minh họa hoặc biểu đồ.

Và để cuốn sách thêm phần sống động, có rất nhiều câu đố nhanh và thú vị ở cuối mỗi đề tài để kiểm tra kiến thức vừa được tiếp nhận của các em!', 285.0000, 22, CAST(N'2017-01-12' AS Date), 5, 32, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (25, N'Cách Khen Cách Mắng Cách Phạt Con', N'Wakamatsu Aki , Masami Sasaki', N'Nxb Lao động', N'Muốn con ngủ sớm thì nó lại chẳng chịu đi ngủ, muốn nó dừng bú mà nó cũng không chịu, lớn lên một chút thì nói cũng không nghe, vì nhút nhát mà bị thiệt thòi…Có rất nhiều vấn như vậy khiến chúng ta nhức đầu trong quá trình nuôi dạy con. Bất cứ người phụ nữ nào đã từng nuôi con đều hiểu rằng trên thế gian này rất nhiều việc không như mình muốn. Trong quyển sách này, tôi muốn giới thiệu một số quan điểm cơ bản và phương pháp nuôi dạy con dựa trên “cách khen”, “cách mắng”, “cách dạy dỗ” trẻ.

Ngay từ đầu, chúng ta phải làm sao để hiểu được con mình là đứa trẻ như thế nào? Phải nuôi dạy bằng cách nào? Việc hiểu được bản chất của sự phát triển của trẻ rất cần thiết đối với những bà mẹ đang gặp khó khăn trong quá trình nuôi dạy con.Chúng tôi đã nhận được nhiều bài viết chia sẻ về quan điểm nuôi dạy con cái dựa trên sự trưởng thành của trẻ từ Masami Sasaki, bác sĩ chuyên khoa tâm lý trẻ em, người đã tiếp xúc với rất nhiều với các bậc cha mẹ và con cái. Đối với con cái, điều quan trọng nhất là việc truyền đạt một cách dễ hiểu. Do đó, việc hiểu được “bản chất” của con cái là quan trọng. Với tư cách là một người mẹ, tôi nghĩ là có thể sử dụng “bí quyết” đó trong việc nuôi dạy con hằng ngày.

Lúc đó, tôi đã tới Salon Hidamari ở thành phố Akita của cô Wakamatsu Aki – nguyên là cựu giáo viên mẫu giáo. Salon Hidamari là nơi tổ chức các khóa huấn luyện dành cho các bà mẹ đang nuôi dạy con.Tại đây, thông qua truyện tranh và khoá học dành cho những người chăm sóc trẻ, tôi đã học được những bí quyết thành công của cô ấy để áp dụng vào việc nuôi dạy con.

Trong cuốn sách này, ngoài những cuộc trò chuyện trao đổi kinh nghiệm về cách nuôi dạy từ bác sĩ Masami Sasaki và cô Wakamatsu Aki, chúng tôi cũng thêm vào một vài đoạn giới thiệu khi còn nhỏ họ đã được cha mẹ giáo dục con như thế nào.

Chúng tôi cảm thấy rất vui nếu quý vị độc giả tìm thấy được trong quyển sách này những lời khuyên hữu ích và có thể áp dụng thành công trong quá trình nuôi dạy trẻ.', 58.0000, 16, CAST(N'2022-11-03' AS Date), 4, 1, 2)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (26, N'Hạt Giống Tâm Hồn 9 - Vượt Qua Thử Thách', N'Nhiều tác giả', N'Nxb Tổng hợp TP.HCM', N'Một vài câu chuyện khác thì xoay quanh cách chúng ta đối diện và vượt qua nỗi đau mất mát, để ta biết rằng “khi người thân, bạn bè của ta đau ốm hay sắp từ giã cuộc đời, chúng ta chấp nhận từ bỏ cuộc sống suôn sẻ, ổn định và những đêm ngon giấc của mình. Đổi lại, chính những người thân yêu sắp ra đi ấy sẽ dạy chúng ta biết rằng bên cạnh những biến cố trong đời, cuộc sống này cũng không hề thiếu tình yêu thương, sự sống mãnh liệt và những khoảnh khắc gắn kết quý giá”. Và còn nhiều câu chuyện nhân văn khác, nói về sự chữa lành, sức mạnh tinh thần cũng như sức bật của con người trước nghịch cảnh, cũng đang chờ được độc giả khám phá.', 65.0000, 14, CAST(N'2019-11-01' AS Date), 3, 2, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (27, N'Ehon Kỹ Năng Sống - Bé Trai Đi Toilet (Từ 1 - 5 Tuổi', N'Jinco', N'Nxb Lao động', N'Ehon Kỹ Năng Sống - Bé Trai Đi Toilet

Ehon Kỹ Năng Sống là bộ sách nuôi dạy trẻ, với ngôn từ dễ hiểu kèm tranh vẽ sẽ dạy bé cách giao tiếp lịch sự và lễ phép, sẽ mang đến cho bé những bài học ý nghĩa trong cuộc sống.

Cuốn sách vui nhộn này

rèn bé trai 1-5 tuổi

cách tự đi vệ sinh

nhanh nhẹn và sạch sẽ

 Tè đứng hay tè ngồi?

Có lau hay không nhỉ?

Phân thế nào là tốt?

Bệ xí xổm thì ngồi ra sao?

Cuốn sách có đầy đủ các tình huống, dạy bé trai xử trí trong toilet. Bố mẹ hãy kiên trì dạy con từng bước tự đi vệ sinh, với “giáo trình” thú vị giúp bé học rất nhanh và rất vui nhé.', 50.0000, 15, CAST(N'2019-12-31' AS Date), 5, 2, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (28, N'Vô Cùng Tàn Nhẫn, Vô Cùng Yêu Thương - Tập 1 ', N'Sara Imas', N'NXB Dân Trí', N'Vô Cùng Tàn Nhẫn Vô Cùng Yêu Thương là cuốn sách nuôi dạy con của một bà mẹ Do Thái sinh ra và lớn lên ở Trung Quốc, đã giáo dục con của mình trở thành triệu phú.

"Vô Cùng Tàn Nhẫn Vô Cùng Yêu Thương" là sự kết hợp phương pháp giáo dục con của Trung Quốc và Do Thái, dân tộc ẩn chứa nguồn sức mạnh tiềm ẩn khổng lồ. Sara Imas, tác giả cuốn sách, cho rằng: “Người nào nuông chiều con cái, ắt có ngày người đó phải băng bó vết thương cho con. Mềm mỏng là hại, tàn nhẫn là yêu!”. Bà mẹ Do Thái cũng ví von: “Cha mẹ Trung Quốc yêu thương con giống hình tử cung, còn các bậc cha mẹ Do Thái yêu thương con cái như hình đống lửa.”

"Vô Cùng Tàn Nhẫn Vô Cùng Yêu Thương" là tác phẩm giáo dục xuất sắc, đã làm mưa làm gió tại thị trường Trung Đông và Châu Á, đặc biệt là Trung Quốc. Cha mẹ Do Thái giáo dục con kỹ năng để sinh tồn, kiếm tiền và quản lý tài sản từ nhỏ. Điều này không nhằm biến trẻ thành cái máy kiếm tiền hay "thần giữ của". Ngược lại, cha mẹ Do Thái coi "giáo dục quản lý tài sản" cũng là một cách "giáo dục đạo đức" hay "giáo dục nhân cách".

Vô Cùng Tàn Nhẫn Vô Cùng Yêu Thương là phương pháp dạy con biết mưu sinh, biết theo đuổi mục tiêu của mình, biết hưởng thụ cảm giác hạnh phúc và thỏa mãn sau khi đạt được mục tiêu thì cha mẹ cũng như con cái mới có thể trở thành người hạnh phúc và thành công trong cuộc sống. "Vô Cùng Tàn Nhẫn Vô Cùng Yêu Thương" là bí kíp giúp cha mẹ dạy trẻ hiểu được luân lý lao động, biết đầu tư và quản lý tài sản, chứ không đơn thuần là truyền bá tri thức và rèn luyện kỹ năng sinh tồn. Và ý nghĩa sâu xa của nó còn giúp trẻ con trang bị những hiểu biết cần thiết và giá trị đúng đắn của cuộc đời.', 161.0000, 11, CAST(N'2017-11-04' AS Date), 4, 32, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (29, N'Tư Duy Cá Mập Suy nghĩ cá vàng', N'Hohn Gordon', N'Nxb Tổng hợp TP.HCM', N'Tập sách dành cho những người đang muốn vượt thoát thử thách của cuộc sống Tư duy cá mập suy nghĩ cá vàng là câu chuyện về chú cá vàng Gordy yếu đuối, nhút nhát và bác cá mập Sammy anh hùng, dũng cảm. Cá vàng Gorly có một cuộc sống tuyệt vời, thanh bình, được bao bọc, che chở, đầy đủ thức ăn trong chiếc hồ nhỏ bé, an toàn của mình. Còn cá Mập thì lo toan, đấu tranh bộn bề mọi thứ ngoài đại dương rộng lớn. Tưởng chừng như, hai nhân vật này sẽ khó có mối liên hệ. Vậy mà…

Một ngày kia, khi cá vàng vướng vào nghịch cảnh, phải bước vào thế giới mênh mông của đại dương, Gordy tất nhiên là chới với. Trong lúc nguy hiểm nhất của cuộc đời giữa sự sống và cái chết thì cá vàng gặp được cá mập Sammy. Mối liên hệ giữa hai nhân vật ấy hình thành, một cách rất kỳ lạ: Không ưa, chẳng ghét nhưng cũng chẳng mến, chẳng thương. Tuy nhiên, hai cá thể khác biệt khi bước vào không gian chung, lại phát sinh tương tác. Cá mập không cứu vớt, hay cho ăn đầy đủ mà bác ấy đã chỉ dạy cho cậu cá vàng những nguyên tắc sống, làm việc, suy nghĩ và ứng xử trong từng tình huống để cá vàng không vô định, lênh đênh, không điểm đích.

Cuộc biến chuyển trong nội tại của Gordy, từ đó mà hình thành… Khéo léo dùng hình ảnh của hai chú cá để làm ẩn dụ cho câu chuyện cuộc đời của mỗi người, tác giả Jon Gordon vẽ ra cho người đọc câu chuyện của con người, của cuộc đời. Nhiều người trong chúng ta giống như chú cá vàng Gordy. Đối mặt với những vấp ngã, đau thương hay thất bại, dễ dàng chán nản và ngừng cố gắng. là thế nào để bước qua giai đoạn này, dù có, hay không gặp được “cá mập” nào đấy?

Chuyện của cá mập, cá vàng giản đơn nhưng lối dẫn dắt, cách kể chuyện khéo kéo đã khiến người đọc tìm thấy con đường thoát ra những suy nghĩ, hành động tiêu cực. Như lời của Jon Gordon, thay vì coi chúng là kẻ thù, rồi chịu đựng, căm ghét và ra sức chống lại chúng, hãy cậu chọn cách ôm chầm lấy mọi sự thay đổi, biến chúng trở thành bạn của mình, học hỏi và kiểm soát chúng.

Sách do First News thực hiện, NXB Tổng Hợp ấn hành, phát hành tại nhà sách Trí Việt, 11H Nguyễn Thị Minh Khai, Phường Bến Nghé, Quận 1 và tất cả các hệ thống nhà sách trên cả nước. ', 36.0000, 14, CAST(N'2022-01-23' AS Date), 3, 5, 2)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (30, N'Nhắm Mắt Nhìn Sao', N'Hà Chương', N'Nxb Hội Nhà Văn', N'Đây là tự chuyện về cuộc đời của anh - người nhạc sĩ khiếm thị sáng tác và hát qua lăng kính của ánh sáng không màu. Trong tự truyện Nhắm Mắt Nhìn Sao, Hà Chương kể lại câu chuyện đời mình tường tận đến từng giọt nước mắt, từng giọt mồ hôi, chi tiết đến từng giấc chiêm bao, từng phút tủi lòng. Anh kể lại từng khoảnh khắc thăng hoa khi vượt qua chính mình, khi chinh phục được thử thách để bước lên thêm một nấc thang thành công nữa. Anh kể với hy vọng chuyện đời mình sẽ tiếp thêm động lực cho người khác.

Làm quen với cây đàn guitar từ năm 7 tuổi, khi mà ngón tay chưa đủ lớn và rộng để trải đủ các hợp âm, nhưng Chương vẫn ôm đàn và học bấm những nốt cơ bản. Cho đến năm 12 tuổi, khi vào học ở trường dành riêng cho người khiếm thị, trường PT chuyên biệt Nguyễn Đình Chiểu ở Đà Nẵng thì Hà Chương mới chính thức bước vào con đường học nhạc một cách hệ thống. Và đến năm 2004, Hà Chương trở thành sinh viên trường Học viện âm nhạc quốc gia Việt Nam, khoa nhạc cụ truyền thống.', 148.0000, 15, CAST(N'2022-02-01' AS Date), 1, 32, 2)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (31, N'Bí Quyết Làm Giàu Của Napoleon Hill', N' Napoleon Hill', N'Nxb Tổng hợp TP.HCM', N'Tiến sĩ Napoleon Hill là một chuyên gia hàng đầu trong lĩnh vực tư vấn, là tác giả của quyển Think and Grow Rich nổi tiếng (đã được phát hành với tựa đề Cách Nghĩ Để Thành Công). Cùng với đồng sự thân tín của mình là W. Clement Stone, ông đã trực tiếp hướng dẫn cho hàng chục ngàn người biết cách tự tạo động lực cho bản thân và cho người khác nhằm đạt được những giá trị đích thực của cuộc sống, cũng như sự thành công trong công việc và trạng thái giàu có bền vững.

Cuốn sách này sẽ không thể đem lại cho bạn hạnh phúc, sức khoẻ và sự giàu có. Nhưng nếu đó là điều bạn khao khát muốn có, thì cuốn sách này sẽ giúp bạn nảy sinh những ý tưởng mới và đi đúng hướng trên con đường chinh phục mục tiêu. Bạn sẽ tìm được những cơ hội mới mà trước đây bạn chưa thấy rõ. Và, điều quan trọng hơn cả là bạn sẽ được truyền thêm sức mạnh để tiếp bước bằng hành động.', 98.0000, 15, CAST(N'2021-11-04' AS Date), 2, 4, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (32, N'Lập Kế Hoạch Quản Lý Tài Chính Cá Nhân', N'Kristy Shen, Bryce Leung', N'NXB ĐH Kinh tế Quốc dân', N'Không cần phải thắng đậm trên thị trường chứng khoán, không cần phải là người đứng đầu một công ty khởi nghiệp, và cũng không cần đầu tư vào bất động sản; Kristy Shen và Bryce Leung - những người có xuất thân hoàn toàn bình thường - đã trở thành triệu phú khi mới bước sang độ tuổi 30 nhờ một công thức đơn giản mà bất cứ ai cũng có thể áp dụng.

Nỗi ám ảnh về tiền bạc, cụ thể là những nỗi lo về sinh hoạt phí, nợ nần, việc nuôi dạy con cái, các khoản tích cóp và đầu tư kiếm thêm thu nhập là mối bận tâm không của riêng ai. Khi phàn nàn về tình hình tài chính, mọi người luôn bào chữa: “Tôi đi vay tiền nhiều quá”, “Tôi đã chọn sai ngành học”, “Đã quá trễ để tôi bắt đầu thay đổi"... Thực chất, chúng ta đều là con người và có thể mắc sai lầm. Nhưng để thành công, ta không thể than vãn “giá như”, mà cần tìm ra giải pháp. Hãy nhớ rằng: “Vấn đề không nằm ở quá khứ, mà là bây giờ chúng ta cần làm gì?”', 189.0000, 15, CAST(N'2019-11-04' AS Date), 2, 23, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (33, N'Tiếng Nhật Chuyên Ngành Điều Dưỡng Dành Cho Người Mới Bắt Đầu - Từ Vựng Căn Bản - Bản Dịch 2 Thứ Tiếng English Tiếng Việt', N'Nhiều tác giả', N'Nxb Trẻ', N'Nằm trong bộ sách Tiếng Nhật chuyên ngành điều dưỡng.
Quyển "Từ vựng cơ bản" này là tổng hợp các từ vựng chuyên ngành điều dưỡng, kèm bản dịch Anh Việt và các câu ví dụ bám sát hiện trường làm việc thực tế. Giúp người học có cái nhìn tổng quát về ngành điều dưỡng. Có đính kèm tấm nhựa đỏ phục vụ việc tự học.
Đây là giáo trình rất bổ ích cho những người đang học ngành điều dưỡng, hoặc muốn làm việc trong ngành điều dưỡng tại Nhật Bản.', 200.0000, 22, CAST(N'2018-12-04' AS Date), 7, 43, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (34, N'Xiaomi - Hành Trình Một Công Ty Khởi Nghiệp Trở Thành Thương Hiệu Toàn Cầu', N'Jayadevan PK', N'NXB Dân Trí', N'Với Xiaomi - Hành trình một công ty khởi nghiệp trở thành thương hiệu toàn cầu, độc giả sẽ khám phá và tự giải mã được cách Xiaomi trở thành công ty đa quốc gia thành công như ngày nay, thông qua những tài liệu, thông số và thông tin chi tiết về kinh doanh của hãng.

Dù chứa đựng rất nhiều thông tin hữu ích, đầy tính khoa học như các nghiên cứu của những chuyên gia, học giả nổi tiếng trên các tạp chí kinh doanh được nhiều độc giả mong đợi, nhưng cuốn sách này lại rất dễ đọc, nó giống một câu chuyện hơn Jayadevan P.K. cứ như đang kể với độc giả một câu chuyện hấp dẫn, lôi cuốn về Xiaomi, tới mức độc giả chẳng biết chương này đã chảy trôi sang chương kia từ lúc nào nữa.', 115.0000, 11, CAST(N'2017-03-12' AS Date), 2, 123, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (35, N'Lê Minh Khuê - Tuyển Tập Truyện Ngắn & Vừa', N'Lê Minh Khuê', N'Nxb Trẻ', N'Tuyển tập những tác phẩm nổi bật của “bà trùm” truyện ngắn Lê Minh Khuê: Bi kịch nhỏ, Anh lính Tony D, Nhiệt đới gió mùa…

Độc giả sẽ gặp lại Lê Minh Khuê khi dữ dội, sắc cạnh quyết liệt, khi lại dịu dàng, trầm tĩnh, cảm thông trong tập truyện ngắn được chính tác giả tuyển soạn kĩ càng này.', 163.0000, 20, CAST(N'2019-08-09' AS Date), 1, 342, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (36, N'Hồ Chí Minh - Hồn Cách Mạng, Hồn Thơ', N'Đoàn Trọng Huy', N'NXB Văn hóa - Văn nghệ', N'Chủ tịch Hồ Chí Minh – vị lãnh tụ cách mạng vĩ đại, nhà văn hóa kiệt xuất, tấm gương đạo đức tuyệt vời của dân tộc Việt Nam, cũng là của nhân loại tiến bộ trong thời đại.

Người đồng thời là một nhà giáo dục, nhà văn, nhà báo lỗi  lạc, được vinh danh và giảng dạy như tác gia lớn trong nhà trường ở đất nước ta tại tất cả các bậc học và cấp học.

Tác giả khi thực hiện cuốn sách này thể hiện những hiểu biết, trải nghiệm với tất cả tâm huyết, lòng biết  ơn sâu sắc và chân thành nhất đối với Người trong quá trình giảng dạy và nghiên cứu từ hơn 60 năm nay.', 99.0000, 20, CAST(N'2019-06-19' AS Date), 1, 12, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (37, N'Starter Toeic Third Edition', N'Compass', N'NXB First New', N'First News đã xuất bản 2 bộ sách khá hay về học và luyện thi TOEFL/ TOEIC, được biên soạn công phu bởi đội ngũ các giáo viên và chuyên viên giáo dục - ngôn ngữ Hoa Kỳ.

Đây chính là hai bộ sách được tổng hợp biên soạn và cập nhật hoá dựa theo những yêu cầu mới của các kỳ thi TOEFL/ TOEIC, đồng thời cũng để đáp ứng nhu cầu học và luyện thi hiện đại.

Mỗi bộ sách được chia thành nhiều cấp độ, từ sơ cấp đến nâng cao, phù hợp với mọi trình độ học viên, thuận lợi cho giáo viên trong việc tổ chức học, ra đề thi và sắp lớp đúng trình độ để việc học tập và kiểm tra của học viên đạt kết quả mong muốn. Các học viên có thể tự kiểm tra và chọn cho mình cấp độ phù hợp với khả năng.', 156.0000, 15, CAST(N'2022-01-12' AS Date), 8, 12, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (38, N'Cái Bắt Tay Triệu Đô - The Million Dollar Handshake', N'Catherine Molloy', N'NXB Dân Trí', N'Bảy giây - bạn có thể đạt được những gì trong từng này thời gian? Thật ra chỉ trong bảy giây ngắn ngủi, bạn đã có thể ghi ấn tượng khó phai với người bạn gặp gỡ lần đầu tiên. Nếu bạn đến gặp ai đó với hy vọng được tuyển dụng, ký kết hợp đồng làm ăn, hoặc thậm chí là tìm bạn đời, ấn tượng ban đầu là hết sức quan trọng và bạn muốn để lại dấu ấn thật tốt đẹp.

Vậy ấn tượng ban đầu đến từ đâu? Tác giả Catherine Molly khẳng định: “Trước cả khi bạn mở lời, cách bạn đi đứng, bắt tay, giao tiếp bằng mắt và kết nối với đối phương đã nói lên rất nhiều điều về bạn”. Và vì thế, chuyên gia giao tiếp này đã chia sẻ những bài học đắt giá về ngôn ngữ cơ thể và phong cách hành vi trong cuốn sách “Cái bắt tay triệu đô” (tựa gốc “The Million Dollar Handshake”), nhằm giúp bạn tạo được ấn tượng tốt đẹp trong mắt người khác chỉ trong vòng bảy giây.', 128.0000, 15, CAST(N'2021-12-31' AS Date), 2, 43, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (39, N'Blockchain Và Đầu Tư ICOs Căn Bản - Con Đường Tới Tự Do Tài Chính', N'Lưu Thế Lợi , David Nguyễn', N'NXB Thanh Niên', N'Hiện nay, thuật ngữ Blockchain đã trở thành từ khóa tìm kiếm phổ biến tại Việt Nam. Tuy nhiên hầu hết các tài liệu là nước ngoài và gây khó khăn cho độc giả trong việc tiếp cận. Vì sự phát triển của Blockchain Việt Nam và với mục tiêu chia sẻ kiến thức với cộng đồng, trang bị kiến thức cho các nhà đầu tư trẻ trong thị trường tiền tệ số, Satoshi Hunters And Rocking Experts phối hợp với Nhà xuất bản Thanh Niên xuất bản cuốn sách mang tên “Blockchain và đầu tư ICOs căn bản”.', 250.0000, 10, CAST(N'2021-11-09' AS Date), 8, 12, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (40, N'Kỹ Năng Lập Kế Hoạch Hiệu Quả', N' Shibamoto Hidenori', N'Nxb Thế giới', N'Ai cũng cần một kế hoạch trong công việc. Cấp trên không ngừng thúc giục bạn viết báo cáo, lập kế hoạch cho tuần sau, tháng sau, năm sau - và kế hoạch nào cũng phải có ý tưởng mới lạ. Bạn cứ viết ra các kế hoạch mà bản thân mình không hề hứng thú, và cũng chẳng mấy khi bạn hoàn thiện được hết các mục tiêu. Vậy thì lập kế hoạch để làm gì? Chẳng ai dạy bạn cách phải lập kế hoạch sao cho hiệu quả, trong khi ai cũng yêu cầu bạn phải lập kế hoạch thật tốt!

Hầu hết chúng ta đều không biết cách lập kế hoạch, và khi bị cuốn vào công việc, ta cũng hiếm khi cố gắng cải thiện điểm thiếu sót này.Vì vậy, Shibamoto Hidenori đã viết "Kỹ năng lập kế hoạch hiệu quả" để trợ giúp độc giả - đặc biệt là những người trưởng thành đã đi làm.

Thông qua cuốn sách, người đọc không chỉ có tư duy sâu sắc hơn về việc lập kế hoạch, mà còn nắm rõ từng bước lập kế hoạch một cách rõ ràng và chính xác. Sách lồng ghép những khó khăn và sai lầm thường mắc phải của mọi người trong quá trình tiến hành các kế hoạch và sau khi tạo được thành quả, từ đó giúp mọi người thay đổi thái độ, hướng đến nâng cao hiệu suất làm việc.', 149.0000, 18, CAST(N'2022-11-04' AS Date), 3, 12, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (41, N'Tôi Đi Học - Nguyễn Ngọc Ký', N'Nguyễn Ngọc Ký', N'Nxb Tổng hợp TP.HCM', N'Tự truyện Tôi đi học được Nguyễn Ngọc Ký viết khi bắt đầu quãng đời sinh viên của mình vào tháng 9 năm 1966 tại khoa Ngữ Văn trường Đại học Tổng hợp Hà Nội ở khu sơ tán vùng núi Đại Từ - Thái Nguyên. Trong thời gian hai năm đầu trở thành sinh viên, giữa giảng đường sơ tán khó khăn thiếu thốn trăm bề, vừa tập trung học trong điều kiện mọi việc phải nhờ đến đôi chân, lại liên tục chống đỡ với ghẻ lở, bệnh tật triền miên dưới ánh đèn dầu hằng khuya, Nguyễn Ngọc Ký đã hoàn tất bản thảo vào hè 1968 sau nhiều lần viết đi viết lại, sửa đi sửa lại.', 68.0000, 16, CAST(N'2016-12-01' AS Date), 1, 4124, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (42, N'Những Bậc Thầy Đổi Mới - 76 Bài Học Truyền Cảm Hứng Từ Các Nhà Đổi Mới Vĩ Đại Nhất Mọi Thời Đại', N'Paul Sloane', N'NXB Dân Trí', N'“Một cuộc phiêu lưu mới mẻ, hấp dẫn, sâu sắc vào trái tim và tâm trí của những nhà lãnh đạo đầy cảm hứng, tin tưởng vào tiềm năng đổi mới vô hạn của con người và chứng minh rằng với sự thực hành đúng đắn và khích lệ, tất cả mọi người đều có khả năng đổi mới.” – Ajaz Ahmed, Giám đốc điều hành, AKQA

“Thúc đẩy tinh thần đổi mới, bạn thường cần cảm hứng từ người khác. Cuốn sách này mang lại điều quan trọng này cho tất cả chúng ta.” Kim Pedersen, Phó chủ tịch điều hành của GEODIS', 158.0000, 17, CAST(N'2019-11-14' AS Date), 2, 321, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (43, N'Donald Trump - Chiến Lược Đầu Tư Bất Động Sản', N'George H Ross, Andrew James Mclean', N'Nxb Lao động', N'Có thể khẳng định rằng kinh tế BĐS là một thành phần quan trọng, chiếm tỷ trọng đáng kể trong nền kinh tế của tất cả các nước phát triển. Đối với các nước đang phát triển, kinh tế BĐS có vai trò tạo nên tích lũy tài chính ban đầu của quá trình công nghiệp hóa đất nước. Điều này đã được chứng minh bằng thực tế ở các nước và vùng lãnh thổ như Singapore, Hàn Quốc, Đài Loan, Hong Kong.

Ở Việt Nam trong những năm gần đây, kinh tế BĐS đã thu hút ngày càng nhiều nguồn vốn trong xã hội và đóng góp nhiều cho tăng trưởng kinh tế. Tuy nhiên, kinh tế BĐS ở nước ta nhìn chung đã và đang phát triển một cách tự phát, phần lớn hoạt động ngoài sự kiểm soát của nhà nước, mang nhiều “tính chất” đầu cơ và là hoạt động không đúng hướng.', 169.0000, 15, CAST(N'2016-11-04' AS Date), 2, 32, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (44, N'Mùa Chinh Chiến Ấy', N'Đoàn Tuấn', N'Nxb Trẻ', N'Mùa chinh chiến ấy là những mảng hồi ức của nhà văn – chiến binh Đoàn Tuấn về anh và đồng đội trong cuộc chiến biên giới Tây Nam – một cuộc chiến tranh bắt buộc ngay sau ngày thống nhất nước nhà.

Chiến trường K giai đoạn cuối năm 1978 đến giữa những năm 1980 là nơi bộ đội Việt Nam phải đối mặt với một kẻ địch nguy hiểm, liều lĩnh và môi trường xa lạ, khắc nghiệt hơn cả hai cuộc kháng chiến trước đó. Trong bối cảnh âm thầm mà khốc liệt của gần 40 năm về trước ấy, truyện đưa người đọc theo dấu chân tuổi 18 của nhân vật “tôi” – người lính sư đoàn 307, đi tới tận những miền rừng núi heo hút xứ người. Đó là cuộc hành quân dài hàng ngàn cây số: từ Pleiku, theo đường 19 tiến về hướng Tây, để đẩy lùi và tiêu diệt tàn quân Khmer Đỏ ở vùng Đông - Bắc Campuchia.

Đoàn Tuấn viết trong sáng, tự nhiên, nhưng khi cần cũng không hề né tránh những mảng gai góc của hiện thực. Những trang văn đầy ắp chi tiết dựng lại cả một giai đoạn lịch sử vẫn còn nóng hổi để mỗi người Việt cần nhớ.', 155.0000, 20, CAST(N'2015-11-03' AS Date), 1, 43, 5)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (45, N'Thiết Kế Wed Với Dreamweaver CS4', N'FPT Polytechnic', N'NXB Tri thức', N'Thiết kế web với Dreamweaver CS4 trình bày các khả năng và cách thức khai thác tối đa sức mạnh của Dreamweaver CS4 để nhanh chóng xây dựng website. Cuốn sách này được thiết kế để có thể đọc toàn bộ các bài học, hoặc chỉ đọc một hay một số bài bất kỳ. Mỗi bài học bao gồm: phần hướng dẫn chi tiết, các bước thực hành cùng với các file, những thông tin hữu ích liên quan và các video hướng dẫn.', 160.0000, 15, CAST(N'2023-11-04' AS Date), 8, 12, 1)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (46, N'Cấu Trúc Dữ Liệu Và Thuật Toán (Phân Tích Và Cài Đặt Trên C/C++) ', N' Trần Thông Quế', N'Nxb Thông tin & truyền thông', N'Cấu trúc dữ liệu và Thuật toán (Data Structure and Algorithms) là môn học bắt buộc không những với mỗi sinh viên ngành Công nghệ Thông tin mà còn là môn học bắt buộc và môn thi quốc gia đầu vào bắt buộc với các nghiên cứu viên của ngành học đó. Nó là một trong các môn học khó của ngành CNTT, đặc biệt càng khó đối với hầu hết các sinh viên khi phải cài đặt một thuật toán hay một bài toán nào đó thuộc môn học này.

Bất cứ sự thành công nào của một dự án Tin học đều là kết quả của việc kết hợp khéo léo giữa Cấu trúc dữ liệu và Thuật toán. Khẳng định này được chứng tỏ trong một công thức rất ngắn gọn mang tính triết lý đương đại nghề nghiệp:

Big Data + Big Community = Big Result

Việc cài đặt các thuật toán cơ bản hoặc nổi tiếng hoặc khó được thực hiện trên các ngôn ngữ chuyên nghiệp đương đại là C/C++ nhằm giải đáp câu hỏi tồn tại trong đầu những người học là: Thực thi các thuật toán ấy trên máy tính điện tử như thế nào và sẽ cho kết quả ra sao?', 55.0000, 20, CAST(N'2018-11-04' AS Date), 8, 121, 4)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (48, N'Trương Trọng Hòa dz', N'Trọng Hòa', N'Hòa dz', N'Đây là một cuốn sách hấp dẫn ', 30.0000, 0, CAST(N'2023-03-05' AS Date), 10, 6, NULL)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (49, N'Test', N'sdsdasd', N'tw44trwtrwrt', N'asdadasdsad', 34.0000, 2, CAST(N'2023-03-05' AS Date), 10, 5, 3)
INSERT [dbo].[Book] ([BookId], [BookName], [Author], [Title], [Describe], [Price], [Discount], [ReleaseDate], [CategoryId], [Sold], [RatingPoint]) VALUES (50, N'Test 2.2', N'e3443', N'wewe', N'rwedsfsafsdafdsa', 7.0000, 0, CAST(N'2023-03-05' AS Date), 10, 4, NULL)
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[Cart] ON 

INSERT [dbo].[Cart] ([CartID], [AccountId], [TotalMoney]) VALUES (6, 18, 1426.1400)
INSERT [dbo].[Cart] ([CartID], [AccountId], [TotalMoney]) VALUES (13, 14, 23.1200)
SET IDENTITY_INSERT [dbo].[Cart] OFF
GO
INSERT [dbo].[CartDetail] ([CartId], [BookId], [Quantity]) VALUES (6, 3, 3)
INSERT [dbo].[CartDetail] ([CartId], [BookId], [Quantity]) VALUES (6, 5, 6)
INSERT [dbo].[CartDetail] ([CartId], [BookId], [Quantity]) VALUES (6, 8, 7)
INSERT [dbo].[CartDetail] ([CartId], [BookId], [Quantity]) VALUES (13, 7, 1)
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (1, N'Sách Văn Học', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (2, N'Sách Kinh Tế', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (3, N'Sách Tâm Lí - Kĩ  Năng Sống', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (4, N'Sách Nuôi Dạy Con', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (5, N'Sách Thiếu Nhi', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (6, N'Sách Ngoại Ngữ', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (7, N'Sách Công Nghệ', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (8, N'Trong hoa 122212121', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (9, N'Sách a', NULL)
INSERT [dbo].[Category] ([CategoryId], [CategoryName], [Image]) VALUES (10, N'Sách của Hòa', NULL)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (1, 6, CAST(N'2023-04-06' AS Date), N'', NULL, N'Đang giao hàng', 2280.5500)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (2, 6, CAST(N'2023-03-06' AS Date), N'', NULL, N'Chờ xác nhận', 2280.5500)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (3, 14, CAST(N'2023-12-06' AS Date), N'', NULL, N'Giao hàng thành công', 374.6000)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (4, 14, CAST(N'2023-03-06' AS Date), N'', NULL, N'Đang giao hàng', 374.6000)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (5, 3, CAST(N'2022-12-01' AS Date), N'', NULL, N'Giao hàng thành công', 213.0000)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (7, 4, CAST(N'2021-03-03' AS Date), N'', NULL, N'Giao hàng thành công', 3345.0000)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (8, 4, CAST(N'2021-06-12' AS Date), N'', NULL, N'Giao hàng thành công', 234.0000)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (9, 5, CAST(N'2022-04-01' AS Date), N'', NULL, N'Giao hàng thành công', 123.0000)
INSERT [dbo].[Order] ([OrderId], [AccountId], [OrderDate], [Note], [ShippingAddress], [Status], [TotalMoney]) VALUES (10, 6, CAST(N'2022-08-23' AS Date), N'', NULL, N'Giao hàng thành công', 1234.0000)
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (1, 3, 12)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (1, 4, 10)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (2, 4, 10)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (2, 8, 3)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (2, 14, 2)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (3, 48, 6)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (3, 49, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (3, 50, 4)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (4, 48, 6)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (4, 49, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (4, 50, 4)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (5, 2, 3)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (5, 5, 12)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (5, 6, 2)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (7, 4, 11)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (7, 22, 4)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (7, 23, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (8, 1, 6)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (8, 23, 5)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (8, 34, 22)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (9, 7, 4)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (9, 9, 8)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (10, 32, 3)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (10, 43, 2)
INSERT [dbo].[OrderDetail] ([OrderId], [BookId], [Quantity]) VALUES (10, 46, 1)
GO
INSERT [dbo].[Review] ([BookId], [AccountId], [Comment], [Rating]) VALUES (49, 14, N'Ahihihihih 123', 3)
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (1, N'Admin')
INSERT [dbo].[Role] ([RoleId], [RoleName]) VALUES (2, N'Customer')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Account]    Script Date: 3/20/2023 3:25:45 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Account] ON [dbo].[Account]
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Category]    Script Date: 3/20/2023 3:25:45 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Category] ON [dbo].[Category]
(
	[CategoryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK__Account__RoleId__4BAC3F29] FOREIGN KEY([RoleId])
REFERENCES [dbo].[Role] ([RoleId])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK__Account__RoleId__4BAC3F29]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK__Book__CategoryId__5070F446] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([CategoryId])
ON UPDATE CASCADE
ON DELETE SET NULL
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK__Book__CategoryId__5070F446]
GO
ALTER TABLE [dbo].[Cart]  WITH CHECK ADD FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[CartDetail]  WITH CHECK ADD  CONSTRAINT [FK__CartDetai__BookI__793DFFAF] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
GO
ALTER TABLE [dbo].[CartDetail] CHECK CONSTRAINT [FK__CartDetai__BookI__793DFFAF]
GO
ALTER TABLE [dbo].[CartDetail]  WITH CHECK ADD  CONSTRAINT [FK__CartDetai__CartI__7849DB76] FOREIGN KEY([CartId])
REFERENCES [dbo].[Cart] ([CartID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CartDetail] CHECK CONSTRAINT [FK__CartDetai__CartI__7849DB76]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Account] FOREIGN KEY([AccountId])
REFERENCES [dbo].[Account] ([AccountId])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Account]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__BookI__5629CD9C] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__BookI__5629CD9C]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK__OrderDeta__Order__5535A963] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([OrderId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK__OrderDeta__Order__5535A963]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK__Review__BookId__59063A47] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([BookId])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK__Review__BookId__59063A47]
GO
USE [master]
GO
ALTER DATABASE [Project_Book] SET  READ_WRITE 
GO
