/****** Script for SelectTopNRows command from SSMS  ******/
SELECT STUDENT.group_id, [GROUP].group_name, [GROUP].group_date, [GROUP].group_time
  FROM [IS2G10_DBSSS].[dbo].[STUDENT] INNER JOIN [GROUP] ON [STUDENT].group_id = [GROUP].group_id
  WHERE student_id = @studentId