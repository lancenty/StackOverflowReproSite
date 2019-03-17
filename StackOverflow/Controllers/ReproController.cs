using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StackOverflow.Controllers
{
    public class ReproController : Controller
    {
        // GET: Repro
        public ActionResult StackOverflow()
        {
            ReproStackOverflow.stackOverflow();
            return View();
        }
    }

    public class ReproStackOverflow
    {
        public static Boolean stackOverflow()
        {
            stackOverflow();
            return true;
        }
    }
}