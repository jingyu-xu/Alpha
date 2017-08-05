CREATE TABLE [dbo].[Comments] (
    [CommentId]      INT            NOT NULL,
    [UserId]         INT            NOT NULL,
    [CategoryItemId] INT            NOT NULL,
    [CommentContent] VARCHAR (2000) NOT NULL,
    [DateCreated]    DATETIME       NOT NULL,
    CONSTRAINT [PK_Comments] PRIMARY KEY CLUSTERED ([CommentId] ASC),
    CONSTRAINT [FK_Comments_CategoryItems] FOREIGN KEY ([CategoryItemId]) REFERENCES [dbo].[CategoryItems] ([CategoryItemId]),
    CONSTRAINT [FK_Comments_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

