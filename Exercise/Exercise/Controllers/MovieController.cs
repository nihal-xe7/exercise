using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Exercise.Models;

namespace Exercise.Controllers
{
    public class MovieController : Controller
    {
        //
        // GET: /Movie/

        public ApplicationDbContext _context;

        public MovieController()
        {
            _context=new ApplicationDbContext();
        }
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

        [Route("Movies/AddMovie")]
        public ActionResult AddMovie()
        {
            return View();
        }


        public ActionResult MovieAddingOperation(string name,string des)
        {
            var newMovie=new Movies(){Name=name,Description = des};
            _context.Movies.Add(newMovie);
            _context.SaveChanges();
            return Json(new { Message="success", JsonRequestBehavior.AllowGet});
        }
	}
}