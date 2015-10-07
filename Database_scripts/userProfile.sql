CREATE TABLE USERPROFILE (
	user_id int NOT NULL PRIMARY KEY,
	user_name nvarchar(255),
	student_id int FOREIGN KEY REFERENCES STUDENT(student_id),
	coordinator_id int FOREIGN KEY REFERENCES SSS_COORDINATOR(coordinator_id),
	tutor_id int FOREIGN KEY REFERENCES TUTOR(tutor_id),
	password_hash nvarchar(255),
	password_salt nvarchar(255),
	PrimaryAccent nvarchar(255),
	SecondaryAccent nvarchar(255),
	isDark bit NOT NULL,
	resetPassword bit NOT NULL
);

DROP TABLE USERPROFILE;