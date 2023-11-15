using house_committee.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace house_committee.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MonthController : ControllerBase
    {
        private DataContext dataContext;
        public MonthController(DataContext context)
        {
            dataContext = context;
        }

        // GET: api/<MonthController>
        [HttpGet]
        public List<Month> Get()
        {
            return dataContext.months;
        }

        // GET api/<MonthController>/5
        [HttpGet("{id}")]
        public ActionResult<Month> Get(int id)
        {
            if (dataContext.months[id] == null)
                return NotFound();
            return dataContext.months[id];
        }
        [HttpGet("{id},{IsTake}")]
        public ActionResult<List<Month>> Get(int id, bool IsTake)
        {
            if (dataContext.months[id] == null)
                return NotFound();
            var a = dataContext.months.FindAll(x => x.IsTake == IsTake).ToList();
            return a;
        }

        // POST api/<MonthController>
        [HttpPost]
        public void Post(EmonthName name)
        {
            dataContext.months.Add(new Month() { Name = name });
        }

        // PUT api/<MonthController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {

            if (dataContext.months[id] == null)
                NotFound();
            else
                dataContext.months[id].IsTake = true;
        }

        private void HttpResponseMessage(HttpStatusCode notFound)
        {
            throw new NotImplementedException();
        }

    }
}
