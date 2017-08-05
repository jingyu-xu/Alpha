CREATE TABLE [dbo].[DebugLogs] (
    [DebugLogId] INT           NOT NULL,
    [UserId]     INT           NULL,
    [MethodName] VARCHAR (200) NULL,
    [Request]    VARCHAR (MAX) NULL,
    [Exception]  VARCHAR (MAX) NOT NULL,
    [Response]   VARCHAR (MAX) NULL,
    CONSTRAINT [PK_DebugLogs] PRIMARY KEY CLUSTERED ([DebugLogId] ASC),
    CONSTRAINT [FK_DebugLogs_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

