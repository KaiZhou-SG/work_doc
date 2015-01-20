-- message types

CREATE TABLE MS_Message_Types_Tbl (
  Msg_Code NVARCHAR(2) NOT NULL, -- 2 digits integer
  Msg_Type_Code NVARCHAR(3) NOT NULL, -- e.g. RTN, COL...
  Msg_Type_Description NVARCHAR(50) NULL, -- a short description of this
                                    -- type of message

  CONSTRAINT pk_MS_Message_Types_Tbl PRIMARY KEY (Msg_Code)
)

GO
