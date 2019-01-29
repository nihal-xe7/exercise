using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Exercise.Models;
using System.Web.Http.Cors;
namespace Exercise.Controllers
{
    [EnableCors(origins: "https://localhost:4050/api/customers", headers: "*", methods: "*")]


    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context=new ApplicationDbContext();
        }
        //GET /api/customers
        public IEnumerable<Customer> GetCustomers()
        {
          return   _context.Customers.ToList();
          
        }

        //Get /api/customers/{id}
        public Customer GetCustomer(int id)
        {
            var customer= _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
                return customer;
            return customer;
        }

       
        public Customer GetCustomerData(string name, string password)
        {
            var customer = _context.Customers.FirstOrDefault(c=>c.Name==name && c.Password==password);
            return customer;
        }
        

        

      
    }
}
