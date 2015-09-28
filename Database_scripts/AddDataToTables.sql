--add data to each table
--must be done in order so as not to break relations
USE [IS2G10_DBSSS];
GO
--STUDENT_ACTIVITY TABLE
INSERT INTO [dbo].[STUDENT_ACTIVITY]
           ([student_activity_name]
           ,[student_activity_pointvalue]
           ,[student_activity_week]
           ,[student_activity_description])
     VALUES
           (<student_activity_name, nvarchar(255),>
           ,<student_activity_pointvalue, int,>
           ,<student_activity_week, int,>
           ,<student_activity_description, nvarchar(255),>)
GO
--TUTOR TABLE
INSERT INTO [dbo].[TUTOR]
           ([tutor_firstname]
           ,[tutor_lastname]
           ,[tutor_id_passport]
           ,[tutor_dateofbirth]
           ,[tutor_emailaddress]
           ,[tutor_cellnumber]
           ,[tutor_trainingstatus])
     VALUES
           (<tutor_firstname, nvarchar(255),>
           ,<tutor_lastname, nvarchar(255),>
           ,<tutor_id_passport, nvarchar(255),>
           ,<tutor_dateofbirth, datetime,>
           ,<tutor_emailaddress, nvarchar(255),>
           ,<tutor_cellnumber, nvarchar(255),>
           ,<tutor_trainingstatus, bit,>)
GO
--SSS COORDINATOR TABLE
INSERT INTO [dbo].[SSS_COORDINATOR]
           ([coordinator_firstname]
           ,[coordinator_lastname]
           ,[coordinator_id_passport]
           ,[coordinator_dateofbirth]
           ,[coordinator_emailaddress]
           ,[coordinator_cellnumber])
     VALUES
           (<coordinator_firstname, nvarchar(255),>
           ,<coordinator_lastname, nvarchar(255),>
           ,<coordinator_id_passport, nvarchar(255),>
           ,<coordinator_dateofbirth, datetime,>
           ,<coordinator_emailaddress, nvarchar(255),>
           ,<coordinator_cellnumber, nvarchar(255),>)
GO
--COURSE TABLE
INSERT INTO [dbo].[COURSE]
           ([course_name])
     VALUES
           (<course_name, nvarchar(255),>)
GO
--[GROUP] TABLE
INSERT INTO [dbo].[GROUP]
           ([group_dates]
           ,[group_times])
     VALUES
           (<group_dates, datetime,>
           ,<group_times, time(7),>)
GO
--STUDENT TABLE
INSERT INTO [dbo].[STUDENT]
           ([coordinator_id]
           ,[group_id]
           ,[student_firstname]
           ,[student_lastname]
           ,[student_id_passport]
           ,[student_dateofbirth]
           ,[student_emailaddress]
           ,[student_mobilenumber]
           ,[student_yearofstudy]
           ,[student_degreeprogramme]
           ,[student_status]
           ,[student_points])
     VALUES
           (<coordinator_id, int,>
           ,<group_id, int,>
           ,<student_firstname, nvarchar(255),>
           ,<student_lastname, nvarchar(255),>
           ,<student_id_passport, nvarchar(255),>
           ,<student_dateofbirth, datetime,>
           ,<student_emailaddress, nvarchar(255),>
           ,<student_mobilenumber, nvarchar(255),>
           ,<student_yearofstudy, int,>
           ,<student_degreeprogramme, nvarchar(255),>
           ,<student_status, nvarchar(255),>
           ,<student_points, int,>)
GO
--CONSULTATION TABLE
INSERT INTO [dbo].[CONSULTATION]
           ([coordinator_id]
           ,[student_id]
           ,[consultation_details]
           ,[consultation_date]
           ,[student_arrived]
           ,[consultation_rating])
     VALUES
           (<coordinator_id, int,>
           ,<student_id, int,>
           ,<consultation_details, nvarchar(255),>
           ,<consultation_date, datetime,>
           ,<student_arrived, bit,>
           ,<consultation_rating, int,>)
GO
--ENROLLMENT TABLE
INSERT INTO [dbo].[ENROLLMENT]
           ([course_id]
           ,[student_id]
           ,[class_mark]
           ,[exam_mark]
           ,[year_mark])
     VALUES
           (<course_id, int,>
           ,<student_id, int,>
           ,<class_mark, float,>
           ,<exam_mark, float,>
           ,<year_mark, float,>)
GO
--ATTENDANCE TABLE
INSERT INTO [dbo].[ATTENDANCE]
           ([student_id]
           ,[student_activity_id]
           ,[student_activity_tutorrating]
           ,[student_activity_rating]
           ,[student_arrived])
     VALUES
           (<student_id, int,>
           ,<student_activity_id, int,>
           ,<student_activity_tutorrating, int,>
           ,<student_activity_rating, int,>
           ,<student_arrived, bit,>)
GO
--[SESSION] TABLE
INSERT INTO [dbo].[SESSION]
           ([tutor_id]
           ,[group_id]
           ,[updated_attendance])
     VALUES
           (<tutor_id, int,>
           ,<group_id, int,>
           ,<updated_attendance, bit,>)
GO


--DONE!
PRINT ('INPUT COMPLETE.');