-- Create BRANDING
USE IS2G10_DBSSS;
GO
CREATE TABLE BRANDING (
	branding_id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	program_icon VARBINARY(MAX),
	system_logo VARBINARY(MAX),
	system_name nvarchar(255),
	splash_colour nvarchar(255),
	splash_time time,
	is_system_clean bit
);
GO
PRINT ('BRANDING CREATED');

DROP TABLE BRANDING;