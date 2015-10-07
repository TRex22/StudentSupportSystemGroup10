DECLARE @groupId int;
set @groupId = 1;

IF @groupId = NULL
BEGIN
	SELECT        TUTOR.tutor_id, TUTOR.tutor_firstname, TUTOR.tutor_lastname, TUTOR.tutor_id_passport, TUTOR.tutor_dateofbirth, TUTOR.tutor_emailaddress, 
                         TUTOR.tutor_cellnumber, TUTOR.tutor_trainingstatus, SESSION.group_id
	FROM            TUTOR INNER JOIN
                         SESSION ON TUTOR.tutor_id = SESSION.tutor_id
	WHERE		NOT EXISTS(SELECT TUTOR.tutor_id, TUTOR.tutor_firstname, TUTOR.tutor_lastname, TUTOR.tutor_id_passport, TUTOR.tutor_dateofbirth, TUTOR.tutor_emailaddress, 
                         TUTOR.tutor_cellnumber, TUTOR.tutor_trainingstatus FROM TUTOR INNER JOIN
                         SESSION ON TUTOR.tutor_id = SESSION.tutor_id);
END
ELSE
BEGIN
	SELECT        TUTOR.tutor_id, TUTOR.tutor_firstname, TUTOR.tutor_lastname, TUTOR.tutor_id_passport, TUTOR.tutor_dateofbirth, TUTOR.tutor_emailaddress, 
                         TUTOR.tutor_cellnumber, TUTOR.tutor_trainingstatus, SESSION.group_id
	FROM            TUTOR INNER JOIN
                         SESSION ON TUTOR.tutor_id = SESSION.tutor_id;


END