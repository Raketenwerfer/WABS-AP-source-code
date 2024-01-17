--CREATE DATABASE WABS_DIRECTORY

--CREATE TABLE _AuthUserDir
--(
--	authID VARCHAR(256) PRIMARY KEY,
--	[name] VARCHAR(160),
--	username VARCHAR(64),
--	_password VARCHAR(512),
--	usertype VARCHAR(6)
--)

--CREATE TABLE _ApplicantEntry
--(
--	appdate VARCHAR(32),
--	id VARCHAR(256) PRIMARY KEY,
--	fname VARCHAR(64),
--	mname VARCHAR(32),
--	lname VARCHAR(64),
--	age INT,
--	bdate VARCHAR(12),
--	gender VARCHAR(16),
--	[address] VARCHAR(128),
--	cno VARCHAR(64),
--	email VARCHAR(64),
--	educational_background VARCHAR(128),
--	course VARCHAR(256),
--	[source] VARCHAR(128),
--	priority_endorsement VARCHAR(64),
--	other_endorsements VARCHAR(256),
--	mode_of_endorsements VARCHAR(128),
--	exp_months INT,
--	account_manager VARCHAR(64),
--	account_status VARCHAR(256),
--	[start_date] VARCHAR(32),
--	[status] VARCHAR(8)
--)

--DROP TABLE _AuthUserDir;
--DROP TABLE _ApplicantEntry;


---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_UpdateAcc]
--	-- Add the parameters for the stored procedure here
--	@ea_authID VARCHAR(256),
--	@ea_name VARCHAR(160),
--	@ea_username VARCHAR(64),
--	@ea_password VARCHAR(512),
--	@ea_type VARCHAR(6)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	UPDATE _AuthUserDir
--	SET _AuthUserDir.[name] = @ea_name, _AuthUserDir.username = @ea_username, _AuthUserDir._password = @ea_password,
--		_AuthUserDir.usertype = @ea_type
--	WHERE @ea_authID = _AuthUserDir.authID
--END
--GO


----------------------------------


--	-- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[authKeys] 
--	-- Add the parameters for the stored procedure here
--	@chk_U VARCHAR(160),
--	@chk_P VARCHAR(512)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	SELECT authID, usertype FROM _AuthUserDir WHERE username = @chk_U AND _password = @chk_P
--	RETURN
--END
--GO


--------------------------------------

---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================
--USE WABS_DIRECTORY

--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_UpdateEntry] 
--	-- Add the parameters for the stored procedure here
--	@eX_id VARCHAR(256),
--	@eX_fname VARCHAR(64),
--	@eX_mname VARCHAR(32),
--	@eX_lname VARCHAR(64),
--	@eX_age INT,
--	@eX_bdate VARCHAR(12),
--	@eX_gender VARCHAR(16),
--	@eX_address VARCHAR(128),
--	@eX_cno VARCHAR(64),
--	@eX_email VARCHAR(64),
--	@eX_edubg VARCHAR(128),
--	@eX_course VARCHAR(256),
--	@eX_source VARCHAR(128),
--	@eX_appdate VARCHAR(32),
--	@eX_priority_e VARCHAR(64),
--	@eX_others_e VARCHAR(256),
--	@eX_mo_e VARCHAR(128),
--	@eX_exp_months INT,
--	@eX_accmngr VARCHAR(64),
--	@eX_accstatus VARCHAR(256),
--	@eX_start_date VARCHAR(32),
--	@eX_status VARCHAR(8)

--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here

--	UPDATE _ApplicantEntry
--	SET  _ApplicantEntry.fname = @eX_fname, _ApplicantEntry.mname = @eX_mname,
--			_ApplicantEntry.lname = @eX_lname, _ApplicantEntry.age = @eX_age, _ApplicantEntry.bdate = @eX_bdate,
--			_ApplicantEntry.gender = @eX_gender, _ApplicantEntry.[address] = @eX_address,
--			_ApplicantEntry.cno = @eX_cno, _ApplicantEntry.email = @eX_email,  _ApplicantEntry.educational_background = @eX_edubg,
--			_ApplicantEntry.course = @eX_course, _ApplicantEntry.[source] = @eX_source, _ApplicantEntry.appdate = @eX_appdate,
--			_ApplicantEntry.priority_endorsement = @eX_priority_e, _ApplicantEntry.other_endorsements = @eX_others_e,
--			_ApplicantEntry.mode_of_endorsements = @eX_mo_e, _ApplicantEntry.exp_months = @eX_exp_months,
--			_ApplicantEntry.account_manager = @eX_accmngr, _ApplicantEntry.account_status = @eX_accstatus,
--			_ApplicantEntry.[start_date] = @eX_start_date, _ApplicantEntry.[status] = 'ACTIVE'
--	WHERE _ApplicantEntry.id = @eX_id



--END
--GO

---------------------------------------------------------

---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================

--USE WABS_DIRECTORY

--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_StatusHandler]
--	-- Add the parameters for the stored procedure here
--	@rx_id VARCHAR(256),
--	@rx_status VARCHAR(8)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	UPDATE _ApplicantEntry
--	SET _ApplicantEntry.[status] = @rx_status
--	WHERE @rx_id = _ApplicantEntry.id
--END
--GO


