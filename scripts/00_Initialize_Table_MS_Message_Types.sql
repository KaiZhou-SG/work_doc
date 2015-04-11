-- 2015-05-11

-- DELETE FROM MS_Message_Types_Tbl
GO

INSERT INTO MS_Message_Types_Tbl(Msg_Code, Msg_SubCode, 
  Msg_Type_Description) VALUES 
  --('10', 'COL', 'Register an Sea-Export 1st Leg'), -- collect empty containers
  --('11', 'EXP', 'Register an Sea-Export 2nd Leg'), -- export cargo
  --('12', 'IMP', 'Register an Sea-Import 1st Leg'), -- import cargo
  --('13', 'RTN', 'Register an Sea-Import 2nd Leg'), -- return empty containers
  --('14', 'FWD', 'GV forwards a registered job to a driver MDT'), 
  --('15', 'RE1', 'Driver report a SE1st leg is completed'), -- 
  --('16', 'RT2', 'Driver report a SE2nd leg is completed'),
  --('17', 'RT3', 'Driver report a SI1st leg is completed'),
  --('18', 'RT4', 'Driver report a SI2nd leg is completed'),
  --('20', 'AK1', 'GV acknowledges TM on receiving trip registering messages'), -- it can be driver acknowledges 
  --('21', 'AK2', 'Acknowledgement from driver on receiving a trip instruction'),
  --('22', 'AK3', 'TM acknowledges GV on receiving trip requesting messages')
  ('TI01', 'COL', 'Assign an Sea-Export 1st Leg'), -- collect empty containers
  ('TI01', 'EXP', 'Assign an Sea-Export 2nd Leg'), -- export cargo
  ('TI01', 'IMP', 'Assign an Sea-Import 1st Leg'), -- import cargo
  ('TI01', 'RTN', 'Assign an Sea-Import 2nd Leg'), -- return empty containers
  ('TU01', '01', 'GV reports that a trip is started'),
  ('TU01', '02', 'GV reports the container number'),
  ('TU01', '03', 'GV reports the seal number'),
  ('TU01', '04', 'GV reports the trailer number'),
  ('TU01', '05', 'GV reports the DO'),
  ('TU01', '06', 'GV reports a remark'),
  ('TU01', '07', 'GV reports a trip is ended')

  GO

  -- SELECT * FROM MS_Message_Types_Tbl

  
