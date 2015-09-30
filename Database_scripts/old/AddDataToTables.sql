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
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10003, 76582, 1, N'Jill', N'Hill', N'9415362161183', CAST(N'1994-07-12 00:00:00.000' AS DateTime), N'Jill.Hill@sss.com', N'(084)228 2135', 1, N'SB000', N'BLUE', 60)
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
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10032, 76582, 1, N'Andreas', N'Watson', N'9890060656183', CAST(N'1995-08-06 00:00:00.000' AS DateTime), N'Andreas.Watson@sss.com', N'(083)556 1566', 1, N'SB000', N'SLIVER', 160)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10033, 76582, NULL, N'Yair', N'Levin', N'3303033626180', CAST(N'1995-11-11 00:00:00.000' AS DateTime), N'Yair.Levin@sss.com', N'(071)789 2567', 1, N'ACSCI', N'WHITE', 0)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10034, 76582, NULL, N'Nevil', N'Anderson', N'2103212427181', CAST(N'1995-09-17 00:00:00.000' AS DateTime), N'Nevil.Anderson@sss.com', N'(084)333 4568', 2, N'ACSCI', N'WHITE', 0)
GO
INSERT [dbo].[STUDENT] ([student_id], [coordinator_id], [group_id], [student_firstname], [student_lastname], [student_id_passport], [student_dateofbirth], [student_emailaddress], [student_mobilenumber], [student_yearofstudy], [student_degreeprogramme], [student_status], [student_points]) VALUES (10035, 76582, NULL, N'Jonny', N'Cave', N'9405366364086', CAST(N'1995-11-18 00:00:00.000' AS DateTime), N'Jonny.Cave@sss.com', N'(071)774 3259', 2, N'ACSCI', N'WHITE', 0)
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
USE [IS2G10_DBSSS]
GO
SET IDENTITY_INSERT [dbo].[GROUP] ON 

GO
INSERT [dbo].[GROUP] ([group_id], [group_name]) VALUES (1, N'Group 1')
GO
INSERT [dbo].[GROUP] ([group_id], [group_name]) VALUES (2, N'Group 2')
GO
INSERT [dbo].[GROUP] ([group_id], [group_name]) VALUES (3, N'Group 3')
GO
INSERT [dbo].[GROUP] ([group_id], [group_name]) VALUES (4, N'Group 4')
GO
SET IDENTITY_INSERT [dbo].[GROUP] OFF
GO
SET IDENTITY_INSERT [dbo].[GROUP_DATETIME] ON 

GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (1, 1, CAST(N'2015-10-01 00:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (2, 1, CAST(N'2015-10-08 00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (3, 2, CAST(N'2015-10-02 00:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (4, 2, CAST(N'2015-10-09 00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (5, 3, CAST(N'2015-10-03 00:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (6, 3, CAST(N'2015-10-10 00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (7, 4, CAST(N'2015-10-04 00:00:00.000' AS DateTime), CAST(N'14:00:00' AS Time))
GO
INSERT [dbo].[GROUP_DATETIME] ([group_date_id], [group_id], [group_date], [group_time]) VALUES (8, 4, CAST(N'2015-10-11 00:00:00.000' AS DateTime), CAST(N'08:00:00' AS Time))
GO
SET IDENTITY_INSERT [dbo].[GROUP_DATETIME] OFF
GO
USE [IS2G10_DBSSS]
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20001, 1, 1)
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20001, 2, 0)
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20010, 3, 0)
GO
INSERT [dbo].[SESSION] ([tutor_id], [group_id], [updated_attendance]) VALUES (20010, 4, 1)
GO
USE [IS2G10_DBSSS]
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
INSERT [dbo].[ENROLLMENT] ([course_id], [student_id], [class_mark], [exam_mark], [year_mark]) VALUES (2, 10032, 82, 82, NULL)
GO
USE [IS2G10_DBSSS]
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10003, 1, 4, 1, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10004, 1, 3, 2, 1)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10005, 1, 5, 5, 0)
GO
INSERT [dbo].[ATTENDANCE] ([student_id], [student_activity_id], [student_activity_tutorrating], [student_activity_rating], [student_arrived]) VALUES (10010, 2, 5, 5, 1)
GO



--DONE!
PRINT ('INPUT COMPLETE.');