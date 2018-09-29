CREATE TABLE [dbo].[Doctors] (
    [DoctorId]      INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (MAX) NULL,
    [Qualification] NVARCHAR (MAX) NULL,
    [DepartmentId]  INT            NOT NULL,
    CONSTRAINT [PK_dbo.Doctors] PRIMARY KEY CLUSTERED ([DoctorId] ASC),
    CONSTRAINT [FK_dbo.Doctors_dbo.Departments_DepartmentId] FOREIGN KEY ([DepartmentId]) REFERENCES [dbo].[Departments] ([DepartmentId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_DepartmentId]
    ON [dbo].[Doctors]([DepartmentId] ASC);

