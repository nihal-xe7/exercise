using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise.Models;

namespace Exercise.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/
        public ActionResult Available()
        {
            var movie=new List<Movies>()
            {
                new Movies(){Name="Sherk!",Id = 1},
                new Movies(){Name="Wall-E",Id = 2}
            };

            var m=new Movies()
            {
                Movie = movie
            };
            return View(m);
        }

        
	}
}