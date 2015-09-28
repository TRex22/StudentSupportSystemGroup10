-- Delete database BE CAREFUL
-- Use master;
-- ALTER database IS2G10_DBSSS set offline with ROLLBACK IMMEDIATE;
-- DROP DATABASE IS2G10_DBSSS;

USE master ;
GO
CREATE DATABASE IS2G10_DBSSS
ON 
( NAME = IS2G10_DBSSS,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IS2G10_DBSSS.mdf',
    SIZE = 10,
    MAXSIZE = 50,
    FILEGROWTH = 5 )
LOG ON
( NAME = IS2G10_DBSSS_log,
    FILENAME = 'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\IS2G10_DBSSS_log.ldf',
    SIZE = 5MB,
    MAXSIZE = 25MB,
    FILEGROWTH = 5MB ) ;
GO

ALTER AUTHORIZATION ON DATABASE::IS2G10_DBSSS TO [sa];

-- Create Tables
USE IS2G10_DBSSS;
GO
CREATE TABLE STUDENT_ACTIVITY (
	student_activity_no int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	student_activity_name nvarchar(255),
	student_activity_pointvalue int,
	student_activity_week int,
	student_activity_description nvarchar(255)
);
GO
CREATE TABLE TUTOR (
	tutor_no int IDENTITY(1,1) NOT NULL PRIMARY KEY,
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
	coordinator_no int IDENTITY(1,1) NOT NULL PRIMARY KEY,
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
CREATE TABLE GROUPtbl (
	group_no int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	group_dates datetime,
	group_times time
);
GO
CREATE TABLE STUDENT (
	student_no int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	coordinator_no int FOREIGN KEY REFERENCES SSS_COORDINATOR(coordinator_no),
	group_no int FOREIGN KEY REFERENCES GROUPtbl(group_no),
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
	consultation_no int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	coordinator_no int FOREIGN KEY REFERENCES SSS_COORDINATOR(coordinator_no),
	student_no int FOREIGN KEY REFERENCES STUDENT(student_no),
	consultation_details nvarchar(255),
	consultation_date datetime,
	student_arrived bit,
	consultation_rating int
);
GO
CREATE TABLE ENROLLMENT (
	course_id int NOT NULL FOREIGN KEY REFERENCES COURSE(course_id),
	student_id int NOT NULL FOREIGN KEY REFERENCES STUDENT(student_no),
	class_mark double,
	exam_mark double,
	year_mark double,
	PRIMARY KEY (course_id, student_id)	
);
GO
CREATE TABLE ATTENDANCE (
	student_no int NOT NULL FOREIGN KEY REFERENCES STUDENT(student_no),
	student_activity_no int NOT NULL FOREIGN KEY REFERENCES STUDENT_ACTIVITY(student_activity_no),
	student_activity_tutorrating int,
	student_activity_rating int,
	student_arrived bit,
	PRIMARY KEY (student_no, student_activity_no)
);
GO
CREATE TABLE SESSIONtbl (
	tutor_no int NOT NULL FOREIGN KEY REFERENCES TUTOR(tutor_no),
	group_no int NOT NULL FOREIGN KEY REFERENCES GROUPtbl(group_no),
	updated_attendance bit,
	PRIMARY KEY (tutor_no, group_no)
);
