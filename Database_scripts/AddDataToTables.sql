--add data to each table
--must be done in order so as not to break relations
USE [IS2G10_DBSSS]
GO
SET IDENTITY_INSERT [dbo].[STUDENT_ACTIVITY] ON 

GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (1, N'Reading-Level Test', 10, 1, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (2, N'Time Management Workshop', 10, 2, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (3, N'Study Skills Workshop', 10, 3, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (4, N'Note Taking Strategies Workshop', 10, 4, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (5, N'Test Taking Strategies Workshop', 10, 5, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (6, N'Block 1 Reflection Quiz', 10, 7, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (7, N'Reflection and Motivation Workshop ', 10, 8, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (8, N'Learning from Mistakes Workshop', 10, 9, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (9, N'Examination Study Planning Workshop', 10, 12, NULL)
GO
INSERT [dbo].[STUDENT_ACTIVITY] ([student_activity_id], [student_activity_name], [student_activity_pointvalue], [student_activity_week], [student_activity_description]) VALUES (10, N'Block 2 Reflection Quiz ', 10, 13, NULL)
GO
SET IDENTITY_INSERT [dbo].[STUDENT_ACTIVITY] OFF
GO


--DONE!
PRINT ('INPUT COMPLETE.');