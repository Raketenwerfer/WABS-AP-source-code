-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
USE WABS_DIRECTORY

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UpdateEntry] 
	-- Add the parameters for the stored procedure here
	@eX_id VARCHAR(256),
	@eX_fname VARCHAR(64),
	@eX_mname VARCHAR(32),
	@eX_lname VARCHAR(64),
	@eX_age INT,
	@eX_bdate VARCHAR(12),
	@eX_gender VARCHAR(16),
	@eX_address VARCHAR(128),
	@eX_cno VARCHAR(64),
	@eX_email VARCHAR(64),
	@eX_edubg VARCHAR(128),
	@eX_course VARCHAR(256),
	@eX_source VARCHAR(128),
	@eX_appdate VARCHAR(32),
	@eX_priority_e VARCHAR(64),
	@eX_others_e VARCHAR(256),
	@eX_mo_e VARCHAR(128),
	@eX_exp_months INT,
	@eX_accmngr VARCHAR(64),
	@eX_accstatus VARCHAR(256),
	@eX_start_date VARCHAR(32),
	@eX_status VARCHAR(8)

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here

	UPDATE _ApplicantEntry
	SET  _ApplicantEntry.fname = @eX_fname, _ApplicantEntry.mname = @eX_mname,
			_ApplicantEntry.lname = @eX_lname, _ApplicantEntry.age = @eX_age, _ApplicantEntry.bdate = @eX_bdate,
			_ApplicantEntry.gender = @eX_gender, _ApplicantEntry.[address] = @eX_address,
			_ApplicantEntry.cno = @eX_cno, _ApplicantEntry.email = @eX_email,  _ApplicantEntry.educational_background = @eX_edubg,
			_ApplicantEntry.course = @eX_course, _ApplicantEntry.[source] = @eX_source, _ApplicantEntry.appdate = @eX_appdate,
			_ApplicantEntry.priority_endorsement = @eX_priority_e, _ApplicantEntry.other_endorsements = @eX_others_e,
			_ApplicantEntry.mode_of_endorsements = @eX_mo_e, _ApplicantEntry.exp_months = @eX_exp_months,
			_ApplicantEntry.account_manager = @eX_accmngr, _ApplicantEntry.account_status = @eX_accstatus,
			_ApplicantEntry.[start_date] = @eX_start_date, _ApplicantEntry.[status] = 'ACTIVE'
	WHERE _ApplicantEntry.id = @eX_id



END
GO
