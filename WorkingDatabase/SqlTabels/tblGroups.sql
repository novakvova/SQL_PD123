IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblGroups]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[tblGroups](
	[Id] [int] IDENTITY PRIMARY KEY NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Specialty] [nvarchar](150) NULL,
);'