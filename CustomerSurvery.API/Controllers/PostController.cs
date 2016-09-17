using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.Models;
using Microsoft.AspNet.Mvc;
using WebAPI2.Data.Access.Objects;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    public class PostController : Controller
    {
        private readonly PostObjects _postObjects;
        public PostController(PostObjects postObjects)
        {
            _postObjects = postObjects;
        }
        
        [HttpPost("customerInsert")]
        public bool Post([FromBody] Customer customer)
        {
            var ins = _postObjects.InsertCustomer(customer);
            return ins;
        }

        [HttpGet("getallcustomers")]
        public List<Customer> GetAllCustomers()
        {
            return _postObjects.GetAllCustomers();
        }

    }
}
