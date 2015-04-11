CREATE TABLE MS_Trip_Update_Head_Tbl (
  Msg_Id BIGINT IDENTITY(1,1) NOT NULL PRIMARY KEY,
  Msg_Code NVARCHAR(4) NOT NULL,
  Msg_SubCode NVARCHAR(3) NOT NULL,
  Prime_Mover NVARCHAR(8) NOT NULL,
  Job_No NVARCHAR(26) NOT NULL,
  Carrier_Ref_No NVARCHAR(26) NOT NULL,
  Trip_Seq_No NVARCHAR(7) NOT NULL,

  CONSTRAINT fk_report_trip_head_msg_type FOREIGN KEY (Msg_Code, Msg_SubCode) 
    REFERENCES MS_Message_Types_Tbl(Msg_Code, Msg_SubCode),
  -- unique key, to be referenced by ms_trip_update_body_tbl
  CONSTRAINT uni_trip_update_head UNIQUE(Msg_Id, Msg_Code, Msg_SubCode)
)

GO