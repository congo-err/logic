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
    public class SingleProductController : ApiController
    {
        IGetServices sv;
        public SingleProductController(IGetServices sv)
        {
            this.sv = sv;
        }

        // GET: api/SingleProduct
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/SingleProduct/5
        public HttpResponseMessage Get(int id)
        {
            var product = sv.GetSingleProduct(id);
            if (product.ProductID == 0)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "Not found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, product);
            }
        }

        // POST: api/SingleProduct
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SingleProduct/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SingleProduct/5
        public void Delete(int id)
        {
        }
    }
}
