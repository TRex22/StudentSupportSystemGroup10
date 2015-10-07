SELECT        TUTOR.tutor_id, TUTOR.tutor_firstname, TUTOR.tutor_lastname, TUTOR.tutor_id_passport, TUTOR.tutor_dateofbirth, TUTOR.tutor_emailaddress, 
                         TUTOR.tutor_cellnumber, TUTOR.tutor_trainingstatus, SESSION.group_id
FROM            TUTOR INNER JOIN
                         SESSION ON TUTOR.tutor_id = SESSION.tutor_id
WHERE        (SESSION.group_id = @groupId) AND (SESSION.group_id IS NOT NULL) OR
                         (SESSION.group_id IS NULL) AND (@groupId IS NULL)
