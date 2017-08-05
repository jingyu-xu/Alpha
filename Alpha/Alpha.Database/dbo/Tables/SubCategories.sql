CREATE TABLE [dbo].[SubCategories] (
    [SubCategoryId] INT          NOT NULL,
    [CategoryId]    INT          NOT NULL,
    [Description]   VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_SubCategories] PRIMARY KEY CLUSTERED ([SubCategoryId] ASC),
    CONSTRAINT [FK_SubCategories_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([CategoryId])
);

