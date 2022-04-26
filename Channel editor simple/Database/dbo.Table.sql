CREATE TABLE [dbo].[Lineup]
(
    [SourceID] NVARCHAR(6) NOT NULL, 
    [JDate] INT NULL, 
    [CallLetters] NVARCHAR(6) NULL, 
    [ChNumber] NVARCHAR(6) NULL, 
    [TSMask1] INT NULL, 
    [TSMask2] INT NULL, 
    [TSMask3] INT NULL, 
    [TSMask4] INT NULL, 
    [TSMask5] INT NULL, 
    [TSMask6] INT NULL, 
    [SrcAttr1] INT NULL, 
    [SrcAttr2] INT NULL, 
    PRIMARY KEY ([SourceID])
)
