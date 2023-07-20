USE [TCCS]
GO
/****** Object:  StoredProcedure [dbo].[DeleteEmployee]    Script Date: 20-07-2023 19:12:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteEmployee]
@Id INT
AS
BEGIN
		DELETE FROM Employee
		WHERE id = @Id
END