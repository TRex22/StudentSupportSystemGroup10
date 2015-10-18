SELECT () AS max_rated_activity,

		() AS min_rated_activity


SELECT    MAX(STUDENT_ACTIVITY.student_activity_name) AS max_rated_activity
		FROM            STUDENT_ACTIVITY INNER JOIN
								 ATTENDANCE ON STUDENT_ACTIVITY.student_activity_id = ATTENDANCE.student_activity_id
		WHERE	  student_activity_rating = ()


		SELECT ATTENDANCE.student_activity_rating , ATTENDANCE.student_activity_id
					FROM STUDENT_ACTIVITY INNER JOIN
								 ATTENDANCE ON STUDENT_ACTIVITY.student_activity_id = ATTENDANCE.student_activity_id
								 GROUP BY ATTENDANCE.student_activity_id, ATTENDANCE.student_activity_rating 
								 


select max (avg_salary)
from (select worker_id, avg(salary) AS avg_salary
  from workers
  group by worker_id);