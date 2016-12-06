using Congo.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Congo.Client.Controllers
{
    public class UserRoleController : ApiController
    {

        IGetServices sv;
        public UserRoleController(IGetServices sv)
        {
            this.sv = sv;
        }


        // GET: api/UserRole
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UserRole/5
        public HttpResponseMessage Get(int id)
        {
            var role = sv.confirmRole(id);
            if(role.UserName == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, new { message = "Not found" });
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, role);
            }
        }

        // POST: api/UserRole
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UserRole/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UserRole/5
        public void Delete(int id)
        {
        }
    }
}
