CREATE TABLE [dbo].[Course] (
	[CorseId] [INT] IDENTITY(1,1) NOT NULL CONSTRAINT PK_Course PRIMARY KEY,
	[NameCourse] [nvarchar](256) NOT NULL,
	[InstructorId] [INT] NOT NULL,
	FOREIGN KEY(InstructorId) REFERENCES Instructor(InstructorId)
	ON UPDATE CASCADE
	ON DELETE CASCADE
	)
GO

CREATE TABLE [dbo].[Occupation] (
	[OccupationId] [INT] IDENTITY(1,1) NOT NULL CONSTRAINT PK_Occupation PRIMARY KEY,
	[NameOccupation] [nvarchar](256) NOT NULL,
	[CorseId] [INT] NOT NULL,
	FOREIGN KEY(CorseId) REFERENCES [Course](CorseId)
	ON UPDATE CASCADE
	ON DELETE CASCADE
	)
GO

CREATE TABLE [dbo].[Group] (
	[GroupId] [INT] IDENTITY(1,1) NOT NULL CONSTRAINT PK_Group PRIMARY KEY,
	[NameGroup] [nvarchar](256) NOT NULL
	)
GO

CREATE TABLE [dbo].[Group_Occupation] (
	[GroupId] [INT] NOT NULL,
	[OccupationId] [INT] NOT NULL,
	FOREIGN KEY(GroupId) REFERENCES [Group](GroupId)
	ON UPDATE CASCADE
	ON DELETE CASCADE,
	FOREIGN KEY(OccupationId) REFERENCES [Occupation](OccupationId)
	ON UPDATE CASCADE
	ON DELETE CASCADE
	)
GO

CREATE TABLE [dbo].[Student] (
	[StudentId] [INT] IDENTITY(1,1) NOT NULL CONSTRAINT PK_Student PRIMARY KEY,
	[NameStudent] [nvarchar](256) NOT NULL,
	[Age] [INT] NOT NULL,
	[GroupId] [INT] NOT NULL,
	FOREIGN KEY(GroupId) REFERENCES [Group](GroupId)
	ON UPDATE CASCADE
	ON DELETE CASCADE,
	)
GO

CREATE TABLE [dbo].[Instructor] (
	[InstructorId] [INT] IDENTITY(1,1) NOT NULL CONSTRAINT PK_Instructor PRIMARY KEY,
	[NameInstructor] [nvarchar](256) NOT NULL,
	[ChairId] [INT] NOT NULL,
	FOREIGN KEY(ChairId) REFERENCES [Chair](ChairId)
	ON UPDATE CASCADE
	ON DELETE CASCADE
	)
GO

CREATE TABLE [dbo].[Chair] (
	[ChairId] [INT] IDENTITY(1,1) NOT NULL CONSTRAINT PK_Chair PRIMARY KEY,
	[NameChair] [nvarchar](256) NOT NULL
	)
GO