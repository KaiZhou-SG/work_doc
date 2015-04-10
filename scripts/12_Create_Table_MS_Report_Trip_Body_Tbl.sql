CREATE TABLE MS_Report_Trip_Body_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code NVARCHAR(2) NOT NULL,
  Container_No1 NVARCHAR(20) NOT NULL,
  Container_No2 NVARCHAR(20) NULL,
  Seal_No1 NVARCHAR(20) NOT NULL,
  Seal_No2 NVARCHAR(20) NULL,
  Report_Time NVARCHAR(16) NOT NULL,

  CONSTRAINT pk_rpt_trip_body PRIMARY KEY (Msg_Id, Msg_Code, Report_Time),
  CONSTRAINT fk_rpt_trip_body_rpt_trip_head FOREIGN KEY (Msg_Id, Msg_Code)
    REFERENCES MS_Report_Trip_Head_Tbl(Msg_Id, Msg_Code)

)

GO