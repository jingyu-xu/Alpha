CREATE TABLE [dbo].[Rates] (
    [RateId]         INT NOT NULL,
    [UserId]         INT NOT NULL,
    [CategoryItemId] INT NOT NULL,
    [Score]          INT NOT NULL,
    CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED ([RateId] ASC),
    CONSTRAINT [FK_Rates_CategoryItems] FOREIGN KEY ([CategoryItemId]) REFERENCES [dbo].[CategoryItems] ([CategoryItemId]),
    CONSTRAINT [FK_Rates_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

