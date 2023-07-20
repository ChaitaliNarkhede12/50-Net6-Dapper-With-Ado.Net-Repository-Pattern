USE [TCCS]
GO
/****** Object:  StoredProcedure [dbo].[UpdateEmployee]    Script Date: 20-07-2023 19:13:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[UpdateEmployee]
@Id INT,
@Name VARCHAR(30),
@Email VARCHAR(30)
AS
BEGIN
		UPDATE Employee 
		SET
			Name = @Name,
			EmailId = @Email
		WHERE id = @Id
END