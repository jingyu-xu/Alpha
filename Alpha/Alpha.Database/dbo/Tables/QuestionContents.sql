CREATE TABLE [dbo].[QuestionContents] (
    [QuestionContentId] INT           IDENTITY (1, 1) NOT NULL,
    [SubCategoryId]     INT           NOT NULL,
    [QuestionTiltle]    VARCHAR (500) NOT NULL,
    [DateCreated]       DATE          NOT NULL,
    [Answer]            VARCHAR (MAX) NOT NULL,
    [QuestionDetail]    VARCHAR (MAX) NOT NULL,
    CONSTRAINT [PK_QuestionContents] PRIMARY KEY CLUSTERED ([QuestionContentId] ASC),
    CONSTRAINT [FK_QuestionContents_SubCategories] FOREIGN KEY ([SubCategoryId]) REFERENCES [dbo].[SubCategories] ([SubCategoryId])
);

