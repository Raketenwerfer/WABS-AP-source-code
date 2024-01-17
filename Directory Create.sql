USE WABS_DIRECTORY

CREATE TABLE _AuthUserDir
(
	authID VARCHAR(256) PRIMARY KEY,
	[name] VARCHAR(160),
	username VARCHAR(64),
	_password VARCHAR(512),
	usertype VARCHAR(6)
)

CREATE TABLE _ApplicantEntry
(
	appdate VARCHAR(32),
	id VARCHAR(256) PRIMARY KEY,
	fname VARCHAR(64),
	mname VARCHAR(32),
	lname VARCHAR(64),
	age INT,
	bdate VARCHAR(12),
	gender VARCHAR(16),
	[address] VARCHAR(128),
	cno VARCHAR(64),
	email VARCHAR(64),
	educational_background VARCHAR(128),
	course VARCHAR(256),
	[source] VARCHAR(128),
	priority_endorsement VARCHAR(64),
	other_endorsements VARCHAR(256),
	mode_of_endorsements VARCHAR(128),
	exp_months INT,
	account_manager VARCHAR(64),
	account_status VARCHAR(256),
	[start_date] VARCHAR(32),
	[status] VARCHAR(8)
)


--CREATE TABLE _AccMngrs
--(
--	mngrID INT FOREIGN KEY REFERENCES _AuthUserDir (authID),
--	manager VARCHAR(256),
--	applicantID VARCHAR(256) FOREIGN KEY REFERENCES _ApplicantEntry (id),
--	handled_applicants VARCHAR(256)
--)


DROP TABLE _AuthUserDir;
DROP TABLE _ApplicantEntry;
DROP TABLE _AccMngrs;

		DELETE FROM _ApplicantEntry


	SELECT * FROM _ApplicantEntry WHERE = 23

		SELECT * FROM _ApplicantEntry
	WHERE _ApplicantEntry.mname LIKE 'L43'

SELECT * FROM _ApplicantEntry WHERE [status] = 'ACTIVE' AND gender = 'Female'


INSERT INTO _AuthUserDir
VALUES ('222', 'Walter Hartwell White', 'brokebad', 'brokebad', 'USER')


--- Check for users and debug authentication measures
SELECT authID, usertype FROM _AuthUserDir WHERE username = 'Admin' AND name = 'Administrator'

SELECT * FROM _AuthUSerDir


UPDATE _AuthUserDir
SET usertype = 'ADMIN'
WHERE [name] = 'Administrator'


UPDATE _ApplicantEntry
SET [status] = 'ACTIVE'
WHERE [status] = 'INACTIVE'


SELECT authID, usertype FROM dbo._AuthUserDir WHERE username = 'mogus'