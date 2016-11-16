CREATE TABLE [dbo].[Lines] (
    [LineID]   INT            IDENTITY (1, 1) NOT NULL,
    [LineName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Lines] PRIMARY KEY CLUSTERED ([LineID] ASC)
);

