USE [master]
GO
/****** Object:  Database [IS2G10_DBSSS]    Script Date: 2015/10/19 01:32:12 AM ******/
CREATE DATABASE [IS2G10_DBSSS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IS2G10_DBSSS', FILENAME = N'C:\Users\SoftDev\IS2G10_DBSSS.mdf' , SIZE = 3136KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IS2G10_DBSSS_log', FILENAME = N'C:\Users\SoftDev\IS2G10_DBSSS_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IS2G10_DBSSS] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IS2G10_DBSSS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IS2G10_DBSSS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET ARITHABORT OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [IS2G10_DBSSS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IS2G10_DBSSS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IS2G10_DBSSS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [IS2G10_DBSSS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IS2G10_DBSSS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IS2G10_DBSSS] SET  MULTI_USER 
GO
ALTER DATABASE [IS2G10_DBSSS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IS2G10_DBSSS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IS2G10_DBSSS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IS2G10_DBSSS] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [IS2G10_DBSSS]
GO
/****** Object:  Table [dbo].[ATTENDANCE]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ATTENDANCE](
	[student_id] [int] NOT NULL,
	[student_activity_id] [int] NOT NULL,
	[student_activity_tutorrating] [int] NULL,
	[student_activity_rating] [int] NULL,
	[student_arrived] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC,
	[student_activity_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BRANDING]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[BRANDING](
	[branding_id] [int] IDENTITY(1,1) NOT NULL,
	[program_icon] [varbinary](max) NULL,
	[system_logo] [varbinary](max) NULL,
	[system_name] [nvarchar](255) NULL,
	[splash_colour] [nvarchar](255) NULL,
	[splash_time] [time](7) NULL,
	[is_system_clean] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[branding_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CONSULTATION]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CONSULTATION](
	[consultation_id] [int] IDENTITY(1,1) NOT NULL,
	[coordinator_id] [int] NOT NULL,
	[tutor_id] [int] NOT NULL,
	[student_id] [int] NULL,
	[consultation_details] [nvarchar](255) NULL,
	[consultation_date] [datetime] NULL,
	[student_arrived] [bit] NULL,
	[consultation_rating] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[consultation_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[COURSE]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[COURSE](
	[course_id] [int] IDENTITY(1,1) NOT NULL,
	[course_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ENROLLMENT]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ENROLLMENT](
	[course_id] [int] NOT NULL,
	[student_id] [int] NOT NULL,
	[class_mark] [float] NULL,
	[exam_mark] [float] NULL,
	[year_mark] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[course_id] ASC,
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GROUP]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GROUP](
	[group_id] [int] IDENTITY(1,1) NOT NULL,
	[group_name] [nvarchar](255) NULL,
	[group_day] [nvarchar](10) NULL,
	[group_time] [time](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SESSION]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SESSION](
	[tutor_id] [int] NOT NULL,
	[group_id] [int] NOT NULL,
	[updated_attendance] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[tutor_id] ASC,
	[group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[SSS_COORDINATOR]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SSS_COORDINATOR](
	[coordinator_id] [int] NOT NULL,
	[coordinator_firstname] [nvarchar](255) NULL,
	[coordinator_lastname] [nvarchar](255) NULL,
	[coordinator_id_passport] [nvarchar](255) NULL,
	[coordinator_dateofbirth] [datetime] NULL,
	[coordinator_emailaddress] [nvarchar](255) NULL,
	[coordinator_cellnumber] [nvarchar](14) NULL,
PRIMARY KEY CLUSTERED 
(
	[coordinator_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[STUDENT]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDENT](
	[student_id] [int] NOT NULL,
	[coordinator_id] [int] NOT NULL,
	[group_id] [int] NULL,
	[student_firstname] [nvarchar](255) NULL,
	[student_lastname] [nvarchar](255) NULL,
	[student_id_passport] [nvarchar](255) NULL,
	[student_dateofbirth] [datetime] NULL,
	[student_emailaddress] [nvarchar](255) NULL,
	[student_mobilenumber] [nvarchar](14) NULL,
	[student_yearofstudy] [int] NULL,
	[student_degreeprogramme] [nvarchar](255) NULL,
	[student_status] [nvarchar](255) NULL,
	[student_points] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[STUDENT_ACTIVITY]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STUDENT_ACTIVITY](
	[student_activity_id] [int] IDENTITY(1,1) NOT NULL,
	[student_activity_name] [nvarchar](255) NULL,
	[student_activity_pointvalue] [int] NULL,
	[student_activity_week] [int] NULL,
	[student_activity_description] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[student_activity_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TUTOR]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUTOR](
	[tutor_id] [int] NOT NULL,
	[tutor_firstname] [nvarchar](255) NULL,
	[tutor_lastname] [nvarchar](255) NULL,
	[tutor_id_passport] [nvarchar](255) NULL,
	[tutor_dateofbirth] [datetime] NULL,
	[tutor_emailaddress] [nvarchar](255) NULL,
	[tutor_cellnumber] [nvarchar](14) NULL,
	[tutor_trainingstatus] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[tutor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TUTOR_AVAILABLE_TIMES]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TUTOR_AVAILABLE_TIMES](
	[tutor_time_id] [int] IDENTITY(1,1) NOT NULL,
	[tutor_id] [int] NOT NULL,
	[available_day] [nvarchar](255) NULL,
	[available_time] [time](7) NULL,
	[date_free] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[tutor_time_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USER_ROLE]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USER_ROLE](
	[user_roles_id] [int] IDENTITY(1,1) NOT NULL,
	[user_role] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[user_roles_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USERPROFILE]    Script Date: 2015/10/19 01:32:12 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USERPROFILE](
	[user_id] [int] NOT NULL,
	[user_name] [nvarchar](255) NULL,
	[user_roles_id] [int] NOT NULL,
	[password_hash] [nvarchar](255) NULL,
	[password_salt] [nvarchar](255) NULL,
	[PrimaryAccent] [nvarchar](255) NULL,
	[SecondaryAccent] [nvarchar](255) NULL,
	[isDark] [bit] NOT NULL,
	[resetPassword] [bit] NOT NULL,
	[useOldForms] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 1, 5, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 2, 4, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 3, 4, 5, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 4, 4, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 5, 3, 2, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 6, 5, 5, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 7, 3, 2, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 8, 5, 1, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 9, 4, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 10, 4, 5, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 1, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 2, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 3, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 4, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 5, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 6, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 7, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 8, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 9, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 10, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 1, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 2, 1, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 3, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 4, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 5, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 6, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 7, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 8, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 9, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 10, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 1, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 2, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 3, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 4, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 5, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 6, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 7, 1, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 8, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 9, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 10, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 1, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 2, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 3, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 4, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 5, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 6, 2, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 7, 1, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 8, 1, 4, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 9, 2, 3, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10013, 10, 1, 4, 1)
GO
SET IDENTITY_INSERT [dbo].[CONSULTATION] ON 

GO
INSERT [dbo].[CONSULTATION] ([consultation_id], [coordinator_id], [tutor_id], [student_id], [consultation_details], [consultation_date], [student_arrived], [consultation_rating]) VALUES (4, 76582, 20001, 10003, N'Having trouble with login into the system', CAST(N'2015-08-20 00:00:00.000' AS DateTime), 1, 4)
GO
INSERT [dbo].[CONSULTATION] ([consultation_id], [coordinator_id], [tutor_id], [student_id], [consultation_details], [consultation_date], [student_arrived], [consultation_rating]) VALUES (5, 76582, 20001, 10024, N'Having problems with information systems diagrams.', CAST(N'2015-08-22 00:00:00.000' AS DateTime), 0, NULL)
GO
INSERT [dbo].[CONSULTATION] ([consultation_id], [coordinator_id], [tutor_id], [student_id], [consultation_details], [consultation_date], [student_arrived], [consultation_rating]) VALUES (7, 76582, 20005, 10024, N'sdgdsg', CAST(N'2015-08-01 00:00:00.000' AS DateTime), 1, 5)
GO
SET IDENTITY_INSERT [dbo].[CONSULTATION] OFF
GO
SET IDENTITY_INSERT [dbo].[COURSE] ON 

GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (1, N'Information Systems')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (2, N'Computer Science')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (3, N'Law')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (4, N'Electrical Engineering')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (5, N'Macro Economics')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (6, N'Micro Economics')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (7, N'Mathematics')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (8, N'Statistics')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (9, N'Computational and Applied Mathematics')
GO
INSERT [dbo].[COURSE] ([course_id], [course_name]) VALUES (10, N'Geography')
GO
SET IDENTITY_INSERT [dbo].[COURSE] OFF
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10003, 50, 50, 50)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10004, 45, 55, 65)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10005, 32, 44, 67)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10007, 80, 80, 80)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10008, 98, 65, 78)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10009, 66, 66, 66)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10010, 34, 35, 34.5)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10013, 33.33, 33.33, 33.33)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10014, 66, 67, 66.5)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10022, 76, 77, 76.5)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10023, 87, 82, 84)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10024, 83, 82, 83.4)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10026, 72, 72, 72)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10027, 74.5, 74.5, 74.5)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10028, 73.3, 73.3, 73.3)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10029, 67.8, 67.8, 67.8)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10032, 64.7, 64.7, 64.7)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10033, 68, 68, 68)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10034, 72, 76, 75)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (1, 10035, 77, 78, 77)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (2, 10003, 87, 72, 78)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (2, 10004, 56, 56, 56)
GO
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (2, 10032, 82, 82, 82)
GO
SET IDENTITY_INSERT [dbo].[GROUP] ON 

GO
INSERT [dbo].[GROUP] ([group_id], [group_name], [group_day], [group_time]) VALUES (1, N'Group 1', N'Monday', CAST(N'14:00:00' AS Time))
GO
INSERT [dbo].[GROUP] ([group_id], [group_name], [group_day], [group_time]) VALUES (2, N'Group 2', N'Tuesday', CAST(N'08:00:00' AS Time))
GO
INSERT [dbo].[GROUP] ([group_id], [group_name], [group_day], [group_time]) VALUES (3, N'Group 3', N'Wednesday', CAST(N'08:00:00' AS Time))
GO
INSERT [dbo].[GROUP] ([group_id], [group_name], [group_day], [group_time]) VALUES (4, N'Group 4', N'Thursday', CAST(N'14:00:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[GROUP] OFF
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20001, 1, 1)
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20001, 2, 0)
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20010, 3, 0)
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20010, 4, 1)
GO
INSERT [dbo].[SSS_COORDINATOR] ([coordinator_id], [coordinator_firstname], [coordinator_lastname], [coordinator_id_passport], [coordinator_dateofbirth], [coordinator_emailaddress], [coordinator_cellnumber]) VALUES (69857, N'Sam', N'Gap', N'3253654678766', CAST(N'1958-01-02 00:00:00.000' AS DateTime), N'Sam.Gap@sss.com', N'(071)667 6778')
GO
INSERT [dbo].[SSS_COORDINATOR] ([coordinator_id], [coordinator_firstname], [coordinator_lastname], [coordinator_id_passport], [coordinator_dateofbirth], [coordinator_emailaddress], [coordinator_cellnumber]) VALUES (76582, N'Charles', N'Peters', N'8990060656183', CAST(N'1989-06-13 00:00:00.000' AS DateTime), N'Charles.Peters@sss.com', N'(071)567 2854')
GO
INSERT [dbo].[SSS_COORDINATOR] ([coordinator_id], [coordinator_firstname], [coordinator_lastname], [coordinator_id_passport], [coordinator_dateofbirth], [coordinator_emailaddress], [coordinator_cellnumber]) VALUES (76589, N'Zuko', N'Singhdee', N'2103313207185', CAST(N'1968-05-05 00:00:00.000' AS DateTime), N'Zuko.Singhdee@sss.com', N'(073)555 5555')
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10003, 76582, NULL, N'Jill', N'Hill', N'9415362161183', CAST(N'1994-07-12 00:00:00.000' AS DateTime), N'Jill.Hill@sss.com', N'(084)228 2135', 1, N'SB000', N'BLUE', 60)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10004, 76582, 1, N'Nathan', N'De Beer', N'0005050797181', CAST(N'1995-06-06 00:00:00.000' AS DateTime), N'Nathan.De.Beer@sss.com', N'(072)569 4585', 1, N'SB000', N'BRONZE', 130)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10005, 76582, 1, N'Anne', N'Hunt', N'3212233008182', CAST(N'1996-09-09 00:00:00.000' AS DateTime), N'Anne.Hunt@sss.com', N'(081)235 2213', 1, N'ACSCI', N'BLUE', 50)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10007, 76582, 1, N'Nadine', N'Steps', N'3212211318181', CAST(N'1995-08-16 00:00:00.000' AS DateTime), N'Nadine.Steps@sss.com', N'(084)228 2135', 1, N'ACSCI', N'BLUE', 70)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10008, 76582, 2, N'Dan', N'Patterson', N'9890060656183', CAST(N'1994-03-02 00:00:00.000' AS DateTime), N'Dan.Patterson@sss.com', N'(071)789 2567', 2, N'ACSCI', N'SILVER', 150)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10009, 76582, 2, N'Harry', N'Key', N'0105060144182', CAST(N'1995-08-08 00:00:00.000' AS DateTime), N'Harry.Key@sss.com', N'(071)549 5634', 2, N'ACSCI', N'BRONZE', 100)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10010, 76582, 2, N'Hermione', N'Jilly', N'1302024907189', CAST(N'1995-06-07 00:00:00.000' AS DateTime), N'Hermione.Jilly@sss.com', N'(083)556 1566', 2, N'ACSCI', N'BRONZE', 120)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10013, 76582, 3, N'Savannah', N'Price', N'4604060443186', CAST(N'1995-10-21 00:00:00.000' AS DateTime), N'Savannah.Price@sss.com', N'(065)456 2870', 3, N'ACSCI', N'SILVER', 150)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10014, 76582, 3, N'Prakesh', N'Naidoo', N'0005050797181', CAST(N'1995-07-14 00:00:00.000' AS DateTime), N'Prakesh.Naidoo@sss.com', N'(071)213 1465', 1, N'ACSCI', N'SILVER', 160)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10022, 76582, 3, N'Dane', N'Smith', N'5408311677181', CAST(N'1996-09-30 00:00:00.000' AS DateTime), N'Dane.Smith@sss.com', N'(073)851 1354', 1, N'ACSCI', N'GOLD', 180)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10023, 76582, 4, N'Shane', N'Potter', N'1203214646183', CAST(N'1995-03-02 00:00:00.000' AS DateTime), N'Shane.Potter@sss.com', N'(073)148 1234', 1, N'ACSCI', N'BRONZE', 100)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10024, 76582, 4, N'Amir', N'Cohen', N'4604060443186', CAST(N'1995-04-04 00:00:00.000' AS DateTime), N'Amir.Cohen@sss.com', N'(084)254 2548', 1, N'ACSCI', N'SILVER', 150)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10026, 76582, 4, N'Abe', N'Jameson', N'5555510501187', CAST(N'1995-01-01 00:00:00.000' AS DateTime), N'Abe.Jameson@sss.com', N'(084)228 2135', 1, N'ACSCI', N'BRONZE', 100)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10027, 76582, 4, N'Gera', N'Feld', N'2103313207185', CAST(N'1995-01-10 00:00:00.000' AS DateTime), N'Gera.Feld@sss.com', N'(071)774 3259', 1, N'ACSCI', N'SILVER', 160)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10028, 76582, 3, N'Uriel', N'Ruiz', N'2103212427181', CAST(N'1995-04-06 00:00:00.000' AS DateTime), N'Uriel.Ruiz@sss.com', N'(084)228 2135', 1, N'ACSCI', N'SILVER', 150)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10029, 76582, 2, N'Leon', N'Holmes', N'2203033540186', CAST(N'1997-09-09 00:00:00.000' AS DateTime), N'Leon.Holmes@sss.com', N'(084)285 5465', 1, N'ACSCI', N'SILVER', 150)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10032, 76582, 1, N'Andreas', N'Watson', N'9890060656183', CAST(N'1995-08-06 00:00:00.000' AS DateTime), N'Andreas.Watson@sss.com', N'(083)556 1566', 1, N'SB000', N'SILVER', 160)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10033, 76582, NULL, N'Yair', N'Levin', N'3303033626180', CAST(N'1995-11-11 00:00:00.000' AS DateTime), N'Yair.Levin@sss.com', N'(071)789 2567', 1, N'ACSCI', N'WHITE', 15)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10034, 76582, NULL, N'Nevil', N'Anderson', N'2103212427181', CAST(N'1995-09-17 00:00:00.000' AS DateTime), N'Nevil.Anderson@sss.com', N'(084)333 4568', 2, N'ACSCI', N'WHITE', 10)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10035, 76582, NULL, N'Jonny', N'Cave', N'9405366364086', CAST(N'1995-11-18 00:00:00.000' AS DateTime), N'Jonny.Cave@sss.com', N'(071)774 3259', 2, N'ACSCI', N'WHITE', 20)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10036, 76582, 1, N'Blair', N'Kettle', N'5987442615111', CAST(N'1995-03-01 00:00:00.000' AS DateTime), N'Blair.Kettle@sss.com', N'(083)226 6333', 2, N'ACSCI', N'WHITE', 30)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10037, 76582, 2, N'Daniel', N'Johnson', N'9401202200355', CAST(N'1994-03-01 16:21:58.000' AS DateTime), N'danieljohnson@sss.com', N'(085)545 4243', 2, N'BSc', N'WHITE', 25)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10038, 76582, 4, N'Pete ', N'Jackson', N'9302144455672', CAST(N'1993-01-09 00:00:00.000' AS DateTime), N'petejackson@sss.com', N'(086)548 4545', 1, N'Bcom', N'WHITE', 5)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10039, 76582, 3, N'Daisy', N'Blue', N'9213421134325', CAST(N'1992-04-03 00:00:00.000' AS DateTime), N'DaisyBlue@sss.com', N'(076)548 9222', 1, N'Bcom', N'WHITE', 30)
GO
SET IDENTITY_INSERT [dbo].[STUDENT_ACTIVITY] ON 

GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (1, N'Reading-Level Test', 10, 1, N'This evaluates students reading competencies.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (2, N'Time Management Workshop', 10, 2, N'This teaches students time management techniques.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (3, N'Study Skills Workshop', 10, 3, N'This teaches different methods of studying.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (4, N'Note Taking Strategies Workshop', 10, 4, N'This teaches students different ways to take notes.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (5, N'Test Taking Strategies Workshop', 10, 5, N'This teaches students different ways to take and cope with tests and exams.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (6, N'Block 1 Reflection Quiz', 10, 7, N'This tests students on all the activites in block 1.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (7, N'Reflection and Motivation Workshop ', 10, 8, N'Teaches students how to reflect on ones goals and how to remain motivated.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (8, N'Learning from Mistakes Workshop', 10, 9, N'This teaches students that everyone makes misakes.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (9, N'Examination Study Planning Workshop', 10, 12, N'This teaches students about how to plan for examinations.')
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (10, N'Block 2 Reflection Quiz ', 10, 13, N'This is a quiz testing general knowledge learnt in block 2.')
GO
SET IDENTITY_INSERT [dbo].[STUDENT_ACTIVITY] OFF
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20001, N'Susan', N'Kotzen', N'9415362161183', CAST(N'1993-07-12 00:00:00.000' AS DateTime), N'Susan.Kotzen@sss.com', N'(071)549 5634', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20002, N'Nathan', N'De Beer', N'9405366364086', CAST(N'1995-08-08 00:00:00.000' AS DateTime), N'Nathan.De Beer@sss.com', N'(084)333 4568', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20003, N'Anne', N'Junt', N'1905052659181', CAST(N'1991-01-05 00:00:00.000' AS DateTime), N'Anne.Junt@sss.com', N'(065)456 2870', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20004, N'Nadine', N'Steps', N'0105060144182', CAST(N'1988-05-06 00:00:00.000' AS DateTime), N'Nadine.Steps@sss.com', N'(073)851 1354', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20005, N'Dan', N'Patterson', N'0005050797181', CAST(N'1987-06-06 00:00:00.000' AS DateTime), N'Dan.Patterson@sss.com', N'(084)685 2969', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20006, N'Harry', N'Key', N'1302024907189', CAST(N'1994-07-12 00:00:00.000' AS DateTime), N'Harry.Key@sss.com', N'(072)932 4235', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20007, N'Hermione', N'Jilly', N'2103030745186', CAST(N'1969-12-30 00:00:00.000' AS DateTime), N'Hermione.Jilly@sss.com', N'(083)445 1245', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20008, N'Savannah', N'Price', N'3212233008182', CAST(N'1992-03-05 00:00:00.000' AS DateTime), N'Savannah.Price@sss.com', N'(071)774 3259', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20009, N'Prakesh', N'Naidoo', N'2103212427181', CAST(N'1993-08-25 00:00:00.000' AS DateTime), N'Prakesh.Naidoo@sss.com', N'(083)556 1566', 1)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20010, N'Darryn', N'Spouse', N'2103313207185', CAST(N'1992-02-29 00:00:00.000' AS DateTime), N'Darryn.Spouse@sss.com', N'(084)228 2135', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20011, N'Catherine', N'Jennings', N'3212211318181', CAST(N'1995-03-08 00:00:00.000' AS DateTime), N'Catherine.Jennings@sss.com', N'(083)267 1546', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20012, N'James', N'Door', N'4604060443186', CAST(N'1994-01-10 00:00:00.000' AS DateTime), N'James.Door@sss.com', N'(071)213 1465', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20013, N'Keith', N'Gate', N'9890060656183', CAST(N'1994-06-03 00:00:00.000' AS DateTime), N'Keith.Gate@sss.com', N'(072)569 4585', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20014, N'Tom', N'Van De Merwe', N'9868230899180', CAST(N'1994-08-08 00:00:00.000' AS DateTime), N'Tom.Van De Merwe@sss.com', N'(084)285 5465', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20015, N'Jack', N'Black', N'1203214646183', CAST(N'1994-09-04 00:00:00.000' AS DateTime), N'Jack.Black@sss.com', N'(073)148 1234', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20016, N'Tato', N'Muda', N'2203033540186', CAST(N'1994-03-07 00:00:00.000' AS DateTime), N'Tato.Muda@sss.com', N'(081)235 2213', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20017, N'Sarah', N'Jackson', N'5555510501187', CAST(N'1992-06-22 00:00:00.000' AS DateTime), N'Sarah.Jackson@sss.com', N'(072)241 2356', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20018, N'Jones', N'Johnson', N'3303033626180', CAST(N'1993-01-14 00:00:00.000' AS DateTime), N'Jones.Johnson@sss.com', N'(083)856 2354', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20019, N'Susan', N'Stuart', N'5408311677181', CAST(N'1994-07-12 00:00:00.000' AS DateTime), N'Susan.Stuart@sss.com', N'(084)254 2548', 0)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20020, N'Zoe', N'Caplin', N'3203133010188', CAST(N'1992-01-01 00:00:00.000' AS DateTime), N'Zoe.Caplin@sss.com ', N'(071)789 2567', 0)
GO
SET IDENTITY_INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ON 

GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (1, 20001, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-21 02:57:39.693' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (2, 20001, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-28 02:57:39.693' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (3, 20001, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-04 02:57:39.693' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (4, 20001, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-11 02:57:39.693' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (5, 20001, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-18 02:57:39.693' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (6, 20002, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-19 02:57:39.710' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (7, 20002, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-26 02:57:39.710' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (8, 20002, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-02 02:57:39.710' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (9, 20002, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-09 02:57:39.710' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (10, 20002, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-16 02:57:39.710' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (11, 20002, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-23 02:57:39.710' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (12, 20003, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-20 02:57:39.740' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (13, 20003, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-27 02:57:39.740' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (14, 20003, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-03 02:57:39.740' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (15, 20003, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-10 02:57:39.740' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (16, 20003, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-17 02:57:39.740' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (17, 20003, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-24 02:57:39.740' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (18, 20004, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-19 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (19, 20004, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-26 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (20, 20004, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-02 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (21, 20004, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-09 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (22, 20004, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-16 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (23, 20004, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-23 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (24, 20005, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-19 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (25, 20005, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-26 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (26, 20005, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-02 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (27, 20005, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-09 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (28, 20005, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-16 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (29, 20005, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-23 02:57:39.757' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (30, 20006, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-20 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (31, 20006, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-27 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (32, 20006, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-03 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (33, 20006, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-10 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (34, 20006, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-17 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (35, 20006, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-24 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (36, 20007, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-20 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (37, 20007, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-27 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (38, 20007, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-03 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (39, 20007, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-10 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (40, 20007, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-17 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (41, 20007, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-24 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (42, 20008, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-20 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (43, 20008, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-27 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (44, 20008, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-03 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (45, 20008, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-10 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (46, 20008, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-17 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (47, 20008, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-24 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (48, 20009, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-20 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (49, 20009, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-27 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (50, 20009, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-03 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (51, 20009, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-10 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (52, 20009, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-17 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (53, 20009, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-24 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (54, 20010, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-20 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (55, 20010, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-27 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (56, 20010, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-03 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (57, 20010, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-10 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (58, 20010, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-17 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (59, 20010, N'Tuesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-24 02:57:39.773' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (60, 20011, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-22 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (61, 20011, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-29 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (62, 20011, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-05 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (63, 20011, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-12 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (64, 20011, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-19 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (65, 20012, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-22 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (66, 20012, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-29 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (67, 20012, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-05 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (68, 20012, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-12 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (69, 20012, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-19 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (70, 20013, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-22 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (71, 20013, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-29 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (72, 20013, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-05 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (73, 20013, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-12 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (74, 20013, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-19 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (75, 20014, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-22 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (76, 20014, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-29 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (77, 20014, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-05 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (78, 20014, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-12 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (79, 20014, N'Thursday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-19 02:57:39.787' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (80, 20015, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-21 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (81, 20015, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-28 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (82, 20015, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-04 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (83, 20015, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-11 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (84, 20015, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-18 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (85, 20016, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-21 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (86, 20016, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-28 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (87, 20016, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-04 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (88, 20016, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-11 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (89, 20016, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-18 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (90, 20017, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-21 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (91, 20017, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-28 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (92, 20017, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-04 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (93, 20017, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-11 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (94, 20017, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-18 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (95, 20018, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-21 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (96, 20018, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-28 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (97, 20018, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-04 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (98, 20018, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-11 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (99, 20018, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-18 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (100, 20019, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-21 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (101, 20019, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-28 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (102, 20019, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-04 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (103, 20019, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-11 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (104, 20019, N'Wednesday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-18 02:57:39.803' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (105, 20020, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-19 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (106, 20020, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-10-26 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (107, 20020, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-02 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (108, 20020, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-09 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (109, 20020, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-16 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (110, 20020, N'Monday', CAST(N'14:00:00' AS Time), CAST(N'2015-11-23 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (111, 20001, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (112, 20001, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (113, 20001, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (114, 20001, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (115, 20001, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (116, 20001, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (117, 20002, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (118, 20002, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (119, 20002, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (120, 20002, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (121, 20002, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (122, 20002, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (123, 20003, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (124, 20003, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (125, 20003, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (126, 20003, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (127, 20003, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (128, 20003, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.820' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (129, 20004, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-20 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (130, 20004, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-27 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (131, 20004, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-03 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (132, 20004, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-10 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (133, 20004, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-17 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (134, 20004, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-24 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (135, 20005, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-20 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (136, 20005, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-27 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (137, 20005, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-03 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (138, 20005, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-10 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (139, 20005, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-17 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (140, 20005, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-24 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (141, 20006, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-20 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (142, 20006, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-27 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (143, 20006, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-03 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (144, 20006, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-10 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (145, 20006, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-17 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (146, 20006, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-24 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (147, 20007, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-20 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (148, 20007, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-27 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (149, 20007, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-03 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (150, 20007, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-10 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (151, 20007, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-17 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (152, 20007, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-24 02:57:39.833' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (153, 20008, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (154, 20008, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (155, 20008, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (156, 20008, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (157, 20008, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (158, 20008, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (159, 20009, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (160, 20009, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (161, 20009, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (162, 20009, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (163, 20009, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (164, 20009, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (165, 20010, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (166, 20010, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (167, 20010, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (168, 20010, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (169, 20010, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (170, 20010, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (171, 20011, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (172, 20011, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (173, 20011, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (174, 20011, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (175, 20011, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (176, 20011, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (177, 20012, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-19 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (178, 20012, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-26 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (179, 20012, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-02 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (180, 20012, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-09 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (181, 20012, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-16 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (182, 20012, N'Monday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-23 02:57:39.850' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (183, 20013, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-21 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (184, 20013, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-28 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (185, 20013, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-04 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (186, 20013, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-11 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (187, 20013, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-18 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (188, 20014, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-21 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (189, 20014, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-28 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (190, 20014, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-04 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (191, 20014, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-11 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (192, 20014, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-18 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (193, 20015, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-21 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (194, 20015, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-28 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (195, 20015, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-04 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (196, 20015, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-11 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (197, 20015, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-18 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (198, 20016, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-21 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (199, 20016, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-28 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (200, 20016, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-04 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (201, 20016, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-11 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (202, 20016, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-18 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (203, 20017, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-21 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (204, 20017, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-28 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (205, 20017, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-04 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (206, 20017, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-11 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (207, 20017, N'Wednesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-18 02:57:39.867' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (208, 20018, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-20 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (209, 20018, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-27 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (210, 20018, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-03 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (211, 20018, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-10 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (212, 20018, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-17 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (213, 20018, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-24 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (214, 20019, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-20 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (215, 20019, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-27 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (216, 20019, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-03 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (217, 20019, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-10 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (218, 20019, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-17 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (219, 20019, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-24 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (220, 20020, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-20 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (221, 20020, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-10-27 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (222, 20020, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-03 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (223, 20020, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-10 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (224, 20020, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-17 02:57:39.880' AS DateTime))
GO
INSERT [dbo].[TUTOR_AVAILABLE_TIMES] ([tutor_time_id], [tutor_id], [available_day], [available_time], [date_free]) VALUES (225, 20020, N'Tuesday', CAST(N'08:00:00' AS Time), CAST(N'2015-11-24 02:57:39.880' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[TUTOR_AVAILABLE_TIMES] OFF
GO
SET IDENTITY_INSERT [dbo].[USER_ROLE] ON 

GO
INSERT [dbo].[USER_ROLE] ([user_roles_id], [user_role]) VALUES (1, N'Administrator')
GO
INSERT [dbo].[USER_ROLE] ([user_roles_id], [user_role]) VALUES (2, N'Coordinator')
GO
INSERT [dbo].[USER_ROLE] ([user_roles_id], [user_role]) VALUES (3, N'Tutor')
GO
INSERT [dbo].[USER_ROLE] ([user_roles_id], [user_role]) VALUES (4, N'Student')
GO
SET IDENTITY_INSERT [dbo].[USER_ROLE] OFF
GO
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10003, N'Jill.Hill@sss.com', 4, N'h8yK+1k0AEz/z9uC54lmsAi2Qjwulcns8HkSXzVQQa9zmm1k2rJFr8LSKWeM7uw8L3Dp0KBcuH8sMgwL5c42ZA==', N'rQ4apc7ErwXL3s8eeIOYgcdGVBruS8sDhONU7ADBxHqJMwZjGkzm0Y7UE/WkUBF6Pm+GYl9iQpVSKm+rfIgXeg==', NULL, NULL, 0, 0, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10004, N'Nathan.De.Beer@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10005, N'Anne.Hunt@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10007, N'Nadine.Steps@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10008, N'Dan.Patterson@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10009, N'Harry.Key@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10010, N'Hermione.Jilly@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10013, N'Savannah.Price@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10014, N'Prakesh.Naidoo@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10022, N'Dane.Smith@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10023, N'Shane.Potter@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10024, N'Amir.Cohen@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10026, N'Abe.Jameson@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10027, N'Gera.Feld@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10028, N'Uriel.Ruiz@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10029, N'Leon.Holmes@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10032, N'Andreas.Watson@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10033, N'Yair.Levin@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10034, N'Nevil.Anderson@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10035, N'Jonny.Cave@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10036, N'Blair.Kettle@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10037, N'danieljohnson@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10038, N'petejackson@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (10039, N'DaisyBlue@sss.com', 4, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20001, N'Susan.Kotzen@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20002, N'Nathan.De Beer@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20003, N'Anne.Junt@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20004, N'Nadine.Steps@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20005, N'Dan.Patterson@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20006, N'Harry.Key@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20007, N'Hermione.Jilly@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20008, N'Savannah.Price@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20009, N'Prakesh.Naidoo@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20010, N'Darryn.Spouse@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20011, N'Catherine.Jennings@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20012, N'James.Door@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20013, N'Keith.Gate@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20014, N'Tom.Van De Merwe@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20015, N'Jack.Black@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20016, N'Tato.Muda@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20017, N'Sarah.Jackson@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20018, N'Jones.Johnson@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20019, N'Susan.Stuart@sss.com', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (20020, N'Zoe.Caplin@sss.com ', 3, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (69857, N'Sam.Gap@sss.com', 2, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (76582, N'Charles.Peters@sss.com',2, N'h8yK+1k0AEz/z9uC54lmsAi2Qjwulcns8HkSXzVQQa9zmm1k2rJFr8LSKWeM7uw8L3Dp0KBcuH8sMgwL5c42ZA==', N'iUEf19fwb3GDB5noX00XsrdknBSY+TeZz4jomkaURCsDoPxtsctgocGlK5Y9TAdn1fX4q+Da7pZIHoIB0xFaOw==', NULL, NULL, 0, 0, NULL)
GO												    
INSERT [dbo].[USERPROFILE] ([user_id], [user_name], [user_roles_id], [password_hash], [password_salt], [PrimaryAccent], [SecondaryAccent], [isDark], [resetPassword], [useOldForms]) VALUES (76589, N'Zuko.Singhdee@sss.com', 2, NULL, NULL, NULL, NULL, 0, 1, NULL)
GO
ALTER TABLE [dbo].[ATTENDANCE]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[STUDENT] ([student_id])
GO
ALTER TABLE [dbo].[ATTENDANCE]  WITH CHECK ADD FOREIGN KEY([student_activity_id])
REFERENCES [dbo].[STUDENT_ACTIVITY] ([student_activity_id])
GO
ALTER TABLE [dbo].[CONSULTATION]  WITH CHECK ADD FOREIGN KEY([coordinator_id])
REFERENCES [dbo].[SSS_COORDINATOR] ([coordinator_id])
GO
ALTER TABLE [dbo].[CONSULTATION]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[STUDENT] ([student_id])
GO
ALTER TABLE [dbo].[CONSULTATION]  WITH CHECK ADD FOREIGN KEY([tutor_id])
REFERENCES [dbo].[TUTOR] ([tutor_id])
GO
ALTER TABLE [dbo].[ENROLLMENT]  WITH CHECK ADD FOREIGN KEY([course_id])
REFERENCES [dbo].[COURSE] ([course_id])
GO
ALTER TABLE [dbo].[ENROLLMENT]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[STUDENT] ([student_id])
GO
ALTER TABLE [dbo].[SESSION]  WITH CHECK ADD FOREIGN KEY([group_id])
REFERENCES [dbo].[GROUP] ([group_id])
GO
ALTER TABLE [dbo].[SESSION]  WITH CHECK ADD FOREIGN KEY([tutor_id])
REFERENCES [dbo].[TUTOR] ([tutor_id])
GO
ALTER TABLE [dbo].[STUDENT]  WITH CHECK ADD FOREIGN KEY([coordinator_id])
REFERENCES [dbo].[SSS_COORDINATOR] ([coordinator_id])
GO
ALTER TABLE [dbo].[STUDENT]  WITH CHECK ADD FOREIGN KEY([group_id])
REFERENCES [dbo].[GROUP] ([group_id])
GO
ALTER TABLE [dbo].[TUTOR_AVAILABLE_TIMES]  WITH CHECK ADD FOREIGN KEY([tutor_id])
REFERENCES [dbo].[TUTOR] ([tutor_id])
GO
ALTER TABLE [dbo].[USERPROFILE]  WITH CHECK ADD FOREIGN KEY([user_roles_id])
REFERENCES [dbo].[USER_ROLE] ([user_roles_id])
GO
USE [master]
GO
ALTER DATABASE [IS2G10_DBSSS] SET  READ_WRITE 
GO
