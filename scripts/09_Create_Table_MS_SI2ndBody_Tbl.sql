--DROP TABLE MS_SI2ndBody_Tbl
--GO

CREATE TABLE MS_SI2ndBody_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code NVARCHAR(2) NOT NULL, -- this column with Msg_Id together formed the primary key and foreign key
  Schedule_Date NVARCHAR(10) NOT NULL,
  Trip_Start_Time NVARCHAR(4) NOT NULL,
  Trip_End_Time NVARCHAR(4) NOT NULL,
  -- Msg_Type_Code NVARCHAR(3) NOT NULL, -- already has message code
  Vessel NVARCHAR(30) NOT NULL,
  Voyage NVARCHAR(30) NOT NULL,
  Book_Ref_No NVARCHAR(20) NOT NULL,
  Shipping_Line NVARCHAR(20) NOT NULL,
  Port_Of_Destination NVARCHAR(15) NOT NULL,
  Container_Qty SMALLINT NOT NULL,
  Container_Size NVARCHAR(2) NOT NULL,
  Container_Type NVARCHAR(4) NOT NULL,
  From_Location NVARCHAR(12) NOT NULL,
  To_Location NVARCHAR(12) NOT NULL,
  Remark NVARCHAR(30) NULL,

  CONSTRAINT pk_si2ndbody PRIMARY KEY (Msg_Id, Msg_Code),
  CONSTRAINT fk_si2ndbody_se1sthead FOREIGN KEY (Msg_Id, Msg_Code) 
    REFERENCES MS_SI2ndHead_Tbl(Msg_Id, Msg_Code)
)
GO