-------------------------------------------------------------

---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================
--USE WABS_DIRECTORY
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_Register]
--	-- Add the parameters for the stored procedure here
--	@rr_authID VARCHAR(256),
--	@rr_name VARCHAR(160),
--	@rr_username VARCHAR(64),
--	@rr_password VARCHAR(512),
--	@rr_type VARCHAR(6)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	INSERT INTO _AuthUserDir
--	VALUES (@rr_authID, @rr_name, @rr_username, @rr_password, @rr_type)
--END
--GO


--------------------------------------------------

---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================
--USE WABS_DIRECTORY
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_Query]
--	-- Add the parameters for the stored procedure here
	
--	@II_column VARCHAR(32),
--	@II_queryitem VARCHAR(256)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	SELECT * FROM _ApplicantEntry
--	WHERE @II_column LIKE '@II_queryitem%'

--END
--GO

---------------------------------------

---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_DeleteEntry]
--	-- Add the parameters for the stored procedure here
--	@DE_id VARCHAR(256)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	DELETE FROM _ApplicantEntry WHERE _ApplicantEntry.id = @DE_id
--END
--GO


---------------------------------------------

---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================
--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_DeleteAcc]
--	-- Add the parameters for the stored procedure here
--	@ea_authID VARCHAR(256)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	DELETE FROM _AuthUserDir WHERE _AuthUserDir.authID = @ea_authID
--END
--GO


------------------------------------------------

---- ================================================
---- Template generated from Template Explorer using:
---- Create Procedure (New Menu).SQL
----
---- Use the Specify Values for Template Parameters 
---- command (Ctrl-Shift-M) to fill in the parameter 
---- values below.
----
---- This block of comments will not be included in
---- the definition of the procedure.
---- ================================================

--USE WABS_DIRECTORY


--SET ANSI_NULLS ON
--GO
--SET QUOTED_IDENTIFIER ON
--GO
---- =============================================
---- Author:		<Author,,Name>
---- Create date: <Create Date,,>
---- Description:	<Description,,>
---- =============================================
--CREATE PROCEDURE [dbo].[SP_AddEntry] 
--	-- Add the parameters for the stored procedure here
--	@XX_id VARCHAR(256),
--	@XX_fname VARCHAR(64),
--	@XX_mname VARCHAR(32),
--	@XX_lname VARCHAR(64),
--	@XX_age INT,
--	@XX_bdate VARCHAR(12),
--	@XX_gender VARCHAR(16),
--	@XX_address VARCHAR(128),
--	@XX_cno VARCHAR(64),
--	@XX_email VARCHAR(64),
--	@XX_edubg VARCHAR(128),
--	@XX_course VARCHAR(256),
--	@XX_source VARCHAR(128),
--	@XX_appdate VARCHAR(32),
--	@XX_priority_e VARCHAR(64),
--	@XX_others_e VARCHAR(256),
--	@XX_mo_e VARCHAR(128),
--	@XX_exp_months INT,
--	@XX_accmngr VARCHAR(64),
--	@XX_accstatus VARCHAR(256),
--	@XX_start_date VARCHAR(32),
--	@XX_status VARCHAR(8)
--AS
--BEGIN
--	-- SET NOCOUNT ON added to prevent extra result sets from
--	-- interfering with SELECT statements.
--	SET NOCOUNT ON;

--    -- Insert statements for procedure here
--	INSERT INTO _ApplicantEntry
--	VALUES (@XX_appdate, @XX_id, @XX_fname, @XX_mname, @XX_lname, @XX_age, @XX_bdate, @XX_gender, @XX_address, @XX_cno, @XX_email,
--	@XX_edubg, @XX_course, @XX_source, @XX_priority_e, @XX_others_e, @XX_mo_e, @XX_exp_months, @XX_accmngr,
--	@XX_accstatus,	@XX_start_date, 'ACTIVE')
--END
--GO




	SELECT * FROM _ApplicantEntry WHERE = 23

		SELECT * FROM _ApplicantEntry
	WHERE _ApplicantEntry.mname LIKE 'L43'

SELECT * FROM _ApplicantEntry WHERE [status] = 'ACTIVE' AND gender = 'Female'


INSERT INTO _AuthUserDir
VALUES ('222', 'Walter Hartwell White', 'Admin', 'C1C224B03CD9BC7B6A86D77F5DACE40191766C485CD55DC48CAF9AC873335D6F', 'ADMIN')


--- Check for users and debug authentication measures
SELECT authID, usertype FROM _AuthUserDir WHERE username = 'Admin' AND name = 'Administrator'

SELECT * FROM _AuthUSerDir


UPDATE _AuthUserDir
SET usertype = 'ADMIN'
WHERE [username] = 'waltuh'


UPDATE _ApplicantEntry
SET [status] = 'ACTIVE'
WHERE [status] = 'INACTIVE'


SELECT authID, usertype FROM dbo._AuthUserDir WHERE username = 'mogus'

DELETE FROM _AuthUserDir 



