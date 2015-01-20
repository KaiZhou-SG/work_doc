-- 2015-01-19

DELETE FROM MS_Message_Types_Tbl
GO

INSERT INTO MS_Message_Types_Tbl(Msg_Code, Msg_Type_Code, 
  Msg_Type_Description) VALUES 
  ('10', 'COL', 'Register an Sea-Export 1st Leg'), -- collect empty containers
  ('11', 'EXP', 'Register an Sea-Export 2nd Leg'), -- export cargo
  ('12', 'IMP', 'Register an Sea-Import 1st Leg'), -- import cargo
  ('13', 'RTN', 'Register an Sea-Import 2nd Leg'), -- return empty containers
  ('14', 'FWD', 'GV forwards a registered job to a driver MDT'), 
  ('15', 'REQ', 'MDT request a job') -- it can be requesting any leg

  GO

  SELECT * FROM MS_Message_Types_Tbl
