CREATE PROCEDURE dbo.InsertToll
   (@LineName nvarchar(MAX),
	@StationName nvarchar(MAX),
	@ExitName nvarchar(MAX),
	@BarrierName nvarchar(MAX))
AS 

IF NOT EXISTS (SELECT l.LineID FROM dbo.Lines l WHERE l.LineName = @LineName)
  INSERT INTO dbo.Lines (LineName)
  VALUES (@LineName)
DECLARE @LineID nvarchar(50)
SELECT @LineID = l.LineID FROM dbo.Lines l WHERE l.LineName=@LineName

IF NOT EXISTS (SELECT s.StationID FROM dbo.Stations s WHERE s.StationName=@StationName AND s.Line_LineID=@LineID)
  INSERT INTO dbo.Stations (StationName,Line_LineID)
  VALUES (@StationName, @LineID)
DECLARE @StationID nvarchar(50)
SELECT @StationID = s.StationID FROM dbo.Stations s WHERE s.StationName=@StationName AND s.Line_LineID=@LineID

IF NOT EXISTS (SELECT e.ExitID FROM dbo.Exits e WHERE e.ExitName=@ExitName AND e.Station_StationID=@StationID)
  INSERT INTO dbo.Exits (ExitName,Station_StationID)
  VALUES (@ExitName, @StationID)
DECLARE @ExitID nvarchar(50)
SELECT @ExitID = e.ExitID FROM dbo.Exits e WHERE e.ExitName=@ExitName AND e.Station_StationID=@StationID

IF NOT EXISTS (SELECT b.BarrierID FROM dbo.Barriers b WHERE b.BarrierName=@BarrierName AND b.Exit_ExitID=@ExitID)
  INSERT INTO dbo.Barriers (BarrierName,Exit_ExitID)
  VALUES (@BarrierName, @ExitID)
DECLARE @BarrierID nvarchar(50)
SELECT @BarrierID = b.BarrierID FROM dbo.Barriers b WHERE b.BarrierName=@BarrierName AND b.Exit_ExitID=@ExitID

PRINT ('Line ID: ' + @LineID)
PRINT ('Station ID: ' + @StationID)
PRINT ('Exit ID: ' + @ExitID)
PRINT ('Barrier ID: ' + @BarrierID)