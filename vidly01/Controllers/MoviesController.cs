using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly01.Models;

namespace vidly01.Controllers
{
    public class MoviesController : Controller
    {

        //Get:Movies/Random
       public ActionResult Random()
        {

            var movie = new Movie() { Name = "H Megalh Apofraji" };
            return View(movie);
        }



        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
    }
}