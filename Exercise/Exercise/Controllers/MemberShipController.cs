using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;
using Exercise.Models;

namespace Exercise.Controllers
{
    public class MemberShipController : Controller
    {
        //
        // GET: /MemberShip/

        public ApplicationDbContext _context;

        public MemberShipController()
        {
            _context=new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var members = _context.Customers.Include(c => c.MemberShip).ToList();
            return View(members);
        }

       
	}
}