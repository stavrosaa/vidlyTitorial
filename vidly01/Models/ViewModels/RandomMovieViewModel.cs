using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly01.Models;

namespace vidly01.Models.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer>  Customers { get; set; }

    }
}