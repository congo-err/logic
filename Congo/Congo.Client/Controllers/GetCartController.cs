using Congo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Congo.Client.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class GetCartController : ApiController
    {

        IGetServices sv;
        public GetCartController(IGetServices sv)
        {
            this.sv = sv;
        }
        // GET: api/GetCart
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/GetCart/5
        public HttpResponseMessage Get(int id)
        {
            var cart = sv.getCart(id);
            if (cart.Customer == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "Not found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, cart);
            }
        }

        // POST: api/GetCart
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/GetCart/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/GetCart/5
        public void Delete(int id)
        {
        }
    }
}
