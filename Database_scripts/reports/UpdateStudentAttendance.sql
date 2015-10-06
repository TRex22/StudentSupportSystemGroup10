SELECT (STUDENT.student_firstname +' '+ STUDENT.student_lastname) AS 'Student Name', ATTENDANCE.student_id AS 'Student Id', ATTENDANCE.student_arrived AS 'Attendance'
FROM ATTENDANCE INNER JOIN STUDENT ON ATTENDANCE.student_id = STUDENT.student_id INNER JOIN [GROUP] ON STUDENT.group_id = [GROUP].group_id
WHERE [GROUP].group_id = 1 AND student_activity_id = 1
