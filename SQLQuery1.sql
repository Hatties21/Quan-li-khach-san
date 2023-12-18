CREATE TABLE user_table(
	user_id INT IDENTITY(1,1),
	username VARCHAR(50),
	password VARCHAR(50),
	user_role INT,
	PRIMARY KEY(user_id)

); 