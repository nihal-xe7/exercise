using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Exercise.Models;
using WebGrease.Css.Ast.Selectors;

namespace Exercise.Controllers
{
    public class LoginController : Controller
    {

        //
        // GET: /Login/
        public ApplicationDbContext _context;

        public LoginController()
        {
            _context=new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var login = new LoginModel();
            return View(login);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult logMeIn(LoginModel login)
        {

            if (!ModelState.IsValid)
            {
                View("Index", login);
            }
            
                var customer = _context.Customers
                    .SqlQuery(String.Format("select * from Customers Where name='{0}' and password='{1}'",
                        login.Name, login.Password)).ToList();
                if (customer.Count > 0)
                {
                    
                    return RedirectToAction("Index", "Home");
                }

                return Content("Name Or Password Error");
        }
	}
}