SELECT STUDENT_ACTIVITY.student_activity_name
FROM ATTENDANCE, STUDENT_ACTIVITY



DECLARE @averages table (
	student_activity_id int,
	avg_rating  decimal
);
INSERT INTO @averages
SELECT student_activity_id, AVG(student_activity_rating) AS avg_rating FROM ATTENDANCE GROUP BY student_activity_id

SELECT a.student_activity_id, a.avg_rating
FROM @averages a
INNER JOIN (SELECT TOP 1 student_activity_id, MAX(avg_rating) AS avg_rating FROM @averages GROUP BY student_activity_id ORDER BY avg_rating DESC) b
ON a.student_activity_id = b.student_activity_id







SELECT student_activity_id
FROM @averages
WHERE avg_rating = (SELECT student_activity_id, MAX(avg_rating) FROM @averages GROUP BY student_activity_id)


