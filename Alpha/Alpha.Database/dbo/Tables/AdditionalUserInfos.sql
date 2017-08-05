CREATE TABLE [dbo].[AdditionalUserInfos] (
    [UserId] INT NOT NULL,
    CONSTRAINT [PK_AdditionalUserInfos] PRIMARY KEY CLUSTERED ([UserId] ASC),
    CONSTRAINT [FK_AdditionalUserInfos_Users] FOREIGN KEY ([UserId]) REFERENCES [dbo].[Users] ([UserId])
);

