IF NOT EXISTS (SELECT * FROM sys.tables WHERE object_id = OBJECT_ID(N'[dbo].[tblStudents]'))
EXEC dbo.sp_executesql @statement = N'
CREATE TABLE [dbo].[tblStudents](
	[Id] [int] IDENTITY PRIMARY KEY NOT NULL,
	[GroupId] [int] NOT NULL,
	[Name] [nvarchar](150) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	CONSTRAINT [FK_tblStudets_tblGrpups] FOREIGN KEY([GroupId])
		REFERENCES [dbo].[tblGroups] ([Id]),
);'