using Congo.Logic;
using Congo.Logic.Models;
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
    public class ProductController : ApiController
    {
        IGetServices sv;
        public ProductController(IGetServices sv)
        {
            this.sv = sv;
        }


        // GET: api/Product
        public HttpResponseMessage Get()
        {
            var products = sv.getProducts();
            if(!products.Any())
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "No products found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, products);
            }
        }

        // GET: api/Product/5
        /// <summary>
        /// Get the products within a category
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public HttpResponseMessage Get(int id)
        {
            var products =  sv.getProducts(id);
            if (!products.Any())
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "Not found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, products);
            }
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
