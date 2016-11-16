CREATE TABLE [dbo].[Stations] (
    [StationID]   INT            IDENTITY (1, 1) NOT NULL,
    [StationName] NVARCHAR (MAX) NULL,
    [Line_LineID] INT            NULL,
    CONSTRAINT [PK_dbo.Stations] PRIMARY KEY CLUSTERED ([StationID] ASC),
    CONSTRAINT [FK_dbo.Stations_dbo.Lines_Line_LineID] FOREIGN KEY ([Line_LineID]) REFERENCES [dbo].[Lines] ([LineID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Line_LineID]
    ON [dbo].[Stations]([Line_LineID] ASC);

