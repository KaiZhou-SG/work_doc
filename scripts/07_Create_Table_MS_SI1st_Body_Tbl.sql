--DROP TABLE MS_SE1stBody_Tbl
--GO

CREATE TABLE MS_SE1st_Body_Tbl (
  Msg_Id BIGINT NOT NULL,
  Msg_Code NVARCHAR(4) NOT NULL,
  Msg_SubCode NVARCHAR(3) NOT NULL,
  Schedule_Date NVARCHAR(10) NOT NULL,
  Trip_Start_Time NVARCHAR(4) NOT NULL,
  Trip_End_Time NVARCHAR(4) NOT NULL,
  
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

  CONSTRAINT pk_se1stbody PRIMARY KEY (Msg_Id, Msg_Code),
  CONSTRAINT fk_se1stbody_se1sthead FOREIGN KEY (Msg_Id, Msg_Code) 
    REFERENCES MS_SE1stHead_Tbl(Msg_Id, Msg_Code)
)
GO