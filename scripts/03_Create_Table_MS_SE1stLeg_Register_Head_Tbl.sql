-- the Sea Export 1st Leg registering message
-- 
CREATE TABLE MS_SE1stLeg_Register_Head_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code SMALLINT NOT NULL,
  Schedule_Date NVARCHAR(10) NOT NULL,
  Start_Time NVARCHAR(4) NOT NULL,
  End_Time NVARCHAR(4) NOT NULL,
  Prime_Mover VARCHAR(8) NOT NULL,
  Job_Number VARCHAR(26) NOT NULL,
  Job_Trip_SeqNO VARCHAR(7) NOT NULL,
  -- No message type here, because we already have Msg_Code

  CONSTRAINT 
    pk_MS_SE1stLeg_Register_Header_Tbl PRIMARY KEY (Msg_Id),
  CONSTRAINT
    fk_MS_SE1stLeg_Register_Header_Tbl_MS_Message_Types_Tbl
	FOREIGN KEY (Msg_Code) REFERENCES  MS_Message_Types_Tbl
)

GO
