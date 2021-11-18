/****** Object:  Database [DisplayData]    Script Date: 10/8/2020 3:06:13 PM ******/
CREATE DATABASE [DisplayData]  (EDITION = 'GeneralPurpose', SERVICE_OBJECTIVE = 'GP_Gen4_1', MAXSIZE = 32 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [DisplayData] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [DisplayData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DisplayData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DisplayData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DisplayData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DisplayData] SET ARITHABORT OFF 
GO
ALTER DATABASE [DisplayData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DisplayData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DisplayData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DisplayData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DisplayData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DisplayData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DisplayData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DisplayData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DisplayData] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [DisplayData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DisplayData] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DisplayData] SET  MULTI_USER 
GO
ALTER DATABASE [DisplayData] SET ENCRYPTION ON
GO
ALTER DATABASE [DisplayData] SET QUERY_STORE = ON
GO
ALTER DATABASE [DisplayData] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 100, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/****** Object:  User [TNR_DB_User]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE USER [TNR_DB_User] FOR LOGIN [TNR_DB_User] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [matt.meitl@xdisplay.com]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE USER [matt.meitl@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [erik.vick@xdisplay.com]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE USER [erik.vick@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [erich.radauscher@xdisplay.com]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE USER [erich.radauscher@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [DisplayData_User]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE USER [DisplayData_User] FOR LOGIN [DisplayData_User] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [chris.verreen@xdisplay.com]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE USER [chris.verreen@xdisplay.com] FROM  EXTERNAL PROVIDER  WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  DatabaseRole [XDEngineerAdmin]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE ROLE [XDEngineerAdmin]
GO
/****** Object:  DatabaseRole [XDEngineer]    Script Date: 10/8/2020 3:06:14 PM ******/
CREATE ROLE [XDEngineer]
GO
sys.sp_addrolemember @rolename = N'db_owner', @membername = N'TNR_DB_User'
GO
sys.sp_addrolemember @rolename = N'XDEngineer', @membername = N'matt.meitl@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'db_datareader', @membername = N'matt.meitl@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'XDEngineer', @membername = N'erik.vick@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'db_datareader', @membername = N'erik.vick@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'XDEngineer', @membername = N'erich.radauscher@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'XDEngineerAdmin', @membername = N'erich.radauscher@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'db_datareader', @membername = N'erich.radauscher@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'XDEngineer', @membername = N'chris.verreen@xdisplay.com'
GO
sys.sp_addrolemember @rolename = N'db_datareader', @membername = N'chris.verreen@xdisplay.com'
GO
EXEC sys.sp_addrolemember @rolename = N'db_datareader', @membername = N'XDEngineerAdmin'
GO
EXEC sys.sp_addrolemember @rolename = N'db_datareader', @membername = N'XDEngineer'
GO
/****** Object:  UserDefinedFunction [dbo].[DATETIMEOFFSET_EST]    Script Date: 10/8/2020 3:06:16 PM ******/
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
/****** Object:  Table [dbo].[Defects]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Defects](
	[DefectID] [int] NOT NULL,
	[DefectName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisplayImages]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisplayImages](
	[DisplayNo] [nvarchar](50) NOT NULL,
	[ImageFilename] [nvarchar](255) NOT NULL,
	[ImageFolder] [nvarchar](255) NULL,
	[DisplayImageTypeID] [nvarchar](50) NULL,
	[UploadDateTime] [datetimeoffset](7) NULL,
	[UploadComputerName] [nvarchar](50) NULL,
	[UploadUserID] [nvarchar](50) NULL,
	[HideDateTime] [datetimeoffset](7) NULL,
	[HideComputerName] [nvarchar](50) NULL,
	[HideUserID] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[DisplayNo] ASC,
	[ImageFilename] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisplayImageTypes]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisplayImageTypes](
	[DisplayImageTypeID] [nvarchar](50) NOT NULL,
	[Comment] [nvarchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DisplayImageTypeID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisplayStatus]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisplayStatus](
	[ID] [int] NOT NULL,
	[DisplayNo] [int] NULL,
	[OperatorName] [nvarchar](max) NULL,
	[Operation] [int] NULL,
	[Day_In] [datetime] NULL,
	[Description] [nvarchar](max) NULL,
	[Day_Out] [datetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DisplayTask_Log]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisplayTask_Log](
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
/****** Object:  Table [dbo].[DisplayTypes]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DisplayTypes](
	[DisplayTypeID] [int] NOT NULL,
	[DisplayType] [nvarchar](255) NULL,
	[Colunns] [float] NULL,
	[Rows] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[DisplayTypeID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintCodes]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintCodes](
	[MaintCode] [int] NOT NULL,
	[MaintCodeDesc] [nvarchar](255) NULL,
	[Color] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaintCode] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MaintLog]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MaintLog](
	[MaintLogID] [bigint] IDENTITY(1,1) NOT NULL,
	[DisplayID] [int] NULL,
	[UserID] [nvarchar](255) NULL,
	[MaintCode] [int] NULL,
	[DateIn] [datetimeoffset](7) NULL,
	[MaintLogComment] [nvarchar](255) NULL,
	[DateOut] [datetimeoffset](7) NULL,
	[DisplayTypeID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaintLogID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationCodes]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationCodes](
	[OpID] [float] NULL,
	[Step] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operator]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operator](
	[OperatorID] [int] NOT NULL,
	[OperatorName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Operators]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Operators](
	[OperatorID] [int] NOT NULL,
	[OperatorName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RepairLog]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RepairLog](
	[RepairID] [bigint] IDENTITY(1,1) NOT NULL,
	[RepairDateTime] [datetime] NULL,
	[DisplayNo] [nvarchar](255) NULL,
	[Row] [float] NULL,
	[Col] [float] NULL,
	[DefectID] [float] NULL,
	[Comment] [nvarchar](255) NULL,
	[ImageAddr] [nvarchar](255) NULL,
	[SubPixel] [float] NULL,
	[PixelRemoved] [bit] NOT NULL,
	[DBAComment] [nvarchar](100) NULL,
	[BlobContainer] [nvarchar](255) NULL,
	[BlobFilename] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[RepairID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Resistance]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Resistance](
	[Display] [float] NULL,
	[VDD] [float] NULL,
	[VDD1] [float] NULL,
	[DCLK_R] [float] NULL,
	[PCLK_R] [float] NULL,
	[TOKEN] [float] NULL,
	[INCLK_C] [float] NULL,
	[DCLK_C] [float] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SubPixelTypes]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SubPixelTypes](
	[SubPixelTypeID] [int] NOT NULL,
	[TypeName] [nvarchar](255) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tools]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tools](
	[ToolID] [int] NOT NULL,
	[ToolName] [nvarchar](50) NULL,
	[Manufacturer] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[ToolID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [nvarchar](50) NOT NULL,
	[UserEmail] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MaintLog] ADD  CONSTRAINT [DF_MaintLog_DisplayTypeID]  DEFAULT ((0)) FOR [DisplayTypeID]
GO
/****** Object:  StoredProcedure [dbo].[DatabaseComments]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE PROCEDURE [dbo].[DatabaseComments] 
AS

/*


-- Change History
Developer               Date                Changes
Ed Hubbell              2020/06/25          Created procedure.

Finally, a way to store some documentation in SQL server. Hopefully I can find this when I need it. 

User setup: 

CREATE USER [erich.radauscher@xdisplay.com] 
FROM EXTERNAL PROVIDER 
WITH DEFAULT_SCHEMA = dbo;  

CREATE USER [chris.verreen@xdisplay.com] 
FROM EXTERNAL PROVIDER 
WITH DEFAULT_SCHEMA = dbo; 

CREATE USER [erik.vick@xdisplay.com] 
FROM EXTERNAL PROVIDER 
WITH DEFAULT_SCHEMA = dbo;

CREATE USER [matt.meitl@xdisplay.com] 
FROM EXTERNAL PROVIDER 
WITH DEFAULT_SCHEMA = dbo;  

grant select on 

exec sp_addrolemember 'db_datareader', 'erich.radauscher@xdisplay.com'


CREATE ROLE XDEngineer AUTHORIZATION db_owner
CREATE ROLE XDEngineerAdmin AUTHORIZATION db_owner

exec sp_addrolemember 'XDEngineer', 'erich.radauscher@xdisplay.com'
exec sp_addrolemember 'XDEngineer', 'chris.verreen@xdisplay.com'
exec sp_addrolemember 'XDEngineer', 'matt.meitl@xdisplay.com'
exec sp_addrolemember 'XDEngineer', 'erik.vick@xdisplay.com'

exec sp_addrolemember 'db_datareader', 'XDEngineer'

exec sp_addrolemember 'XDEngineerAdmin', 'erich.radauscher@xdisplay.com'

exec sp_addrolemember 'db_datareader', 'XDEngineerAdmin'

GRANT SELECT ON [dbo].[DisplayImageTypes] to XDEngineerAdmin
GRANT INSERT ON [dbo].[DisplayImageTypes] to XDEngineerAdmin
GRANT UPDATE ON [dbo].[DisplayImageTypes] to XDEngineerAdmin
GRANT DELETE ON [dbo].[DisplayImageTypes] to XDEngineerAdmin



*/


SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET NOCOUNT ON

RETURN


GO
/****** Object:  StoredProcedure [dbo].[DisplayTask]    Script Date: 10/8/2020 3:06:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO










CREATE PROCEDURE [dbo].[DisplayTask] 
 @XMLInputParameters XML,
 @XMLOutputParameters XML OUTPUT, 
 @debug AS BIT = 0
AS

/*
Sample Exe Script:
--DECLARE @XMLInputParameters XML
--DECLARE @XMLOutputParameters XML
--SET @XMLInputParameters ='<XMLInputParameters><Task>Test</Task></XMLInputParameters>'

--EXEC [DisplayTask] @XMLInputParameters = @XMLInputParameters, @XMLOutputParameters = @XMLOutputParameters OUTPUT, @debug = 1

--SELECT @XMLOutputParameters 

-- Permissions
GRANT EXECUTE ON [dbo].[DisplayTask] TO [DisplayData_User] AS [dbo]
 

-- Change History
Developer       Date            Changes
Ed Hubbell      2020/06/25      Created procedure around this time.
Ed Hubbell      2020/08/17      Started adding functions for XDisplayData application.

*/


SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED
SET NOCOUNT ON

DECLARE @LogID BIGINT
DECLARE @Task VARCHAR(100)
DECLARE @LotID VARCHAR(100)
DECLARE @ComputerName VARCHAR(100)
DECLARE @UserName VARCHAR(100)

