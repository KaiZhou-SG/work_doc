CREATE TABLE MS_TMValidating_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code NVARCHAR(2) NOT NULL,

  CONSTRAINT pk_tmvalidating PRIMARY KEY (Msg_Id, Msg_Code),
  CONSTRAINT fk_tmvalidating_msgTypes FOREIGN KEY (Msg_Code)
    REFERENCES MS_Message_Types_Tbl(Msg_Code)
)

GO