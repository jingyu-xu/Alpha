CREATE TABLE [dbo].[AuditTypes] (
    [AuditTypeId] INT           NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_AuditTypes] PRIMARY KEY CLUSTERED ([AuditTypeId] ASC)
);

