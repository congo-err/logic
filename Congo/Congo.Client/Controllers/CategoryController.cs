using System;
using Congo.Logic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Congo.Logic;
using System.Web.Http.Cors;

namespace Congo.Client.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class CategoryController : ApiController
    {
        IGetServices sv;
        public CategoryController(IGetServices sv)
        {
            this.sv = sv;
        }


        // GET: api/Category
        public HttpResponseMessage Get()
        {
            var categories =  sv.getCategories();
            if (!categories.Any())
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "Not found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, categories);
            }
        }

        // GET: api/Category/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Category
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Category/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Category/5
        public void Delete(int id)
        {
        }
    }
}
