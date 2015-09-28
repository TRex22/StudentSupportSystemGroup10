-- Group 10 2015 SSS Database
--Used to create the database once off
--Uncomment the server you have SQL Express or the other one

USE master ;
GO
-- SQL SERVER EXPRESS
--CREATE DATABASE IS2G10_DBSSS
--ON 
--( NAME = IS2G10_DBSSS,
--    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IS2G10_DBSSS.mdf',
--    SIZE = 10,
--    MAXSIZE = 50,
--    FILEGROWTH = 5 )
--LOG ON
--( NAME = IS2G10_DBSSS_log,
--    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IS2G10_DBSSS_log.ldf',
--    SIZE = 5MB,
--    MAXSIZE = 25MB,
--    FILEGROWTH = 5MB ) ;
---GO

--MSSQL Default Install
CREATE DATABASE IS2G10_DBSSS
ON 
( NAME = IS2G10_DBSSS,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\IS2G10_DBSSS.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 )
LOG ON
( NAME = IS2G10_DBSSS_log,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\IS2G10_DBSSS_log.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB ) ;
GO

ALTER AUTHORIZATION ON DATABASE::IS2G10_DBSSS TO [sa];

-- Create Tables
USE IS2G10_DBSSS;
GO
CREATE TABLE STUDENT_ACTIVITY (
	student_activity_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	student_activity_name nvarchar(255),
	student_activity_pointvalue int,
	student_activity_week int,
	student_activity_description nvarchar(255)
);
GO
CREATE TABLE TUTOR (
	tutor_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	tutor_firstname nvarchar(255),
	tutor_lastname nvarchar(255),
	tutor_id_passport nvarchar(255),
	tutor_dateofbirth datetime,
	tutor_emailaddress nvarchar(255),
	tutor_cellnumber nvarchar(255),
	tutor_trainingstatus bit 
);
GO
CREATE TABLE SSS_COORDINATOR(
	coordinator_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	coordinator_firstname nvarchar(255),
	coordinator_lastname nvarchar(255),
	coordinator_id_passport nvarchar(255),
	coordinator_dateofbirth datetime,
	coordinator_emailaddress nvarchar(255),
	coordinator_cellnumber nvarchar(255)
);
GO
CREATE TABLE COURSE (
	course_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	course_name nvarchar(255)
);
GO
CREATE TABLE [GROUP] (
	group_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	group_dates datetime,
	group_times time
);
GO
CREATE TABLE STUDENT (
	student_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	coordinator_id int FOREIGN KEY REFERENCES SSS_COORDINATOR(coordinator_id),
	group_id int FOREIGN KEY REFERENCES [GROUP](group_id),
	student_firstname nvarchar(255),
	student_lastname nvarchar(255),
	student_id_passport nvarchar(255),
	student_dateofbirth datetime,
	student_emailaddress nvarchar(255),
	student_mobilenumber nvarchar(255),
	student_yearofstudy int,
	student_degreeprogramme nvarchar(255),
	student_status nvarchar(255),
	student_points int
);
GO
CREATE TABLE CONSULTATION (
	consultation_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	coordinator_id int FOREIGN KEY REFERENCES SSS_COORDINATOR(coordinator_id),
	student_id int FOREIGN KEY REFERENCES STUDENT(student_id),
	consultation_details nvarchar(255),
	consultation_date datetime,
	student_arrived bit,
	consultation_rating int
);
GO
CREATE TABLE ENROLLMENT (
	course_id int NOT NULL FOREIGN KEY REFERENCES COURSE(course_id),
	student_id int NOT NULL FOREIGN KEY REFERENCES STUDENT(student_id),
	class_mark float,
	exam_mark float,
	year_mark float,
	PRIMARY KEY (course_id, student_id)	
);
GO
CREATE TABLE ATTENDANCE (
	student_id int NOT NULL FOREIGN KEY REFERENCES STUDENT(student_id),
	student_activity_id int NOT NULL FOREIGN KEY REFERENCES STUDENT_ACTIVITY(student_activity_id),
	student_activity_tutorrating int,
	student_activity_rating int,
	student_arrived bit,
	PRIMARY KEY (student_id, student_activity_id)
);
GO
CREATE TABLE [SESSION] (
	tutor_id int NOT NULL FOREIGN KEY REFERENCES TUTOR(tutor_id),
	group_id int NOT NULL FOREIGN KEY REFERENCES [GROUP](group_id),
	updated_attendance bit,
	PRIMARY KEY (tutor_id, group_id)
);
GO
PRINT ('DATABASE CREATED');