using System;
using Congo.Logic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Congo.Logic;

namespace Congo.Client.Controllers
{
    public class CategoryController : ApiController
    {
        Service svc = new Service();
        dumbyService sv = new dumbyService();

        // GET: api/Category
        public List<CategoryDAO> Get()
        {
            return sv.getCategories();
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
