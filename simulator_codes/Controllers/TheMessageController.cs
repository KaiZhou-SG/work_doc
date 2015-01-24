using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//
using FM.FMSystem.BLL;
using MS_Simulator.Models;

namespace MS_Simulator.Controllers
{
    public class TheMessageController : ApiController
    {
        [HttpPost]
        [ActionName("RegMsgSE1stLeg")]
        //[Route("api/RegisterSE1stLeg")]
        public HttpResponseMessage RegisterSeaExport1stLeg([FromBody]TheMessage msg)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            // insert the message into database
            TheMessage register_SE1stLeg = new TheMessage();
            try
            {
                register_SE1stLeg.RegisterSE1stLeg(msg);
                response = Request.CreateResponse<TheMessage>(HttpStatusCode.Created, msg);
                String uri = Url.Link("SE1stLeg_Register", new { id = msg.MsgHead.MsgId });
                response.Headers.Location = new Uri(uri);

                return response;
            }
            catch (FMException fme)
            {
                response = Request.CreateErrorResponse(HttpStatusCode.BadRequest,
                    "Failed to register an Sea-Export 1st Leg job trip. Exception: " +
                    fme.Message);
                return response;
            }

        }

        #region "For testing only"

        [HttpGet]
        [ActionName("EnvironmentTesting")]
        public String Test(String str)
        {
            return str;
        }

        [HttpGet]
        [ActionName("GetMessageID")]
        // the default action
        public int GetMessage(int id)
        {
            return id;
        }

        #endregion
    }
}
