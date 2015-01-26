using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//
using MS_Simulator.Models;

namespace MS_Simulator.Controllers
{
    public class MS_PlannerUIController : ApiController
    {
        #region "Actions"
        // validate trip requesting messages
        [HttpPost]
        [Route("planner/validate/trip/se1st")]
        public HttpResponseMessage ValidateTripRequestingMessage(
            Models.SE.SE1stLeg msgRegSE1stLeg)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);

            return response;
        }
        // validate trip status changing messages
        [HttpPost]
        [Route("planner/validate/tripStatus")]
        public HttpResponseMessage ValidateTripuestingMessage(
            Models.Acknowledges.Acknowledge msgAcknkowledgeFromDriver)
        {
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created);

            return response;
        }
        #endregion 
    }
}
