SELECT [GROUP].group_id, [GROUP].group_name
FROM  [dbo].[SESSION] INNER JOIN [dbo].[GROUP] ON [dbo].[SESSION].group_id = [dbo].[GROUP].group_id
WHERE [dbo].[SESSION].tutor_id = 20001