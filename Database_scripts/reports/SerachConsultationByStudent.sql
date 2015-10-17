SELECT        CONSULTATION.coordinator_id, CONSULTATION.tutor_id, CONSULTATION.student_id, CONSULTATION.consultation_details, CONSULTATION.consultation_date, 
                         CONSULTATION.student_arrived, CONSULTATION.consultation_rating, STUDENT.group_id, STUDENT.student_firstname, STUDENT.student_lastname, 
                         STUDENT.student_id_passport, STUDENT.student_dateofbirth, STUDENT.student_emailaddress, STUDENT.student_mobilenumber, STUDENT.student_yearofstudy, 
                         STUDENT.student_degreeprogramme, STUDENT.student_status, STUDENT.student_points, TUTOR.tutor_firstname, TUTOR.tutor_lastname, 
                         TUTOR.tutor_id_passport, TUTOR.tutor_dateofbirth, TUTOR.tutor_emailaddress, TUTOR.tutor_cellnumber, TUTOR.tutor_trainingstatus
FROM            CONSULTATION INNER JOIN
                         STUDENT ON CONSULTATION.student_id = STUDENT.student_id INNER JOIN
                         TUTOR ON CONSULTATION.tutor_id = TUTOR.tutor_id
WHERE        (CONSULTATION.student_id = @studentId)