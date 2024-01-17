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
CREATE PROCEDURE [dbo].[SP_AddEntry] 
	-- Add the parameters for the stored procedure here
	@XX_id VARCHAR(256),
	@XX_fname VARCHAR(64),
	@XX_mname VARCHAR(32),
	@XX_lname VARCHAR(64),
	@XX_age INT,
	@XX_bdate VARCHAR(12),
	@XX_gender VARCHAR(16),
	@XX_address VARCHAR(128),
	@XX_cno VARCHAR(64),
	@XX_email VARCHAR(64),
	@XX_edubg VARCHAR(128),
	@XX_course VARCHAR(256),
	@XX_source VARCHAR(128),
	@XX_appdate VARCHAR(32),
	@XX_priority_e VARCHAR(64),
	@XX_others_e VARCHAR(256),
	@XX_mo_e VARCHAR(128),
	@XX_exp_months INT,
	@XX_accmngr VARCHAR(64),
	@XX_accstatus VARCHAR(256),
	@XX_start_date VARCHAR(32),
	@XX_status VARCHAR(8)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO _ApplicantEntry
	VALUES (@XX_appdate, @XX_id, @XX_fname, @XX_mname, @XX_lname, @XX_age, @XX_bdate, @XX_gender, @XX_address, @XX_cno, @XX_email,
	@XX_edubg, @XX_course, @XX_source, @XX_priority_e, @XX_others_e, @XX_mo_e, @XX_exp_months, @XX_accmngr,
	@XX_accstatus,	@XX_start_date, 'ACTIVE')
END
GO
