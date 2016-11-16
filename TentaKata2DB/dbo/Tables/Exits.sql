CREATE TABLE [dbo].[Exits] (
    [ExitID]            INT            IDENTITY (1, 1) NOT NULL,
    [ExitName]          NVARCHAR (MAX) NULL,
    [Station_StationID] INT            NULL,
    CONSTRAINT [PK_dbo.Exits] PRIMARY KEY CLUSTERED ([ExitID] ASC),
    CONSTRAINT [FK_dbo.Exits_dbo.Stations_Station_StationID] FOREIGN KEY ([Station_StationID]) REFERENCES [dbo].[Stations] ([StationID])
);


GO
CREATE NONCLUSTERED INDEX [IX_Station_StationID]
    ON [dbo].[Exits]([Station_StationID] ASC);

