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
CREATE PROCEDURE [dbo].[SP_Register]
	-- Add the parameters for the stored procedure here
	@rr_authID VARCHAR(256),
	@rr_name VARCHAR(160),
	@rr_username VARCHAR(64),
	@rr_password VARCHAR(512),
	@rr_type VARCHAR(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	INSERT INTO _AuthUserDir
	VALUES (@rr_authID, @rr_name, @rr_username, @rr_password, @rr_type)
END
GO
