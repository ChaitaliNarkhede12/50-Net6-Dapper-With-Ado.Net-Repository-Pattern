USE [TCCS]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeById]    Script Date: 20-07-2023 19:11:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetEmployeeById]
@Id INT
AS
BEGIN
SELECT * FROM Employee WHERE Id = @Id
END