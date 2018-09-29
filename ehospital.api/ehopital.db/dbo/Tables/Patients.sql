CREATE TABLE [dbo].[Patients] (
    [PatientId]    INT            IDENTITY (1, 1) NOT NULL,
    [Name]         NVARCHAR (MAX) NULL,
    [Address]      NVARCHAR (MAX) NULL,
    [MobileNumber] INT            NOT NULL,
    CONSTRAINT [PK_dbo.Patients] PRIMARY KEY CLUSTERED ([PatientId] ASC)
);

