using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MS_Simulator.Models
{
    /// <summary>
    /// MsgSE1stLegBody.cs
    /// the body of the Sea-Export 1st Leg registering message body: body of Msg1
    /// </summary>
    public class MsgSE1stLegBody : MessageBody
    {
        #region "Fields"
        private String strVessel;
        private String strVoyage;
        private String strBookRefNo;
        private String strShippingLine;
        private String strPOD;
        private int nContainerQty;
        private String strContainerSize; // can only be 20, 40 or 45
        private String strContainerType;
        private String strFromLocation;
        private String strToLocation;
        private String strRemark;

        public String Vessel
        {
            get { return strVessel; }
            set { strVessel = value; }
        }
        public String Voyage
        {
            get { return strVessel; }
            set { strVessel = value; }
        }

        public String BookRefNo
        {
            get { return strBookRefNo; }
            set { strBookRefNo = value; }
        }

        public String ShippingLine
        {
            get { return strShippingLine; }
            set { strShippingLine = value; }
        }

        public String POD
        {
            get { return strPOD; }
            set { strPOD = value; }
        }

        public int ContainerQty
        {
            get { return nContainerQty; }
            set { nContainerQty = value; }
        }

        public String ContainerSize
        {
            get { return strContainerSize; }
            set { strContainerSize = value; }
        }

        public String ContainerType
        {
            get { return strContainerType; }
            set { strContainerType = value; }
        }

        public String FromLocation
        {
            get { return strFromLocation; }
            set { strFromLocation = value; }
        }

        public String ToLocation
        {
            get { return strToLocation; }
            set { strToLocation = value; }
        }

        public String Remark
        {
            get { return strRemark; }
            set { strRemark = value; }
        }

        #endregion

        #region "Functions"
        public override bool GeneralSelfCheck()
        {
            // rule 1:
            // if the container size is 40, the container quantity should be 1
            // if the container size is 20, the container quantity can be 1 or 2
            bool rtn = false;
            if (strContainerSize == "20")
            {
                if (!(nContainerQty == 1 || nContainerQty == 2))
                {
                    rtn = false;
                }
            }
            else if (strContainerSize == "40" && nContainerQty != 1) { rtn = false; }
            else if (strContainerSize == "45" && nContainerQty != 1) { rtn = false; }
            else { rtn = false; /* container szie is not 20, 40 nor 45 */}

            return rtn;
        }

        #endregion

        #region "Constructors"
        public MsgSE1stLegBody() : base()
        {
            this.strVessel = String.Empty;
            this.strVoyage = String.Empty;
            this.strBookRefNo = String.Empty;
            this.strShippingLine = String.Empty;
            this.strPOD = String.Empty;
            this.nContainerQty = 0;
            this.strContainerSize = String.Empty;
            this.strContainerType = String.Empty;
            this.strFromLocation = String.Empty;
            this.strToLocation = String.Empty;
            this.strRemark = String.Empty;

        }

        public MsgSE1stLegBody(String vessel, String voyage,
            String bookRefNo, String shippingLine, String pod, int nContainerQty,
            String containerSize, String containerType, String fromLocation,
            String toLocation, String remark) : base()
        {
            this.strVessel = vessel;
            this.strVoyage = voyage;
            this.strBookRefNo = bookRefNo;
            this.strShippingLine = shippingLine;
            this.strPOD = pod;
            this.nContainerQty = nContainerQty;
            this.strContainerSize = containerSize;
            this.strContainerType = containerType;
            this.strFromLocation = fromLocation;
            this.strToLocation = toLocation;
            this.strRemark = remark;

        }
        
        #endregion

    }
}