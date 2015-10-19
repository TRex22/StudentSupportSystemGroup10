SELECT        AVG(ATTENDANCE.student_activity_tutorrating) AS 'AverageTutorRating', AVG(ATTENDANCE.student_activity_rating) AS 'AverageActivityRating', 
                         COUNT(DISTINCT TUTOR.tutor_id) AS 'TotalNumberTutors', COUNT(DISTINCT STUDENT_ACTIVITY.student_activity_id) AS 'TotalNumberActivities',
						  (SELECT TOP 1  student_activity_name avg_rating FROM ATTENDANCE INNER JOIN STUDENT_ACTIVITY ON ATTENDANCE.student_activity_id = STUDENT_ACTIVITY.student_activity_id GROUP BY student_activity_name ORDER BY AVG(student_activity_rating) DESC) AS 'MostPopularActivity',
						   (SELECT TOP 1  student_activity_name avg_rating FROM ATTENDANCE INNER JOIN STUDENT_ACTIVITY ON ATTENDANCE.student_activity_id = STUDENT_ACTIVITY.student_activity_id GROUP BY student_activity_name ORDER BY AVG(student_activity_rating) ASC) AS 'LeastPopularActivity'
FROM            ATTENDANCE, STUDENT_ACTIVITY, TUTOR

