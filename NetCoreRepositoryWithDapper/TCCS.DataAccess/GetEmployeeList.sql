USE [TCCS]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeList]    Script Date: 20-07-2023 19:10:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[GetEmployeeList]
AS
BEGIN
SELECT * FROM Employee
END