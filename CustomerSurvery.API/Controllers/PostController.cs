using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSurvery.API.BusinessObjects;
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
        public Customer Post([FromBody] Customer customer)
        {
            var ins = _postObjects.InsertCustomer(customer);
            //var surveyData = _postObjects.InsertInitilSurveyData(ins);
            return ins;
        }

        [HttpPost("insertSurveyAnswers")]
        public bool Post([FromBody] List<SurveyAnswer> data)
        {
            var insdata = _postObjects.InsertData(data);
            return insdata;
        }
        [HttpPost("insertAll")]
        public SurveyData Post([FromBody] SurveyData data)
        {
            var insdata = _postObjects.insertAll(data);
            return insdata;
        }
    }
}
