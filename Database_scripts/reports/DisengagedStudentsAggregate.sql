SELECT COUNT(student_id) AS 'NumberOfStudents'
FROM dbo.STUDENT
GROUP BY student_points
HAVING dbo.STUDENT.student_points < 35
ORDER BY dbo.STUDENT.student_points ASC;