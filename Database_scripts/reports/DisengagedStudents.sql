SELECT *
FROM dbo.STUDENT
WHERE dbo.STUDENT.student_points < 35
ORDER BY dbo.STUDENT.student_points ASC;