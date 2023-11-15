using house_committee.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace house_committee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private DataContext dataContext;

        public PaymentController(DataContext context)
        {
            dataContext = context;
        }

        // GET: api/<PaymentController>
        [HttpGet]
        public List<Payment> Get()
        {
            return dataContext.paymentList;
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public ActionResult<Payment> Get(int id)
        {
            if (dataContext.paymentList[id] == null)
                return NotFound();
            return dataContext.paymentList[id];
        }

        // GET api/<PaymentController>/5
        [HttpGet("{epurpose}")]
        public ActionResult<List<Payment>> Get(Epurpose epurpose)
        {
            if (epurpose == Epurpose.electrical || epurpose == Epurpose.cleaner || epurpose == Epurpose.water)
            {
                var a = dataContext.paymentList.FindAll(x => x.epurpose == epurpose).ToList();
                return a;
            }
            return NotFound();
        }

        // POST api/<PaymentController>
        [HttpPost]
        public void Post(EMethods eMethods_Of, Epurpose epurpose, int sum)
        {
            dataContext.paymentList.Add(new Payment() { eMethods = eMethods_Of, epurpose = epurpose, Sum = sum });
        }

        // PUT api/<PaymentController>/5
        [HttpPut("{id}")]
        public void Put(int id)
        {
            if (dataContext.paymentList[id] == null)
                NotFound();
            else
                dataContext.paymentList[id].IsPayd = true;
        }

    }
}
