CREATE TABLE [dbo].[UserTypes] (
    [UserTypeId]  INT          NOT NULL,
    [Description] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED ([UserTypeId] ASC)
);

