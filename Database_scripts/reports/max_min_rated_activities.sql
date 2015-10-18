SELECT (SELECT    STUDENT_ACTIVITY.student_activity_name AS max_rated_activity
		FROM            STUDENT_ACTIVITY INNER JOIN
								 ATTENDANCE ON STUDENT_ACTIVITY.student_activity_id = ATTENDANCE.student_activity_id
		WHERE	  student_activity_tutorrating = (SELECT AVG(ATTENDANCE.student_activity_rating)    
					FROM            STUDENT_ACTIVITY INNER JOIN
								 ATTENDANCE ON STUDENT_ACTIVITY.student_activity_id = ATTENDANCE.student_activity_id)) AS max_rated_activity