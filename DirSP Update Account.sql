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
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[SP_UpdateAcc]
	-- Add the parameters for the stored procedure here
	@ea_authID VARCHAR(256),
	@ea_name VARCHAR(160),
	@ea_username VARCHAR(64),
	@ea_password VARCHAR(512),
	@ea_type VARCHAR(6)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE _AuthUserDir
	SET _AuthUserDir.[name] = @ea_name, _AuthUserDir.username = @ea_username, _AuthUserDir._password = @ea_password,
		_AuthUserDir.usertype = @ea_type
	WHERE @ea_authID = _AuthUserDir.authID
END
GO
