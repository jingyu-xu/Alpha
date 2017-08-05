CREATE TABLE [dbo].[Users] (
    [UserId]       INT           IDENTITY (1, 1) NOT NULL,
    [Email]        VARCHAR (200) NOT NULL,
    [UserName]     VARCHAR (50)  NOT NULL,
    [Password]     BINARY (64)   NOT NULL,
    [PasswordSalt] INT           NOT NULL,
    [Confirmation] BIT           CONSTRAINT [DF_Users_Confirmation] DEFAULT ((0)) NOT NULL,
    [CreatedDate]  DATETIME      NOT NULL,
    [UserTypeId]   INT           NOT NULL,
    [AgeRangeId]   INT           NOT NULL,
    [TitleId]      INT           NOT NULL,
    [GenderId]     INT           NOT NULL,
    [City]         VARCHAR (50)  NULL,
    [StateId]      INT           NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_Users_AgeRanges] FOREIGN KEY ([AgeRangeId]) REFERENCES [dbo].[AgeRanges] ([AgeRangeId]),
    CONSTRAINT [FK_Users_Genders] FOREIGN KEY ([GenderId]) REFERENCES [dbo].[Genders] ([GenderId]),
    CONSTRAINT [FK_Users_States] FOREIGN KEY ([StateId]) REFERENCES [dbo].[States] ([StateId]),
    CONSTRAINT [FK_Users_Titles] FOREIGN KEY ([TitleId]) REFERENCES [dbo].[Titles] ([TitleId]),
    CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY ([UserTypeId]) REFERENCES [dbo].[UserTypes] ([UserTypeId])
);

