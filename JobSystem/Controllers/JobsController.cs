using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobSystem.Models;

namespace JobSystem.Controllers
{
    public class JobsController : Controller
    {
        // GET: Jobs/Random
        public ActionResult Random()
        {
            var job = new Job() { Name = "test" };
            return View(job);
        }
    }
}