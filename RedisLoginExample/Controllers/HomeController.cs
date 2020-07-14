using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RedisLoginExample.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //https://docs.kentico.com/k9/running-kentico-on-microsoft-azure/storing-cache-and-session-state-data-in-azure-environment
        public ActionResult Index()
        {
            Response.Write(Request.ServerVariables["REMOTE_ADDR"]);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            Response.Write(Request.ServerVariables["REMOTE_ADDR"]);

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Response.Write(Request.ServerVariables["REMOTE_ADDR"]);

            return View();
        }
    }
}