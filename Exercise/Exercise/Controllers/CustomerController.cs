using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise.Models;

namespace Exercise.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        

        public ActionResult details()
        {
            var c = new Customer()
            {
                customers =new List<Customer>()
                {
                    new Customer() {Name = "Sarif", Id = 1},
                    new Customer() {Name = "Rakib", Id = 2}
                }
            };
            return View(c);
        }

        [Route("customer/info/{name}")]
        public ActionResult Information(string name)
        {
            var custom = new Customer() {Name = name};
            return Content("Customer Name=" + name);
        }
	}
}