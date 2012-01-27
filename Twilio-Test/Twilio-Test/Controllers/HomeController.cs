using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio.TwiML;
using Twilio.TwiML.Mvc;

namespace Twilio_Test.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var twilio = new TwilioResponse();
            twilio.Say("Fuck it friday");
            return new TwiMLResult(twilio);
        }

    }
}
