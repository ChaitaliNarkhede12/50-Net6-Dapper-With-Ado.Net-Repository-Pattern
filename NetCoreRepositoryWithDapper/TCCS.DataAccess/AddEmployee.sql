USE [TCCS]
GO
/****** Object:  StoredProcedure [dbo].[AddEmployee]    Script Date: 20-07-2023 19:12:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[AddEmployee]
@Name VARCHAR(30),
@Email VARCHAR(30)
AS
BEGIN
		INSERT INTO Employee VALUES(@Name,@Email);
END