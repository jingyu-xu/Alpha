CREATE TABLE [dbo].[QuestionContentVotes] (
    [QuestionContentVoteId] INT IDENTITY (1, 1) NOT NULL,
    [QuestionContentId]     INT NOT NULL,
    [UserId]                INT NULL,
    [Score]                 INT NOT NULL,
    CONSTRAINT [PK_QuestionContentVotes] PRIMARY KEY CLUSTERED ([QuestionContentVoteId] ASC),
    CONSTRAINT [FK_QuestionContentVotes_QuestionContents] FOREIGN KEY ([QuestionContentId]) REFERENCES [dbo].[QuestionContents] ([QuestionContentId]),
    CONSTRAINT [FK_QuestionContentVotes_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

