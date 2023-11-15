using house_committee.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace house_committee.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TenantController : ControllerBase
    {
        private DataContext dataContext;
        public TenantController(DataContext context)
        {
            dataContext = context;
        }
        // GET: api/<TenantController>
        [HttpGet]
        public List<Tenant> Get()
        {
            return dataContext.tenantList;
        }

        // GET api/<TenantController>/5
        [HttpGet("{id}")]
        public ActionResult<Tenant> Get(int id)
        {
            if (dataContext.tenantList[id] == null)
                return NotFound();
            return dataContext.tenantList[id];
        }

        [HttpGet("{id},{name}")]
        public ActionResult<int[]> Get(int id, string name)
        {
            if (dataContext.tenantList[id] == null)
                return NotFound();
            int[] arr = new int[12], a2;
            int k = 0;
            for (int i = 0; i < dataContext.tenantList[id].IsPaid.Count; i++)
            {
                if (!dataContext.tenantList[id].IsPaid[i])
                    arr[k++] = i + 1;
            }
            a2 = new int[k];
            for (int i = 0; i < a2.Length; i++)
            {
                a2[i] = arr[i];
            }
            return a2;
        }

        // POST api/<TenantController>
        [HttpPost]
        public void Post(string name, string phone, EtypeTenant etype, int floor)
        {
            dataContext.tenantList.Add(new Tenant() { floor = floor, Name = name, Phone = phone, type = etype, IsPaid = new List<bool>() });
        }

        // PUT api/<TenantController>/5
        [HttpPut("{id}")]
        public void Put(int id, EmonthName month)
        {
            if (dataContext.tenantList[id] == null)
                NotFound();
            else
                dataContext.tenantList[id].IsPaid[(int)month] = true;
        }
        // DELETE api/< TenantController >/ 5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (dataContext.tenantList[id] == null)
            {
                dataContext.tenantList.Remove(dataContext.tenantList[id]);
            }
            else
                NotFound();
        }
    }
}

