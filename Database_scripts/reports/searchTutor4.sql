DECLARE @groupId int;
set @groupId = 1;
DECLARE @isGrouped bit;
set @isGrouped = 0;

IF @isGrouped = 1
SELECT        TUTOR.tutor_id, TUTOR.tutor_firstname, TUTOR.tutor_lastname, TUTOR.tutor_id_passport, TUTOR.tutor_dateofbirth, TUTOR.tutor_emailaddress, 
                         TUTOR.tutor_cellnumber, TUTOR.tutor_trainingstatus
FROM            TUTOR INNER JOIN
                         SESSION ON TUTOR.tutor_id = SESSION.tutor_id
WHERE        (SESSION.group_id = @groupId) OR
                         (SESSION.group_id IS NULL)
ELSE
SELECT        TUTOR.tutor_id, TUTOR.tutor_firstname, TUTOR.tutor_lastname, TUTOR.tutor_id_passport, TUTOR.tutor_dateofbirth, TUTOR.tutor_emailaddress, 
                         TUTOR.tutor_cellnumber, TUTOR.tutor_trainingstatus
FROM            TUTOR 