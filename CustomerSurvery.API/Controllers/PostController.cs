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
        // POST api/values
        [HttpPost("MyPost/customerInfo")]
        public void Post([FromBody]string value)
        {
            var customer = new Customer();
            var ins = _postObjects.InsertCustomer(customer);

            return;
        }

        //// PUT api/values/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
