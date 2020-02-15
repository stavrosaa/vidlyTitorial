using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly01.Models;
using vidly01.Models.ViewModels;

namespace vidly01.Controllers
{
    public class MoviesController : Controller
    {

        //Get:Movies/Random
       public ActionResult Random()
        {

            var movie = new Movie() { Name = "H Megalh Apofraji" };
            var customers = new List<Customer>
            {
                new Customer(){Name="customer 1"},
                new Customer(){Name="customer 2"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie=movie,
                Customers= customers

            };

            return View(viewModel);
        }



        // GET: Movies
        public ActionResult Index()
        {
            return View();
        }
    }
}