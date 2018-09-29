CREATE TABLE [dbo].[UserLoginDatas] (
    [Id]           INT            IDENTITY (1, 1) NOT NULL,
    [Username]     NVARCHAR (MAX) NULL,
    [Password]     NVARCHAR (MAX) NULL,
    [RegisteredOn] DATETIME       NOT NULL,
    CONSTRAINT [PK_dbo.UserLoginDatas] PRIMARY KEY CLUSTERED ([Id] ASC)
);

