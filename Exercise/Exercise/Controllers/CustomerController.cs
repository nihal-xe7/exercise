using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Exercise.Models;

namespace Exercise.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ApplicationDbContext _context;

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public CustomerController()
        {
            _context=new ApplicationDbContext();
        }
        public ActionResult details()
        {

            var c = _context.Customers.Include( co=>co.MemberShip).ToList();
            return View(c);
        }

        [Route("customer/info/{name}")]
        public ActionResult Information(string  name)
        {
            var custom = new Customer() {Name = name};
            return Content("Customer Name=" + name);
        }

        [Route("customer/MemberShip")]
        public ActionResult MemberShipDetails()
        {
            var member = _context.MemberShips.ToList();
            return View(member);
        }

        [HttpPost]
        public ActionResult UpdateDOB(int id,string dob)
        {
            _context.Customers.First(c=>c.Id==id).DOB=dob;
            _context.SaveChanges();
            return Json(new { Message = "Success", JsonRequestBehavior.AllowGet });
        }


	}
}