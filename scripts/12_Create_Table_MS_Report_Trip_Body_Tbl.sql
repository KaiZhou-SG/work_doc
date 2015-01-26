CREATE TABLE MS_Report_Trip_Body_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Type_Code NVARCHAR(3) NULL,
  Container_No1 NVARCHAR(20) NOT NULL,
  Container_No2 NVARCHAR(20) NULL,
  Seal_No1 NVARCHAR(20) NOT NULL,
  Seal_No2 NVARCHAR(20) NOT NULL,

  CONSTRAINT pk_rpt_trip_body PRIMARY KEY (Msg_Id),
  CONSTRAINT fk_rpt_trip_body_rpt_trip_head FOREIGN KEY
    (Msg_Id) REFERENCES MS_Report_Trip_Head_Tbl(Msg_Id)

)

GO