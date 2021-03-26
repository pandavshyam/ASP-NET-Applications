using RESTfulAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace RESTfulAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        public HttpResponseMessage GetEMpById(int id)
        {
            Employee emp = new Employee();
            var emps = emp.GetEMps();

            var emp1 = emps.Find(x => x.Id == id);

            HttpResponseMessage msg;

            if (emp1 == null)
            {
                msg = Request.CreateResponse(HttpStatusCode.NotFound, "Please send correct id");
            }

            else
            {
                msg = Request.CreateResponse(HttpStatusCode.OK, emp1);
            }
            return msg;
        }

        public IHttpActionResult GetEMpByIdUpdate(int id)
        {
            Employee emp = new Employee();
            var emps = emp.GetEMps();

            var emp1 = emps.Find(x => x.Id == id);

            if (emp1 == null)
            {
                return NotFound();
            }

            else
            {
                return Ok(emp1);
            }
        }
    }
}