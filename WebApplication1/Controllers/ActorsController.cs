using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ActorsController : Controller
    {
        // GET: Actors/Random

        public ActionResult Random()
        {
            var actor = new Actor() { Name = "Shrek!" };
            
            return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });  // Action,Controller, anonymous object with arguments !!!
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id); //http://localhost:51725/actors/edit/1
                                        //http://localhost:51725/actors/edit?id=2

        }

        public ActionResult Edit2(int actorId)
        {
            return Content("id=" + actorId); //http://localhost:51725/actors/edit2?actorId=1
                                             //

        }

        // actors
        public ActionResult Index(int? pageindex, string sortBy)
        {
            if (!pageindex.HasValue)
                pageindex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex={0}&sortBy={1}", pageindex, sortBy));
            //http://localhost:51725/actors?pageIndex=&sortBy=
        }
    }
}