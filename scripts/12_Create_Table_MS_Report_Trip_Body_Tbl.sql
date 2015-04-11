CREATE TABLE MS_Trip_Update_Body_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code NVARCHAR(4) NOT NULL,
  Msg_SubCode NVARCHAR(3) NOT NULL,
  Container_No1 NVARCHAR(20) NOT NULL,
  Container_No2 NVARCHAR(20) NULL,
  Seal_No1 NVARCHAR(20) NOT NULL,
  Seal_No2 NVARCHAR(20) NULL,
  Report_Time NVARCHAR(16) NOT NULL,
  DO NVARCHAR(20), 

  CONSTRAINT pk_ms_trip_update PRIMARY KEY (Msg_Id, Msg_Code, Msg_SubCode, Report_Time),
  CONSTRAINT fk_rpt_trip_body_rpt_trip_head FOREIGN KEY (Msg_Id, Msg_Code, Msg_SubCode)
    REFERENCES MS_Trip_Update_Head_Tbl(Msg_Id, Msg_Code, Msg_SubCode)

)

GO