DECLARE @DisplayNo VARCHAR(50)
DECLARE @ImageFilename VARCHAR(255)
DECLARE @DisplayID VARCHAR(50)

DECLARE @UserID NVARCHAR(50)
DECLARE @MaintCode INT
DECLARE @DisplayTypeID INT
DECLARE @MaintLogComment NVARCHAR(255)

DECLARE @ID BIGINT

DECLARE @StartDateTimeOffset DATETIMEOFFSET

DECLARE @DateIn DATETIMEOFFSET
DECLARE @DateOut DATETIMEOFFSET

DECLARE @RepairID BIGINT
DECLARE @BlobContainer NVARCHAR(255)
DECLARE @BlobFilename NVARCHAR(255)
DECLARE @DBAComment NVARCHAR(100)


BEGIN TRY

  IF @debug = 1 SELECT @XMLInputParameters

  SET @StartDateTimeOffset = dbo.DATETIMEOFFSET_EST()

  -- Log exe of the stored procedure.
  INSERT INTO DisplayTask_Log (TransactionTime) VALUES (@StartDateTimeOffset) 
  SET @LogID = @@IDENTITY 

  UPDATE DisplayTask_Log SET XMLInputParameters = @XMLInputParameters WHERE LogID = @LogID 

  -- Keep only the last 10K records.
  IF (SELECT COUNT(*) FROM DisplayTask_Log) > 11000
    BEGIN
      DELETE FROM DisplayTask_Log WHERE LogID < @LogID - 10000 
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
       SELECT @Task AS Task, 'DisplayTask_Test_Success' AS Result
       FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
    END 

  IF @Task = 'GetDisplayImageTypes'
    BEGIN
      SET @XMLOutputParameters = (
        SELECT 
        (SELECT DisplayImageTypeID, Comment FROM DisplayImageTypes 
        FOR XML RAW ('DisplayImageType'), ELEMENTS, TYPE) AS DisplayImageTypes
        FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
    END 

   IF @Task = 'InsertDisplayImage'
     BEGIN
 
       INSERT INTO DisplayImages ([DisplayNo],[ImageFilename],[ImageFolder],[DisplayImageTypeID],[UploadDateTime],[UploadComputerName],[UploadUserID])
         SELECT 
           ISNULL(DataRows.ID.value(N'(DisplayNo/text())[1]','VARCHAR(50)'), 'NotSentInXML'), 
           ISNULL(DataRows.ID.value(N'(ImageFilename/text())[1]','VARCHAR(255)'), 'NotSentInXML'), 
           ISNULL(DataRows.ID.value(N'(ImageFolder/text())[1]','VARCHAR(255)'), 'NotSentInXML'), 
           ISNULL(DataRows.ID.value(N'(DisplayImageTypeID/text())[1]','VARCHAR(50)'), 'NotSentInXML'), 
           dbo.DATETIMEOFFSET_EST(), 
           @ComputerName, 
           @UserName 
         FROM @XMLInputParameters.nodes('./XMLInputParameters/DisplayImage') AS DataRows(ID)

       -- It would be clever to just send back the full collection of records here, but we don't need to be that clever. Yet. 
       SET @XMLOutputParameters = (
         SELECT 'Success' AS Result 
         FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
     END 



  IF @Task = 'GetDisplayImages'
   BEGIN
     
     SELECT @DisplayNo = ISNULL(DataRows.ID.value(N'(DisplayNo/text())[1]','VARCHAR(50)'), 'NotSentInXML')
       FROM @XMLInputParameters.nodes('./XMLInputParameters') AS DataRows(ID)

     IF (@debug = 0) PRINT @DisplayNo

     SET @XMLOutputParameters = (
       SELECT 
       (SELECT * FROM DisplayImages WHERE DisplayNo = @DisplayNo AND HideDateTime IS NULL
       FOR XML RAW ('DisplayImage'), ELEMENTS, TYPE) AS DisplayImages
       FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
   END 

  IF @Task = 'HideDisplayImage'
    BEGIN
 
      SELECT @DisplayNo = ISNULL(DataRows.ID.value(N'(DisplayNo/text())[1]','VARCHAR(50)'), 'NotSentInXML'),
        @ImageFilename = ISNULL(DataRows.ID.value(N'(ImageFilename/text())[1]','VARCHAR(255)'), 'NotSentInXML')
        FROM @XMLInputParameters.nodes('./XMLInputParameters') AS DataRows(ID)

      UPDATE DisplayImages 
        SET
          [HideDateTime] = dbo.DATETIMEOFFSET_EST(),
          [HideComputerName] = @ComputerName,
          [HideUserID] = @UserName
        WHERE 
          DisplayNo = @DisplayNo AND
          ImageFilename = @ImageFilename
 
        SET @XMLOutputParameters = (
          SELECT 'Success' AS Result 
          FOR XML RAW ('XMLOutputParameters'), ELEMENTS)
    END 


  IF @Task = 'GetMaintLogRowsByDisplayID'
    BEGIN
      SELECT @DisplayID = ISNULL(DataRows.ID.value(N'(DisplayID/text())[1]','VARCHAR(50)'), 'NotSentInXML')
        FROM @XMLInputParameters.nodes('./XMLInputParameters') AS DataRows(ID)

        SET @XMLOutputParameters = (
            SELECT 
                (SELECT ML.MaintLogID, ML.DisplayID, ML.UserID, ML.MaintCode, MC.MaintCodeDesc, ML.DateIn, ML.MaintLogComment, ML.DateOut, ML.DisplayTypeID, DT.DisplayType
                  FROM [dbo].[MaintLog] ML
                INNER JOIN [dbo].[MaintCodes] MC ON ML.MaintCode = MC.MaintCode 
                INNER JOIN [dbo].[DisplayTypes] DT ON ML.DisplayTypeID = DT.DisplayTypeID 
                WHERE ML.DisplayID = @DisplayID
                ORDER BY ML.MaintLogID DESC
                FOR XML RAW ('MaintLogRow'), ELEMENTS, TYPE) AS MaintLogRows
            FOR XML RAW ('XMLOutputParameters'), ELEMENTS
        )

    END

  IF @Task = 'InsertMaintLogRow'
    BEGIN
      SELECT @DisplayID = ISNULL(DataRows.ID.value(N'(DisplayID/text())[1]','VARCHAR(50)'), 'NotSentInXML'),
        @UserID = ISNULL(DataRows.ID.value(N'(UserID/text())[1]','NVARCHAR(50)'), 'NotSentInXML'),
        @MaintCode = ISNULL(DataRows.ID.value(N'(MaintCode/text())[1]','INT'), 0),
        @MaintLogComment = ISNULL(DataRows.ID.value(N'(MaintLogComment/text())[1]','NVARCHAR(255)'), 'NotSentInXML'),
        @DisplayTypeID = ISNULL(DataRows.ID.value(N'(DisplayTypeID/text())[1]','INT'), 0)
        FROM @XMLInputParameters.nodes('./XMLInputParameters/MaintLogRow') AS DataRows(ID)

      SET @DateIn = dbo.DATETIMEOFFSET_EST()
      SET @DateOut = NULL

      -- If this is a comment, set the DateIn and DateOut to be the same. So in this universe, 8 is a magical, mystical number. 
      IF (@MaintCode = 8)  
        BEGIN
          SET @DateOut = @DateIn
        END 
      ELSE
        BEGIN
          -- If this isn't a comment, then any records that have null DateOut values are seen as being at a certain state. 
          -- I didn't come up with this logic, I'm just keeping the stuff the same for now. ~Ed
          UPDATE [dbo].[MaintLog] SET DateOut = @DateIn WHERE DisplayID = @DisplayID AND DateOut IS NULL 
        END

      INSERT INTO [dbo].[MaintLog] ([DisplayID],[UserID],[MaintCode],[DateIn],[MaintLogComment],[DateOut],[DisplayTypeID])
        VALUES
            (@DisplayID, @UserID, @MaintCode, @DateIn, @MaintLogComment, @DateOut, @DisplayTypeID)

        SET @XMLOutputParameters = (
            SELECT 'Success' AS Result 
            FOR XML RAW ('XMLOutputParameters'), ELEMENTS)

    END
  
  IF @Task = 'GetRepairLogRowsByDisplayID'
    BEGIN
      SELECT @DisplayID = ISNULL(DataRows.ID.value(N'(DisplayID/text())[1]','VARCHAR(50)'), 'NotSentInXML')
        FROM @XMLInputParameters.nodes('./XMLInputParameters') AS DataRows(ID)

        SET @XMLOutputParameters = (
            SELECT 
                (SELECT [RepairID], [RepairDateTime], [DisplayNo] AS DisplayID, CAST([Row] AS INT) AS [Row], CAST([Col] AS INT) AS Col, DF.DefectName AS DefectName, CAST(RL.[DefectID] AS INT) AS DefectID, 
                [Comment], [ImageAddr], CAST([SubPixel] AS INT) AS SubPixel, [PixelRemoved], [BlobContainer], [BlobFilename], [DBAComment] 
                  FROM [dbo].[RepairLog] RL
                LEFT OUTER JOIN [dbo].[Defects] DF  
                  ON RL.DefectID = DF.DefectID
                WHERE RL.DisplayNo = @DisplayID
                ORDER BY RL.RepairID DESC
                FOR XML RAW ('RepairLogRow'), ELEMENTS, TYPE) AS RepairLogRows
            FOR XML RAW ('XMLOutputParameters'), ELEMENTS
        )

    END


  IF @Task = 'GetDisplaySummaryRows_Latest'
   BEGIN

     SET @XMLOutputParameters = (
             SELECT 
            (SELECT ML.MaintLogID, ML.DisplayID, DT.DisplayType, ML.UserID, MC.MaintCodeDesc, ML.DateIn, ML.MaintLogComment, ML.DateOut, MLC.MaintLogCount, DIS.DisplayImageCount, RS.RepairCount
            FROM (
                  SELECT DisplayID, MAX(MaintLogID) AS MaintLogID
                  FROM [dbo].[MaintLog]
                  WHERE DateOut IS NULL
                  GROUP BY DisplayID
            ) MLS
            LEFT OUTER JOIN (
                SELECT DisplayNo, Count(DisplayNo) As DisplayImageCount FROM [DisplayImages] WHERE ISNUMERIC(DisplayNo) = 1 AND HideDateTime IS NULL GROUP BY DisplayNo) DIS  
                ON MLS.DisplayID = DIS.DisplayNo
            LEFT OUTER JOIN (
                SELECT DisplayNo, Count(DisplayNo) As RepairCount FROM [RepairLog] WHERE ISNUMERIC(DisplayNo) = 1 GROUP BY DisplayNo) RS  
                ON MLS.DisplayID = RS.DisplayNo
            INNER JOIN [dbo].[MaintLog] ML ON MLS.DisplayID = ML.DisplayID AND MLS.MaintLogID = ML.MaintLogID
            INNER JOIN [dbo].[MaintCodes] MC ON ML.MaintCode = MC.MaintCode 
            INNER JOIN [dbo].[DisplayTypes] DT ON ML.DisplayTypeID = DT.DisplayTypeID 
            INNER JOIN (SELECT DisplayID, COUNT(*) AS MaintLogCount
                        FROM [dbo].[MaintLog]
                        GROUP BY DisplayID
                        ) MLC ON MLC.DisplayID = ML.DisplayID 
            FOR XML RAW ('DisplaySummaryRow'), ELEMENTS, TYPE) AS DisplaySummaryRows
        FOR XML RAW ('XMLOutputParameters'), ELEMENTS
     )
   END 


        --SELECT 
        --    (SELECT ML.MaintLogID, ML.DisplayID, DT.DisplayType, ML.UserID, MC.MaintCodeDesc, ML.DateIn, ML.MaintLogComment, ML.DateOut, DIS.DisplayImageCount, RS.RepairCount
        --    FROM (
        --          SELECT DisplayID, MAX(DateIn) as DateIn
        --          FROM [dbo].[MaintLog]
        --          GROUP BY DisplayID
        --    ) MLS
        --    LEFT OUTER JOIN (
        --        SELECT DisplayNo, DisplayType FROM [Displays] WHERE ISNUMERIC(DisplayNo) = 1) DT  
        --        ON MLS.DisplayID = DT.DisplayNo
        --    LEFT OUTER JOIN (
        --        SELECT DisplayNo, Count(DisplayNo) As DisplayImageCount FROM [DisplayImages] WHERE ISNUMERIC(DisplayNo) = 1 AND HideDateTime IS NULL GROUP BY DisplayNo) DIS  
        --        ON MLS.DisplayID = DIS.DisplayNo
        --    LEFT OUTER JOIN (
        --        SELECT DisplayNo, Count(DisplayNo) As RepairCount FROM [RepairLog] WHERE ISNUMERIC(DisplayNo) = 1 GROUP BY DisplayNo) RS  
        --        ON MLS.DisplayID = RS.DisplayNo
        --    INNER JOIN [dbo].[MaintLog] ML ON MLS.DisplayID = ML.DisplayID AND MLS.DateIn = ML.DateIn
        --    INNER JOIN [dbo].[MaintCodes] MC ON ML.MaintCode = MC.MaintCode 
        --    FOR XML RAW ('DisplaySummaryRow'), ELEMENTS, TYPE) AS DisplaySummaryRows
        --FOR XML RAW ('XMLOutputParameters'), ELEMENTS
    

  IF @Task = 'GetDisplayTypes'
   BEGIN
     SET @XMLOutputParameters = (SELECT (       
        SELECT [DisplayTypeID] ,[DisplayType] 
        FROM [dbo].[DisplayTypes] 
        ORDER BY [DisplayType]
        FOR XML RAW ('DisplayTypesRow'), ELEMENTS, TYPE) AS DisplayTypesRows
        FOR XML RAW ('XMLOutputParameters'), ELEMENTS)   
   END 

  IF @Task = 'GetUsers'
   BEGIN
     SET @XMLOutputParameters = (SELECT (       
        SELECT [UserID] ,[UserEmail] 
        FROM [dbo].[Users] 
        ORDER BY [UserID]
        FOR XML RAW ('UsersRow'), ELEMENTS, TYPE) AS UsersRows
        FOR XML RAW ('XMLOutputParameters'), ELEMENTS)   
   END 

  IF @Task = 'GetMaintCodes'
   BEGIN
     SET @XMLOutputParameters = (SELECT (       
        SELECT [MaintCode] ,[MaintCodeDesc] 
        FROM [dbo].[MaintCodes] 
        ORDER BY [MaintCode]
        FOR XML RAW ('MaintCodesRow'), ELEMENTS, TYPE) AS MaintCodesRows
        FOR XML RAW ('XMLOutputParameters'), ELEMENTS)   
   END 

  IF @Task = 'UpdateRepairLogRowBlobFields'
    BEGIN
      SELECT @RepairID = ISNULL(DataRows.ID.value(N'(RepairID/text())[1]','INT'), 0),
          @BlobContainer = ISNULL(DataRows.ID.value(N'(BlobContainer/text())[1]','NVARCHAR(255)'), 'NotSentInXML'),
          @BlobFilename = ISNULL(DataRows.ID.value(N'(BlobFilename/text())[1]','NVARCHAR(255)'), 'NotSentInXML'),
          @DBAComment = ISNULL(DataRows.ID.value(N'(DBAComment/text())[1]','NVARCHAR(100)'), 'NotSentInXML')
        FROM @XMLInputParameters.nodes('./XMLInputParameters') AS DataRows(ID)

      UPDATE [dbo].[RepairLog] 
        SET [BlobContainer] = @BlobContainer,
        [BlobFilename] = @BlobFilename,
        [DBAComment] = @DBAComment
        WHERE RepairID = @RepairID


      SET @XMLOutputParameters = (
			  SELECT 
				  (SELECT [RepairID], [RepairDateTime], [DisplayNo] AS DisplayID, CAST([Row] AS INT) AS [Row], CAST([Col] AS INT) AS Col, CAST([DefectID] AS INT) AS DefectID, 
                [Comment], [ImageAddr], CAST([SubPixel] AS INT) AS SubPixel, [PixelRemoved], [BlobContainer], [BlobFilename], [DBAComment]
           FROM [dbo].[RepairLog] WHERE RepairID = @RepairID 
				  FOR XML RAW ('RepairLogRow'), ELEMENTS, TYPE) 
			  FOR XML RAW ('XMLOutputParameters'), ELEMENTS
		  )

    END
      

  -- Finally update the task log with the resulting XMLOutputParameters that is sent back to the calling application.
  UPDATE DisplayTask_Log 
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


  SET @CErrMsg = 'Proc: ' + OBJECT_NAME(@@ProcID) + ', Line: ' + CAST(@CErrLine as varchar(20)) + ', ErrNum: ' + CAST(@CErrNum as varchar(20)) + ' : ' + @CErrMsg

  SET @XMLOutputParameters = (
    SELECT @CErrMsg AS CErrMsg, 'Error' AS Result
    FOR XML RAW ('XMLOutputParameters'), ELEMENTS)

  RAISERROR(@CErrMsg, @CErrSeverity, @CErrState)

  RETURN

END CATCH
GO
ALTER DATABASE [DisplayData] SET  READ_WRITE 
GO
