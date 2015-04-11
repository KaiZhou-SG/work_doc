-- message types

CREATE TABLE MS_Message_Types_Tbl (
  Msg_Code NVARCHAR(4) NOT NULL, -- 'TI01' or 'TU01'
  Msg_SubCode NVARCHAR(3) NOT NULL, -- 'COL', 'EXP', 'IMP', 'RTN'
  Msg_Type_Description NVARCHAR(50) NULL, -- a short description of this
                                    -- type of message

  CONSTRAINT pk_MS_Message_Types_Tbl PRIMARY KEY (Msg_Code, Msg_SubCode)
)

GO
