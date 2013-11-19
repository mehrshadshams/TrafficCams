using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TrafficCams.Controllers
{
    public class CameraController : Controller
    {
        //
        // GET: /Camera/
        public ActionResult Index()
        {
            return View();
        }
	}
}