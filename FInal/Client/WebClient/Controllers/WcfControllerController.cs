using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebClient.Controllers
{
    public class WcfController : ApiController
    {
        // GET: api/WcfController
        public IEnumerable<string> Get()
        {
            return new string[] { "SOMETHING STUPID", "value2" };
        }

        // GET: api/WcfController/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/WcfController
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/WcfController/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/WcfController/5
        public void Delete(int id)
        {
        }
    }
}
