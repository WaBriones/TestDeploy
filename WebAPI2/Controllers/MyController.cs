using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Data.Models;


// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI2.Controllers
{
    [Route("api/[controller]")]
    public class MyController : Controller
    {
       

        [HttpGet("MyGet/{id}")]
        public Questions Get(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion1(quest);
            return a;

        }

        [HttpGet("MyGet/question2")]
        public Questions GetQ2(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion2(quest);
            return a;

        }

        [HttpGet("MyGet/question3")]
        public Questions GetQ3(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion3(quest);
            return a;

        }

        [HttpGet("MyGet/question4")]
        public Questions GetQ4(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion4(quest);
            return a;

        }

        [HttpGet("MyGet/question5")]
        public Questions GetQ5(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion5(quest);
            return a;

        }

        [HttpGet("MyGet/question6")]
        public Questions GetQ6(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion6(quest);
            return a;

        }

        [HttpGet("MyGet/question7")]
        public Questions GetQ7(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion7(quest);
            return a;

        }

        [HttpGet("MyGet/question8")]
        public Questions GetQ8(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion8(quest);
            return a;

        }

        [HttpGet("MyGet/question9")]
        public Questions GetQ9(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion9(quest);
            return a;

        }

        [HttpGet("MyGet/question10")]
        public Questions GetQ10(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion10(quest);
            return a;

        }

        [HttpGet("MyGet/question11")]
        public Questions GetQ11(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion11(quest);
            return a;

        }

        [HttpGet("MyGet/question12")]
        public Questions GetQ12(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion12(quest);
            return a;

        }

        [HttpGet("MyGet/question13")]
        public Questions GetQ13(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion13(quest);
            return a;

        }

        [HttpGet("MyGet/question14")]
        public Questions GetQ14(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion14(quest);
            return a;

        }

        [HttpGet("MyGet/question15")]
        public Questions GetQ15(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion15(quest);
            return a;

        }

        [HttpGet("MyGet/question16")]
        public Questions GetQ16(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion16(quest);
            return a;

        }

        [HttpGet("MyGet/question17")]
        public Questions GetQ17(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion17(quest);
            return a;

        }

        [HttpGet("MyGet/question18")]
        public Questions GetQ18(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion18(quest);
            return a;

        }

        [HttpGet("MyGet/question19")]
        public Questions GetQ19(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion19(quest);
            return a;

        }

        [HttpGet("MyGet/question20")]
        public Questions GetQ20(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion20(quest);
            return a;

        }

        [HttpGet("MyGet/question21")]
        public Questions GetQ21(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion21(quest);
            return a;

        }

        [HttpGet("MyGet/question22")]
        public Questions GetQ22(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion22(quest);
            return a;

        }

        [HttpGet("MyGet/question23")]
        public Questions GetQ23(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion23(quest);
            return a;

        }

        [HttpGet("MyGet/question24")]
        public Questions GetQ24(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion24(quest);
            return a;

        }

        [HttpGet("MyGet/question25")]
        public Questions GetQ25(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion25(quest);
            return a;

        }

        [HttpGet("MyGet/question26")]
        public Questions GetQ26(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion26(quest);
            return a;

        }

        [HttpGet("MyGet/question27")]
        public Questions GetQ27(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion27(quest);
            return a;

        }

        [HttpGet("MyGet/question28")]
        public Questions GetQ28(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion28(quest);
            return a;

        }
        [HttpGet("MyGet/question29")]
        public Questions GetQ29(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion29(quest);
            return a;

        }

        [HttpGet("MyGet/question30")]
        public Questions GetQ30(int id)
        {
            var quest = new Questions();
            var a = new DataObjects().GetQuestion30(quest);
            return a;

        }





    }
}
