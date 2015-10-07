SELECT        AVG(ATTENDANCE.student_activity_tutorrating) AS 'TutorAverage', TUTOR.tutor_id
FROM            ATTENDANCE INNER JOIN
                         STUDENT ON ATTENDANCE.student_id = STUDENT.student_id INNER JOIN
                         [GROUP] ON STUDENT.group_id = [GROUP].group_id INNER JOIN
                         SESSION ON [GROUP].group_id = SESSION.group_id INNER JOIN
                         TUTOR ON SESSION.tutor_id = TUTOR.tutor_id
GROUP BY TUTOR.tutor_id