CREATE TABLE MS_SI1st_Head_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code NVARCHAR(2) NOT NULL,
  Prime_Mover NVARCHAR(8) NOT NULL,
  Job_No NVARCHAR(26) NOT NULL,
  Trip_Seq_No NVARCHAR(7) NOT NULL,

  CONSTRAINT pk_si1st_head PRIMARY KEY (Msg_Id, Msg_Code),
  CONSTRAINT fk_si1st_head_msg_type FOREIGN KEY (Msg_Code) 
    REFERENCES MS_Message_Types_Tbl(Msg_Code) 
)

GO