-- Create BRANDING
USE IS2G10_DBSSS;
GO
CREATE TABLE BRANDING (
	branding_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	program_icon,
	system_logo,
	system_name nvarchar(255),
	splash_colour nvarchar(255),
	splash_time time
);
GO
PRINT ('BRANDING CREATED');