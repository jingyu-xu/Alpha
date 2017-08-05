CREATE TABLE [dbo].[AuditLogs] (
    [AuditId]     INT      NOT NULL,
    [UserId]      INT      NOT NULL,
    [CommentId]   INT      NULL,
    [AuditTypeId] INT      NOT NULL,
    [DateCreated] DATETIME NOT NULL,
    CONSTRAINT [PK_AuditLogs] PRIMARY KEY CLUSTERED ([AuditId] ASC),
    CONSTRAINT [FK_AuditLogs_AuditTypes] FOREIGN KEY ([AuditTypeId]) REFERENCES [dbo].[AuditTypes] ([AuditTypeId]),
    CONSTRAINT [FK_AuditLogs_Comments] FOREIGN KEY ([CommentId]) REFERENCES [dbo].[Comments] ([CommentId]),
    CONSTRAINT [FK_AuditLogs_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

