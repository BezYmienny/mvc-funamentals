using System;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View(movie);
        }
            //return View(actor) 
            // => return new ViewResult(actor);

            //return Content("HelloWorld");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });  // Action,Controller, anonymous object with arguments !!!
        //}


        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + " / " + month);
        }

        public ActionResult Index()
        {
            return Content("Zero Page of Movie controller");
        }

        //
        //"MoviesByReleaseDate",
            //    "movies/released/{year}/{month}",
            //     new { controller = "Movies", action = "ByReleaseDate" },
            // //   new { year = @"\d{4}", month = @"\d{2}" }); // ograniczenie długości lat , m-y
            //   new { year = @"2017|2018", month = @"\d{2}" }); // ograniczenie do roku 2017,18
        //
    
    }
}