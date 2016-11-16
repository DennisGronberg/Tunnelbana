CREATE TABLE [dbo].[Barriers] (
    [BarrierID]   INT            IDENTITY (1, 1) NOT NULL,
    [BarrierName] NVARCHAR (MAX) NULL,
    [Exit_ExitID] INT            NULL,
    CONSTRAINT [PK_dbo.Barriers] PRIMARY KEY CLUSTERED ([BarrierID] ASC),
    CONSTRAINT [FK_dbo.Barriers_dbo.Exits_Exit_ExitID] FOREIGN KEY ([Exit_ExitID]) REFERENCES [dbo].[Exits] ([ExitID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Exit_ExitID]
    ON [dbo].[Barriers]([Exit_ExitID] ASC);

