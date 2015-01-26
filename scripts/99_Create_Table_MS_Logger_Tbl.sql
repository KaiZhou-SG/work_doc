DROP TABLE MS_Logger_Tbl
GO

CREATE TABLE MS_Logger_Tbl (
  Msg_Code NVARCHAR(2) NOT NULL,
  Msg_Id BIGINT NOT NULL,
  Sent_Date NVARCHAR(10) NOT NULL,
  Sent_Time NVARCHAR(4) NOT NULL,
  Received_Date NVARCHAR(10) NOT NULL,
  Received_Time NVARCHAR(4) NOT NULL,
  Sent_By NVARCHAR(10) NOT NULL,
  Received_By NVARCHAR(10) NOT NULL,

  CONSTRAINT pk_ms_logger PRIMARY KEY (Msg_Code, Msg_Id)
  -- no foreign key here
)

GO