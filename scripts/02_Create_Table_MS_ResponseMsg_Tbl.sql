-- The response message table 

CREATE TABLE MS_ResponseMsg_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code NVARCHAR(2) NOT NULL,
  Response_String NVARCHAR(10) NOT NULL,

  CONSTRAINT 
    fk_MS_ResponseMsg_Tbl_MS_Message_Types_Tbl 
      FOREIGN KEY (Msg_Code) REFERENCES MS_Message_Types_Tbl,
  CONSTRAINT
	pk_MS_Response_Msg_Tbl 
	  PRIMARY KEY (Msg_Id)
)

GO
  