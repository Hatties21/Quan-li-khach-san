CREATE TABLE [dbo].[user_table] (
    [user_id]   INT          IDENTITY (1, 1) NOT NULL,
    [username]  VARCHAR (50) NOT NULL,
    [password]  VARCHAR (50) NOT NULL,
    [user_role] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([user_id] ASC)
);

