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
INSERT [dbo].[SSS_COORDINATOR] ([coordinator_id], [coordinator_firstname], [coordinator_lastname], [coordinator_id_passport], [coordinator_dateofbirth], [coordinator_emailaddress], [coordinator_cellnumber]) VALUES (76582, N'Charles', N'Peters', N'8990060656183', CAST(N'1989-06-13 00:00:00.000' AS DateTime), N'Charles.Peters@sss.com', N'(071)567 2854')
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10003, NULL, NULL, N'Jill Hill', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10004, NULL, NULL, N'Nathan De Beer', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10005, NULL, NULL, N'Anne hunt', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10007, NULL, NULL, N'Nadine Steps', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10008, NULL, NULL, N'Dan Patterson', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10009, NULL, NULL, N'Harry Key', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10010, NULL, NULL, N'Hermione Jilly', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10013, NULL, NULL, N'Savannah Price', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10014, NULL, NULL, N'Prakesh Naidoo', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10022, NULL, NULL, N'Dane Smith', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10023, NULL, NULL, N'Shane Potter', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10024, NULL, NULL, N'Amir Cohen', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10026, NULL, NULL, N'Abe Jameson', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10027, NULL, NULL, N'Gera Feld', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10028, NULL, NULL, N'Uriel Ruiz', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10029, NULL, NULL, N'Leon Holmes', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10032, NULL, NULL, N'Andreas Watson', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10033, NULL, NULL, N'Yair Levin', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10034, NULL, NULL, N'Nevil Anderson', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10035, NULL, NULL, N'Jonny Cave', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
GO
INSERT [dbo].[TUTOR] ([tutor_id], [tutor_firstname], [tutor_lastname], [tutor_id_passport], [tutor_dateofbirth], [tutor_emailaddress], [tutor_cellnumber], [tutor_trainingstatus]) VALUES (20001, N'Jill', N'Hill', N'9415362161183', CAST(N'1993-07-12 00:00:00.000' AS DateTime), N'Jill.Hill@sss.com', N'(071)549 5634', 1)
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
SET IDENTITY_INSERT [dbo].[CONSULTATION] ON 

GO
INSERT [dbo].[CONSULTATION] ([consultation_id], [coordinator_id], [student_id], [consultation_details], [consultation_date], [student_arrived], [consultation_rating]) VALUES (4, 76582, 10003, N'Having trouble with login into the system', CAST(N'2015-08-20 00:00:00.000' AS DateTime), 1, 4)
GO
INSERT [dbo].[CONSULTATION] ([consultation_id], [coordinator_id], [student_id], [consultation_details], [consultation_date], [student_arrived], [consultation_rating]) VALUES (5, 76582, 10024, N'Having problems with information systems diagrams.', CAST(N'2015-08-22 00:00:00.000' AS DateTime), 0, NULL)
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



--DONE!
PRINT ('INPUT COMPLETE.');