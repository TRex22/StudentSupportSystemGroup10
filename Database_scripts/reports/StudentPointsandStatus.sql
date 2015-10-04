SELECT student_status, COUNT(student_status) AS 'student_statuses'
FROM STUDENT
GROUP BY student_status