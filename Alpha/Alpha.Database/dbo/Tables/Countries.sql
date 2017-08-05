CREATE TABLE [dbo].[Countries] (
    [CountryId]   INT           NOT NULL,
    [Description] VARCHAR (100) NOT NULL,
    [Abbreation]  VARCHAR (20)  NOT NULL,
    CONSTRAINT [PK_Countries] PRIMARY KEY CLUSTERED ([CountryId] ASC)
);

