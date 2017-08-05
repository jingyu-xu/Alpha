CREATE TABLE [dbo].[CategoryItems] (
    [CategoryItemId] INT            NOT NULL,
    [SubCategoryId]  INT            NOT NULL,
    [Title]          VARCHAR (500)  NOT NULL,
    [Question]       VARCHAR (2000) NOT NULL,
    [Answer]         VARCHAR (MAX)  NOT NULL,
    [VisitedCount]   INT            CONSTRAINT [DF_CategoryItems_VisitCount] DEFAULT ((0)) NOT NULL,
    [DateCreated]    DATETIME       NOT NULL,
    CONSTRAINT [PK_CategoryItems] PRIMARY KEY CLUSTERED ([CategoryItemId] ASC),
    CONSTRAINT [FK_CategoryItems_CategoryItems] FOREIGN KEY ([SubCategoryId]) REFERENCES [dbo].[SubCategories] ([SubCategoryId])
);

