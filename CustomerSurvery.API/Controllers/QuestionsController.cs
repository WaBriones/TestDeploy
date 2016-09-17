using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerSurvery.API.BusinessObjects;
using Microsoft.AspNet.Mvc;



// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    public class QuestionsController : Controller
    {
        private readonly DataObjects _dataObjects;
        public QuestionsController(DataObjects dataObjects)
        {
            _dataObjects = dataObjects;
        }

        [HttpGet("{id}")]
        public Questions Get(int id)
        {
            var question = _dataObjects.GetQuestionById(id);
            return question;
        }

        [HttpGet("getall")]
        public List<Questions> GetAllQuestions()
        {
            var question = _dataObjects.GetAllQuestions();
            return question;
        }
        
    }
}
