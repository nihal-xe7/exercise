using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Exercise.Models;

namespace Exercise.Controllers
{
    public class RegisterModelController : Controller
    {
        //
        // GET: /RegisterModel/

        public ApplicationDbContext _context;

        public RegisterModelController()
        {
            this._context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
           var register=new RegisterModel();
            return View(register);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RegisterModel register)
        {
            if (!ModelState.IsValid)
            {
                View("Index",register);
            }
          
           

                var customer = new Customer()
                {
                    Name = register.Name,
                    Password = register.Password,
                    DOB = register.DOB

                };

                var member = new MemberShip()
                {
                    IsSubscribed = register.IsSubscribed,
                    Discount = register.Discount,
                    SignUpFee = register.SignUpFee,
                    AcountType = register.AccountType

                };

                _context.MemberShips.Add(member);
                _context.SaveChanges();

                var memberNew = _context.MemberShips.ToList();
                int x = memberNew.Count;
                var memberId = memberNew[x - 1].Id;

                customer.MemberShipID = int.Parse(memberId.ToString());

                _context.Customers.Add(customer);
                _context.SaveChanges();
               
                return RedirectToAction("Index","Login");




        }
	}
}