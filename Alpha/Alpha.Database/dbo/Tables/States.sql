CREATE TABLE [dbo].[States] (
    [StateId]     INT           NOT NULL,
    [CountryId]   INT           NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    [Abbreation]  VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_States] PRIMARY KEY CLUSTERED ([StateId] ASC),
    CONSTRAINT [FK_States_Countries] FOREIGN KEY ([CountryId]) REFERENCES [dbo].[Countries] ([CountryId])
);

