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
    public class CartController : ApiController
    {
        Service svc = new Service();

        // GET: api/Cart
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Cart/5
        public CartDAO Get(int id)
        {
            return svc.getCart(id);
        }

        // POST: api/Cart
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Cart/5
        public void Delete(int id)
        {
        }
    }
}
