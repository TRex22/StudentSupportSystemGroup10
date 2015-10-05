SELECT [GROUP].group_name, COUNT(dbo.STUDENT.group_id) AS 'GroupCount' 
FROM dbo.STUDENT INNER JOIN [GROUP] ON STUDENT.group_id = [GROUP].group_id
GROUP BY [GROUP].group_id, [GROUP].group_name;

SELECT STUDENT.group_id
FROM dbo.STUDENT 
GROUP BY STUDENT.group_id