/****** Object:  Database [ProbeData]    Script Date: 10/8/2020 3:07:14 PM ******/
CREATE DATABASE [ProbeData]  (EDITION = 'GeneralPurpose', SERVICE_OBJECTIVE = 'GP_Gen4_1', MAXSIZE = 5 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [ProbeData] SET COMPATIBILITY_LEVEL = 140
GO
ALTER DATABASE [ProbeData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProbeData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProbeData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProbeData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProbeData] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProbeData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProbeData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProbeData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProbeData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProbeData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProbeData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProbeData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProbeData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProbeData] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [ProbeData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProbeData] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [ProbeData] SET  MULTI_USER 
GO
ALTER DATABASE [ProbeData] SET ENCRYPTION ON
GO
ALTER DATABASE [ProbeData] SET QUERY_STORE = ON
GO
ALTER DATABASE [ProbeData] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/****** Object:  User [XCeleprobeApp]    Script Date: 10/8/2020 3:07:14 PM ******/
CREATE USER [XCeleprobeApp] FOR LOGIN [XCeleprobeApp] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [matt.meitl@xdisplay.com]    Script Date: 10/8/2020 3:07:14 PM ******/
CREATE USER [matt.meitl@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [erik.vick@xdisplay.com]    Script Date: 10/8/2020 3:07:14 PM ******/
CREATE USER [erik.vick@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [erich.radauscher@xdisplay.com]    Script Date: 10/8/2020 3:07:14 PM ******/
CREATE USER [erich.radauscher@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [chris.verreen@xdisplay.com]    Script Date: 10/8/2020 3:07:14 PM ******/
CREATE USER [chris.verreen@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [ODBC_Role]    Script Date: 10/8/2020 3:07:14 PM ******/
CREATE ROLE [ODBC_Role]
GO
/****** Object:  UserDefinedFunction [dbo].[DATETIMEOFFSET_EST]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:      Ed Hubbell
-- Create Date: 09/04/19
-- Description: Returns a DateTimeOffset value in the Eastern standard time timezone 
-- because we're in the US and the Azure database defaults to UTC and can't be changed.
-- =============================================
CREATE FUNCTION [dbo].[DATETIMEOFFSET_EST]()
RETURNS DATETIMEOFFSET
AS
BEGIN
    RETURN SYSDATETIMEOFFSET() AT TIME ZONE 'Eastern Standard Time'
END
GO
/****** Object:  Table [dbo].[TileProbeData]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TileProbeData](
	[ID] [bigint] IDENTITY(1,1) NOT NULL,
	[WaferID] [varchar](50) NULL,
	[TransactionTime] [datetimeoffset](7) NULL,
	[MeasurementTime] [datetimeoffset](7) NULL,
	[ProberID] [varchar](50) NULL,
	[ProberRecipe] [varchar](50) NULL,
	[CameraID] [varchar](50) NULL,
	[CameraRecipe] [varchar](50) NULL,
	[TileX] [int] NULL,
	[TileY] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_TileProbeData]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_TileProbeData] AS
SELECT *
FROM [dbo].[TileProbeData] WITH (NOLOCK)
GO
/****** Object:  Table [dbo].[TileProbeData_Details]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TileProbeData_Details](
	[ID] [bigint] NOT NULL,
	[DutX] [int] NOT NULL,
	[DutY] [int] NOT NULL,
	[Cx] [decimal](6, 5) NULL,
	[Cy] [decimal](6, 5) NULL,
	[DW] [decimal](6, 2) NULL,
	[Lum] [decimal](9, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC,
	[DutX] ASC,
	[DutY] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_TileProbeData_Details]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_TileProbeData_Details] AS
SELECT *
FROM [dbo].[TileProbeData_Details] WITH (NOLOCK)
GO
/****** Object:  Table [dbo].[XProbeTask_Log]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XProbeTask_Log](
	[LogID] [bigint] IDENTITY(1,1) NOT NULL,
	[TransactionTime] [datetimeoffset](7) NULL,
	[XMLInputParameters] [xml] NULL,
	[XMLOutputParameters] [xml] NULL,
	[Duration_ms] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[LogID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_XProbeTask_Log]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[vw_XProbeTask_Log] AS
SELECT *
FROM [dbo].[XProbeTask_Log] WITH (NOLOCK)
GO
/****** Object:  StoredProcedure [dbo].[XProbeTask]    Script Date: 10/8/2020 3:07:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROCEDURE [dbo].[XProbeTask] 
  @XMLInputParameters XML,
  @XMLOutputParameters XML OUTPUT, 
  @debug AS BIT = 0
AS

/*
Sample Exe Script:
--DECLARE @XMLInputParameters XML
--DECLARE @XMLOutputParameters XML
--SET @XMLInputParameters ='<XMLInputParameters><Task>Test</Task></XMLInputParameters>'

--EXEC [XProbeTask] @XMLInputParameters = @XMLInputParameters, @XMLOutputParameters = @XMLOutputParameters OUTPUT, @debug = 1

--SELECT  @XMLOutputParameters 

-- Permissions
GRANT EXECUTE ON [dbo].[XProbeTask] TO [XCeleprobeApp] AS [dbo]
 

-- Change History
Developer               Date                Changes
Ed Hubbell              2019/08/28          Created procedure.

*/


SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET NOCOUNT ON

DECLARE @LogID BIGINT
DECLARE @Task VARCHAR(100)
DECLARE @LotID VARCHAR(100)
DECLARE @ComputerName VARCHAR(100)
DECLARE @UserName VARCHAR(100)


DECLARE @ID BIGINT

DECLARE @StartDateTimeOffset DATETIMEOFFSET

BEGIN TRY

    IF @debug = 1 SELECT @XMLInputParameters

    SET @StartDateTimeOffset = dbo.DATETIMEOFFSET_EST()

	-- Log exe of the stored procedure.
	INSERT INTO XProbeTask_Log (TransactionTime) VALUES (@StartDateTimeOffset)   
	SET @LogID = @@IDENTITY 

	UPDATE XProbeTask_Log SET XMLInputParameters = @XMLInputParameters WHERE LogID = @LogID  

	-- Keep only the last 10K records.
	IF (SELECT COUNT(*) FROM XProbeTask_Log) > 11000
	  BEGIN
		DELETE FROM XProbeTask_Log WHERE LogID < @LogID - 10000 
	  END 

	SELECT @Task = ISNULL(DataRows.ID.value(N'(Task/text())[1]','VARCHAR(100)'), 'NotSentInXML'), 
      @ComputerName = ISNULL(DataRows.ID.value(N'(ComputerName/text())[1]','VARCHAR(100)'), 'NotSentInXML'),
      @UserName = ISNULL(DataRows.ID.value(N'(UserName/text())[1]','VARCHAR(100)'), 'NotSentInXML')
      FROM @XMLInputParameters.nodes('./XMLInputParameters') AS DataRows(ID)


	IF @Task = 'Test'
	  BEGIN
        -- Delay for 2 seconds.
        WAITFOR DELAY '00:00:02';

		SET @XMLOutputParameters = (
		  SELECT @Task AS Task, 'Success' AS Result
		  FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
	  END 

	IF @Task = 'ProgramLaunch'
	  BEGIN
		SET @XMLOutputParameters = (
		  SELECT @Task AS Task
		  FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
	  END 

	IF @Task = 'UpsertTileMeasurementXML'
	  BEGIN


        INSERT INTO TileProbeData
           ([WaferID]
           ,[TransactionTime]
           ,[MeasurementTime]
           ,[ProberID]
           ,[ProberRecipe]
           ,[CameraID]
           ,[CameraRecipe]
           ,[TileX]
           ,[TileY])
        SELECT 
            ISNULL(DataRows.ID.value(N'(@WaferID)[1]','VARCHAR(50)'), 'NotSentInXML'),
            dbo.DATETIMEOFFSET_EST(), 
            dbo.DATETIMEOFFSET_EST(), 
            ISNULL(DataRows.ID.value(N'(@ProberID)[1]','VARCHAR(50)'), 'NotSentInXML'),
            ISNULL(DataRows.ID.value(N'(@ProberRecipe)[1]','VARCHAR(50)'), 'NotSentInXML'),
            ISNULL(DataRows.ID.value(N'(@CameraID)[1]','VARCHAR(50)'), 'Radiant'),
            ISNULL(DataRows.ID.value(N'(@PatternSetupName)[1]','VARCHAR(50)'), 'NotSentInXML'),
            ISNULL(DataRows.ID.value(N'(@TileX)[1]','INT'), 0), 
            ISNULL(DataRows.ID.value(N'(@TileY)[1]','INT'), 0)
        FROM @XMLInputParameters.nodes('./XMLInputParameters/TileMeasurementXML') AS DataRows(ID)


        SET @ID = SCOPE_IDENTITY()

        INSERT INTO [dbo].[TileProbeData_Details]
           ([ID]
           ,[DutX]
           ,[DutY]
           ,[Cx]
           ,[Cy]
           ,[DW]
           ,[Lum])
        SELECT 
            @ID,
            ISNULL(DataRows.ID.value(N'(@DutX)[1]','INT'), -1),
            ISNULL(DataRows.ID.value(N'(@DutY)[1]','INT'), -1),
            ISNULL(DataRows.ID.value(N'(@Cx)[1]','FLOAT'), -1),
            ISNULL(DataRows.ID.value(N'(@Cy)[1]','FLOAT'), -1),
            ISNULL(DataRows.ID.value(N'(@DW)[1]','FLOAT'), -1),
            ISNULL(DataRows.ID.value(N'(@Lum)[1]','FLOAT'), -1)
        FROM @XMLInputParameters.nodes('./XMLInputParameters/TileMeasurementXML/DUTMeasurementsXML/DUTMeasurementXML') AS DataRows(ID)
        
        -- Note - Important that these are set to 'FLOAT' and not 'DECIMAL(6,5)' or what have you. The DECIMAL conversion will fail when 
        -- it encounters numbers like Cy="3.7064073694637045E-05". The XML parse of FLOAT will work, and the table insert will auto move 
        -- the float values into decimal. 


		SET @XMLOutputParameters = (
		  SELECT @Task AS Task
		  FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
	  END 


	UPDATE XProbeTask_Log 
        SET XMLOutputParameters = @XMLOutputParameters,
        Duration_ms = DATEDIFF(ms, @StartDateTimeOffset, dbo.DATETIMEOFFSET_EST())
        WHERE LogID = @LogID

	RETURN

END TRY

BEGIN CATCH

    DECLARE @CErrMsg VARCHAR(MAX) 
    DECLARE @CErrNum INT 
    DECLARE @CErrSeverity INT 
    DECLARE @CErrState INT
    DECLARE @CErrLine INT

    SELECT @CErrMsg = ERROR_MESSAGE(), 
        @CErrNum = ERROR_NUMBER(), 
        @CErrSeverity = ERROR_SEVERITY(), 
        @CErrState = ERROR_STATE(), 
        @CErrLine = ERROR_LINE()


    SET @CErrMsg = 'Proc: ' + OBJECT_NAME(@@ProcID) + ', Line: ' + CAST(@CErrLine as varchar(20)) + ', ErrNum: ' + CAST(@CErrNum as varchar(20)) + ' : '  + @CErrMsg

    SET @XMLOutputParameters = (
	    SELECT @CErrMsg AS CErrMsg, 'Error' AS Result
	    FOR XML RAW ('XMLOutputParameters'), ELEMENTS)

    RAISERROR(@CErrMsg, @CErrSeverity, @CErrState)

RETURN

END CATCH
GO
ALTER DATABASE [ProbeData] SET  READ_WRITE 
GO
