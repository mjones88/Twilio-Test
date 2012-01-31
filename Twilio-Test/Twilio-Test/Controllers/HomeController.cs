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
            twilio.Say("Thanks Dave. James is a douche.");
            return new TwiMLResult(twilio);
        }

    }
}
