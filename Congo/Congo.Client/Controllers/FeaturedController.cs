using Congo.Logic;
using Congo.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Congo.Client.Controllers
{
    public class FeaturedController : ApiController
    {
        Service svc = new Service();
        dumbyService sv = new dumbyService();

        // GET: api/Featured
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Featured/5
        public List<ProductDAO> Get(int number)
        {
            return sv.getFeaturedItems(number);
        }

        // POST: api/Featured
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Featured/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Featured/5
        public void Delete(int id)
        {
        }
    }
}
