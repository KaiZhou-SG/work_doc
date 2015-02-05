-- 2015-02-04 Zhou Kai 

INSERT INTO CRT_System_Special_Setup_Detail_Tbl VALUES(
  'Haulage',
  'SetTripsReady_WhenImportingSeaJob',
  'Auto set all the trips of a sea job to ready when it is imported into Haulage module',
  'F', -- default to false
  '' -- leave the module id to blank
)

BEGIN TRANSACTION
UPDATE CRT_System_Special_Setup_Detail_Tbl
SET Setting_Value = 'T'
WHERE Setting_Name = 'SetTripsReady_WhenImportingSeaJob'
--COMMIT
ROLLBACK

