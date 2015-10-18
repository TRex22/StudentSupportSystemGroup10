SELECT (SELECT        AVG(ATTENDANCE.student_activity_tutorrating) AS 'TutorAverage'
		FROM            ATTENDANCE INNER JOIN
									STUDENT_ACTIVITY ON ATTENDANCE.student_activity_id = STUDENT_ACTIVITY.student_activity_id CROSS JOIN
									TUTOR
		GROUP BY TUTOR.tutor_firstname, TUTOR.tutor_lastname, STUDENT_ACTIVITY.student_activity_name, TUTOR.tutor_trainingstatus
		HAVING TUTOR.tutor_trainingstatus = 1) AS 'AverageTutorRatingWithTraining',

		(SELECT        AVG(ATTENDANCE.student_activity_tutorrating) AS 'TutorAverage'
		FROM            ATTENDANCE INNER JOIN
								 STUDENT_ACTIVITY ON ATTENDANCE.student_activity_id = STUDENT_ACTIVITY.student_activity_id CROSS JOIN
								 TUTOR
		GROUP BY TUTOR.tutor_firstname, TUTOR.tutor_lastname, STUDENT_ACTIVITY.student_activity_name, TUTOR.tutor_trainingstatus
		HAVING TUTOR.tutor_trainingstatus = 0) AS 'AverageTutorRatingWithoutTraining';