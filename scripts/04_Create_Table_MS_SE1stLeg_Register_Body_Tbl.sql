-- the Sea Export 1st Leg registering message header
-- 

CREATE TABLE MS_SE2ndLeg_Register_Body_Tbl (
  Msg_Id BIGINT NOT NULL,
  Container_Qty SMALLINT NOT NULL,
  Container_Size VARCHAR(4) NOT NULL,
  Container_Type VARCHAR(4) NOT NULL,
  From_Location VARCHAR(12) NOT NULL,
  To_Location VARCHAR(12) NOT NULL,
  Remark VARCHAR(30) NULL

  CONSTRAINT 
    pk_MS_SE2ndLeg_Register_Body_Tbl PRIMARY KEY (Msg_Id),
  CONSTRAINT 
    fk_pk_MS_SE2ndLeg_Register_Body_Tbl_MS_Message_Types_Tbl
	FOREIGN KEY (Msg_Id) REFERENCES MS_SE2ndLeg_Register_Head_Tbl(Msg_Id)
)

GO
    
