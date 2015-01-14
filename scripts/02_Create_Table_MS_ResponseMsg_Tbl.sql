-- The response message table 

CREATE TABLE MS_ResponseMsg_Tbl (
  Msg_Code SMALLINT NOT NULL,
  Response_String VARCHAR(10) NOT NULL,

  CONSTRAINT 
    fk_MS_ResponseMsg_Tbl_MS_Message_Types_Tbl 
      FOREIGN KEY (Msg_Code) REFERENCES MS_Message_Types_Tbl,
  CONSTRAINT
	pk_MS_Response_Msg_Tbl 
	  PRIMARY KEY (Msg_Code)
)

GO
  