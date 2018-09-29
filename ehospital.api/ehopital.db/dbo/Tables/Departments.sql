CREATE TABLE [dbo].[Departments] (
    [DepartmentId]   INT            IDENTITY (1, 1) NOT NULL,
    [DepartmentName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Departments] PRIMARY KEY CLUSTERED ([DepartmentId] ASC)
);

