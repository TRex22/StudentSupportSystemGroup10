-- Create BRANDING
USE IS2G10_DBSSS;
GO
CREATE TABLE BRANDING (
	student_activity_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	student_activity_name nvarchar(255),
	student_activity_pointvalue int,
	student_activity_week int,
	student_activity_description nvarchar(255)
);
GO
PRINT ('DATABASE CREATED');