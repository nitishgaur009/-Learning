CREATE TABLE [dbo].[PatientHistories] (
    [PatientHistoryId] INT            IDENTITY (1, 1) NOT NULL,
    [PatientId]        INT            NOT NULL,
    [DoctorId]         INT            NOT NULL,
    [AppointmentDate]  DATETIME       NOT NULL,
    [Diagnosis]        NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.PatientHistories] PRIMARY KEY CLUSTERED ([PatientHistoryId] ASC),
    CONSTRAINT [FK_dbo.PatientHistories_dbo.Doctors_DoctorId] FOREIGN KEY ([DoctorId]) REFERENCES [dbo].[Doctors] ([DoctorId]) ON DELETE CASCADE,
    CONSTRAINT [FK_dbo.PatientHistories_dbo.Patients_PatientId] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[Patients] ([PatientId]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_PatientId]
    ON [dbo].[PatientHistories]([PatientId] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_DoctorId]
    ON [dbo].[PatientHistories]([DoctorId] ASC);

